using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace UmaMusumeAPI.Context
{
    public class UmaMusumeDbContextFactory : IDesignTimeDbContextFactory<UmaMusumeDbContext>
    {
        public UmaMusumeDbContext CreateDbContext(string[] args)
        {
            /*
             * When using the Package Manager Console (PMC) to generate code, 
             * set the connection string first for the environment variable,
             * then call "dotnet-aspnet-codegenerator.exe" normally.
             */
            // PM> $env:MARIA_CONNECTION_STRING='user id=;password=;host=;database=;character set=utf8mb4'
            // PM> dotnet-aspnet-codegenerator.exe
            string connectionString = Environment.GetEnvironmentVariable("MARIA_CONNECTION_STRING");

            var optionsBuilder = new DbContextOptionsBuilder<UmaMusumeDbContext>();

            MariaDbServerVersion serverVersion = new MariaDbServerVersion(ServerVersion.AutoDetect(connectionString));
            optionsBuilder.UseMySql(connectionString, serverVersion);

            return new UmaMusumeDbContext(optionsBuilder.Options);
        }
    }
}
