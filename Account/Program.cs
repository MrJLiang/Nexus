﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Aiursoft.Pylon;
using Aiursoft.Account.Data;

namespace Aiursoft.Account
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args)
                .MigrateDbContext<AccountDbContext>()
                .Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            var host = WebHost.CreateDefaultBuilder(args)
                 .UseApplicationInsights()
                 .UseStartup<Startup>()
                 .Build();

            return host;
        }
    }
}
