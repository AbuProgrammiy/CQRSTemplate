using Microsoft.Extensions.Hosting;

namespace CQRSTemplate.Application.BackgroundServices
{
    public class MainBackgroundService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine("Hello from BackgroundService!");

                await Task.Delay(1000);
            }
        }
    }
}
