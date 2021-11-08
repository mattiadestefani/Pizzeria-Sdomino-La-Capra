using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzeriaSdomino.Service;
using PizzeriaSdomino.Reader;
using PizzeriaSdomino.Writer;

namespace Pizzeria.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<PizzeriaCore>();
                    services.AddSingleton<IAudit, ConsoleLogger>();
                    services.Decorate<IAudit, FileLogger>();
                    services.Decorate<IAudit, SqlLogger>();
                    services.AddSingleton<IReader, CSVReader>();
                    services.AddHostedService<Worker>();
                });
    }
}
