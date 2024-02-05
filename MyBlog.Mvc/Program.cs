using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyBlog.BackgroundServices;
using MyBlog.Mvc;

namespace ProgrammersBlog.Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                })
            .ConfigureServices(services => 
                {
                    services.AddHostedService<TimedHostedService>();
                })
            ;
        //.ConfigureServices((hostContext, services) =>
        //{
        //    services.AddHostedService<BackGroundWorkerService>(); // Arka plan servisi ekleyin
        //});
    }
}



