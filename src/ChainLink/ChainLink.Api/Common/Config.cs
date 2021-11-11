using System;

namespace ChainLink.Api.Common
{
    public static class Config
    {
        public static string DatabaseConnectionString()
        {
            string dbUser = Environment.GetEnvironmentVariable("DB_USER"); 
            string dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
            string dbHost = Environment.GetEnvironmentVariable("DB_HOST");
            string dbPort = Environment.GetEnvironmentVariable("DB_PORT");
            string dbName = Environment.GetEnvironmentVariable("DB_NAME");
            
            string dbConnectionString = $"User ID={dbUser};" +
                                        $"Password={dbPassword};" +
                                        $"Host={dbHost};" +
                                        $"Port={dbPort};" +
                                        $"Database={dbName};" +
                                        $"SSL Mode=Require;" +
                                        $"Trust Server Certificate=true";

            return dbConnectionString;
        }
    }
}