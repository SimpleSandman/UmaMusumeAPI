using System;
using System.IO;
using System.Reflection;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

using UmaMusumeAPI.Context;

namespace UmaMusumeAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Environment.GetEnvironmentVariable("MARIA_CONNECTION_STRING");
            MariaDbServerVersion serverVersion = new MariaDbServerVersion(ServerVersion.AutoDetect(connectionString));

            services.AddDbContextPool<UmaMusumeDbContext>(
                dbContextOptions => dbContextOptions
                    .UseMySql(connectionString, serverVersion)
                    //.EnableSensitiveDataLogging() // These two calls are optional but help
                    //.EnableDetailedErrors()       // with debugging (remove for production).
            );

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
                { 
                    Title = "Uma Musume API", 
                    Version = "v1.0.1",
                    Description = "A community API for the mobile game, Uma Musume: Pretty Derby. " 
                        + "This is utilizing the \"master.mdb\" file",
                    Contact = new OpenApiContact
                    {
                        Name = "Simple Sandman",
                        Email = string.Empty,
                        Url = new Uri("https://twitter.com/simple_sandman")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under Apache 2.0",
                        Url = new Uri("https://www.apache.org/licenses/LICENSE-2.0")
                    }
                });

                // Locate the XML file being generated by ASP.NET in order to use
                // human-friendly descriptors for Operations, Parameters, and Schemas
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlPath));
            });

            // Allow "Access-Control-Allow-Origin: *" header
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAnyOrigin", builder =>
                {
                    builder.AllowAnyOrigin();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts(); // HTTP Strict Transport Security (HSTS)
            }

            app.UseCors("AllowAnyOrigin");

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "UmaMusumeAPI v1");
                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
