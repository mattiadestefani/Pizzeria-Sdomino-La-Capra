using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PizzeriaSdomino.Service;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzeria.Service
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _configuration;
        private readonly PizzeriaCore _pizzeriaCore;

        public Worker(ILogger<Worker> logger, IConfiguration configuration, PizzeriaCore pizzeriacore)
        {
            _logger = logger;
            _configuration = configuration;
            _pizzeriaCore = pizzeriacore;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                _pizzeriaCore.Engine();
                await Task.Delay(30000, stoppingToken);
            }
        }
    }
}
