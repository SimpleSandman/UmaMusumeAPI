using System;
using System.IO;
using System.Reflection;
using System.Text;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Controllers;

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

            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.Cookie.Name = ".UmaMusumeAPI.Session";
            });

            // Used for generic controllers via BaseController
            services.AddMvc(o => o.Conventions.Add(
                    new GenericControllerRouteConvention()
                )).
                ConfigureApplicationPartManager(m =>
                    m.FeatureProviders.Add(new GenericTypeControllerFeatureProvider()
                ));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
                { 
                    Title = "Uma Musume API", 
                    Version = "v2022.11.06",
                    Description = "A community API for the mobile game, Uma Musume: Pretty Derby. " 
                        + "This is utilizing the \"master.mdb\" file",
                    Contact = new OpenApiContact
                    {
                        Name = "GitHub",
                        Email = string.Empty,
                        Url = new Uri("https://github.com/SimpleSandman/UmaMusumeAPI")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under Apache 2.0",
                        Url = new Uri("https://www.apache.org/licenses/LICENSE-2.0")
                    }
                });

                // Locate the XML file being generated by ASP.NET in order to use
                // human-friendly descriptors for Operations, Parameters, and Schemas
                string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
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

            // RapiDoc workaround
            app.MapWhen(x => x.Request.Path.StartsWithSegments("/rapidoc"), appBuilder =>
            {
                appBuilder.Run(async context =>
                {
                    context.Response.ContentType = "text/html";

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("<!doctype html>");
                    sb.AppendLine("<html>");
                    sb.AppendLine("<head>");
                    sb.AppendLine("  <meta charset=\"utf-8\">");
                    sb.AppendLine("  <script type=\"module\" src=\"https://unpkg.com/rapidoc/dist/rapidoc-min.js\"></script>");
                    sb.AppendLine("</head>");
                    sb.AppendLine("<body>");
                    sb.AppendLine("  <rapi-doc");
                    sb.AppendLine("    spec-url=\"./swagger/v1/swagger.json\"");
                    sb.AppendLine("    theme=\"dark\"");
                    sb.AppendLine("  > </rapi-doc>");
                    sb.AppendLine("</body> ");
                    sb.AppendLine("</html>");

                    await context.Response.WriteAsync(sb.ToString());
                });
            });

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
