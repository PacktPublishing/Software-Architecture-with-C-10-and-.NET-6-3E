using Microsoft.Extensions.Hosting;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GenericHost
{
    public class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<HostedService>();
                    services.AddHostedService<MonitoringService>();
                })
                .ConfigureLogging((hostContext, configLogging) =>
                {
                    configLogging.AddConsole();
                })
                .Build();

            host.Run();

            Console.WriteLine("Host has terminated. Press any key to finish the App.");
            Console.ReadKey();
        }
    }
}
