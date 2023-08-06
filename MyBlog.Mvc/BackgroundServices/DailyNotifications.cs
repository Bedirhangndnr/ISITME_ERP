using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using Timer = System.Timers.Timer;

namespace MyBlog.Mvc.BackgroundServices
{
    public class DailyNotifications : IHostedService, IAsyncDisposable
    {
        //private readonly IServiceScopeFactory _scopeFactory;
        //private readonly Timer _timer;

        //public DailyNotifications(IServiceScopeFactory scopeFactory)
        //{
        //    _scopeFactory = scopeFactory;
        //    _timer = new Timer();
        //    _timer.Elapsed += async (sender, e) => await DoWorkAsync();
        //}

        //public Task StartAsync(CancellationToken cancellationToken)
        //{
        //    // Set the interval to 30 seconds (30,000 milliseconds)
        //    _timer.Interval = 30000;
        //    _timer.Enabled = true;
        //    return Task.CompletedTask;
        //}

        //private async Task DoWorkAsync()
        //{
        //    using (var scope = _scopeFactory.CreateScope())
        //    {
        //        var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();
        //        var appointmentService = scope.ServiceProvider.GetRequiredService<IAppointmentService>();

        //        // Create the notification message
        //        var notificationMessage = NotificationMessageService.GetMessage(
        //            NotificationMessageTypes.Added,
        //            TableNamesConstants.Expenses,
        //            "aa"
        //        );

        //        // Add the notification
        //        await notificationService.AddAsync(notificationMessage, "Bildirim Başlığıx", userId: 1);
        //    }
        //}

        //public async Task StopAsync(CancellationToken cancellationToken)
        //{
        //    _timer?.Stop();
        //    // IAsyncDisposable yöntemini burada çağırmalısınız
        //    await DisposeAsync();
        //}

        //public async ValueTask DisposeAsync()
        //{
        //    // IAsyncDisposable yöntemini burada çağırmalısınız
        //    if (_timer != null)
        //    {
        //        _timer.Stop();
        //        _timer.Dispose();
        //    }
        //}
        public Task StartAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
