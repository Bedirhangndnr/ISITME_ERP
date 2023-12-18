using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyBlog.Data.Abstract;
using MyBlog.Data.Concrete;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Entities.Dtos.NotificationDtos;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;

public class TimedHostedService : BackgroundService
{
    private readonly ILogger<TimedHostedService> _logger;
    private readonly IServiceScopeFactory _serviceScopeFactory;
    private readonly TimeSpan _interval;

    public TimedHostedService(
        ILogger<TimedHostedService> logger,
        IServiceScopeFactory serviceScopeFactory)
    {
        _logger = logger;
        _serviceScopeFactory = serviceScopeFactory;
        _interval = TimeSpan.FromHours(24); // 5 saniyelik periyot
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await using (var scope = _serviceScopeFactory.CreateAsyncScope())
            {
                var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
                var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();
                // Burada unitOfWork ve mapper'ı kullanabilirsiniz
                await DoWork(unitOfWork, mapper);
            }

            await Task.Delay(_interval, stoppingToken);
        }
    }

    private async Task<IDataResult<NotificationAddDto>> DoWork(IUnitOfWork unitOfWork, IMapper mapper)
    {
        var customersBirtshDay = await unitOfWork.Customers.GetAllForRemaindAsync();
        foreach (var item in customersBirtshDay)
        {
            string description=" ";
            DateTime today = DateTime.Today;
            DateTime birthDateThisYear = item.BirthDate.Value.AddYears(today.Year - item.BirthDate.Value.Year);

            TimeSpan timeDifference = birthDateThisYear - today;
            int daysRemaining = timeDifference.Days;


            switch (daysRemaining)
            {
                case 0:
                    description = "Bugün " + item.FirstName + " " + item.LastName + " isimli hastanın doğum günü!";
                    break;
                case 1:
                    description = "Yarın " + item.FirstName + " " + item.LastName + " isimli hastanın doğum günü!";
                    break;
                case 2:
                    description = "2 gün sonra " + item.FirstName + " " + item.LastName + " isimli hastanın doğum günü!";
                    break;
                case 3:
                    description = "3 gün sonra " + item.FirstName + " " + item.LastName + " isimli hastanın doğum günü!";
                    break;
                default:
                    description = ""; // Eğer doğum günü 3 günden uzakta ise, açıklama yok.
                    break;
            }

            // 'description' içeriği kullanılabilir.


            NotificationAddDto notifyBirthDay = new NotificationAddDto
            {

                IsRead = true,
                Note = item.BirthDate.ToString().Split(" ")[0],
                Description = description != " " ? description : "Belirtilmemiş.",
                Title = "Doğum Günü",
                UserId = 1,
                NotificationType = NotificationMessageService.GetType(NotificationTypes.BirthDayReminder),
                CreatedByName = "admin",
                ModifiedByName = "admin",
                CustomerId = 1,
            };
            var notification = mapper.Map<Notification>(notifyBirthDay);
            var addedNotification = await unitOfWork.Notifications.AddAsync(notification);
            await unitOfWork.SaveAsync();
        }

        var getProducts = await unitOfWork.Sales.GetAllForProductCareAsync();
        foreach (var item in getProducts)
        {
            string description = " ";
            DateTime today = DateTime.Today;
            DateTime careDay = item.CreatedDate;
            TimeSpan timeDifference = careDay - today;
            int daysRemaining = timeDifference.Days;


            switch (daysRemaining)
            {
                case 0:
                    description = "Bugün " + item.CustomerFirstName+ " isimli hastanın ürününün bakım günü!";
                    break;
                case 1:
                    description = "Yarın " + item.CustomerFirstName + " isimli hastanın ürününün bakım günü!";
                    break;
                case 2:
                    description = "2 gün sonra " + item.CustomerFirstName+ " isimli hastanın ürününün bakım günü!";
                    break;
                case 3:
                    description = "3 gün sonra " + item.CustomerFirstName+ " isimli hastanın ürününün bakım günü!";
                    break;
                case 4:
                    description = "4 gün sonra " + item.CustomerFirstName+ " isimli hastanın ürününün bakım günü!";
                    break;
                case 5:
                    description = "5 gün sonra " + item.CustomerFirstName+ " isimli hastanın ürününün bakım günü!";
                    break;
                default:
                    description = ""; // Eğer doğum günü 3 günden uzakta ise, açıklama yok.
                    break;
            }

            // 'description' içeriği kullanılabilir.


            NotificationAddDto notifyCare = new NotificationAddDto
            {

                IsRead = true,
                Note = "",
                Description = description != " " ? description : "Belirtilmemiş.",
                Title = "Bakım!",
                UserId = 1,
                NotificationType = NotificationMessageService.GetType(NotificationTypes.MonthlyProductCareReminder),
                CreatedByName = "admin",
                ModifiedByName = "admin",
                CustomerId = 1,
            };
            var notification = mapper.Map<Notification>(notifyCare);
            var addedNotification = await unitOfWork.Notifications.AddAsync(notification);
            await unitOfWork.SaveAsync();
        }
        NotificationAddDto notify = new NotificationAddDto
        {

            IsRead = true,
            Note = "",
            Description = "",
            Title = "Bakım!",
            UserId = 1,
            NotificationType = NotificationMessageService.GetType(NotificationTypes.BirthDayReminder),
            CreatedByName = "admin",
            ModifiedByName = "admin",
            CustomerId = 1,
        };
        return new DataResult<NotificationAddDto>(ResultStatus.Success, notify);
    }
}