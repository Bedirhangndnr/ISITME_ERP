using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CustomerDtos;
using MyBlog.Mvc.Areas.Admin.Models;
using MyBlog.Mvc.Areas.Admin.Models.SingleModels;
using MyBlog.Services.Abstract;

namespace MyBlog.Mvc.Areas.Notification.ViewComponents
{
    public class NotificationMenuViewComponent:ViewComponent
    {
        private readonly INotificationService _notificationService;
        private readonly IMapper _mapper;


        public NotificationMenuViewComponent(INotificationService notificationService, IMapper mapper)
        {
            _notificationService= notificationService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notifications = await _notificationService.GetAllByNonDeletedAndActiveAsync();
            return View(new NotificationViewModel
            {
                notificationListWithRelatedTables=notifications.Data.NotificationListWithRelatedTables
            }) ;
        }
    }
}
