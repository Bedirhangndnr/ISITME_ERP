using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyBlog.Entities.Concrete;
using MyBlog.Services; // NotificationService ve diğer gereken servislerin adımları
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Messages.NotificationMessages; // Bildirim modeli veya entity sınıfı

namespace MyBlog.BackgroundServices
{
    public class BackGroundWorkerService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;

        public BackGroundWorkerService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();
                    var notificationMessage = NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Added,
                        TableNamesConstants.Expenses,
                        "aa"
                    );

                    await notificationService.AddAsync(notificationMessage, "Notification Title | Try", userId: 1);

                    Thread.Sleep(TimeSpan.FromSeconds(2));
                }
            }
        }
    }
}