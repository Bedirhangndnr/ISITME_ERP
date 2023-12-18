using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using MyBlog.Mvc.Areas.Admin.Models.SingleModels;
using MyBlog.Services.Abstract;

public class NotificationMenuViewComponent : ViewComponent
{
    private readonly INotificationService _notificationService;
    private readonly IMapper _mapper;
    private readonly IMemoryCache _cache;

    public NotificationMenuViewComponent(INotificationService notificationService, IMapper mapper, IMemoryCache cache)
    {
        _notificationService = notificationService;
        _mapper = mapper;
        _cache = cache;
    }

    public async Task<IViewComponentResult> InvokeAsync()
  {
        var cacheKey = "notifications";
        if (!_cache.TryGetValue(cacheKey, out NotificationViewModel notificationModel))
        {
            var notifications = await _notificationService.GetAllByNonDeletedAndActiveAsync();
            notificationModel = new NotificationViewModel
            {
                notificationListWithRelatedTables = notifications.Data.NotificationListWithRelatedTables
            };
            var cacheEntryOptions = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromHours(3));
            _cache.Set(cacheKey, notificationModel, cacheEntryOptions);
        }

        return View(notificationModel);
    }
}
