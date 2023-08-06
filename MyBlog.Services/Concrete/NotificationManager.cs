using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.NotificationDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using MyBlog.Data.Concrete.EntityFramework.Context;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Entities.Dtos.NotificationDtos;

namespace MyBlog.Services.Concrete
{
    public class NotificationManager:ManagerBase,INotificationService
    {
        private readonly MyBlogContext _dbContext;

        public NotificationManager(MyBlogContext dbContext, IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<IDataResult<NotificationDto>> GetAsync(int NotificationId)
        {
            var Notification = await UnitOfWork.Notifications.GetAsync(c => c.Id == NotificationId);
            if (Notification != null)
            {
                return new DataResult<NotificationDto>(ResultStatus.Success, new NotificationDto
                {
                    Notification = Notification,
                });
            }
            return new DataResult<NotificationDto>(ResultStatus.Error, new NotificationDto
            {
                Notification = null,
            }, Messages.General.NotFound(isPlural: false, "Bildirim"));
        }
        public async Task<IDataResult<NotificationUpdateDto>> GetNotificationUpdateDtoAsync(int NotificationId)
        {
            var result = await UnitOfWork.Notifications.AnyAsync(c => c.Id == NotificationId);
            if (result)
            {
                var Notification = await UnitOfWork.Notifications.GetAsync(c => c.Id == NotificationId);
                var NotificationUpdateDto = Mapper.Map<NotificationUpdateDto>(Notification);
                return new DataResult<NotificationUpdateDto>(ResultStatus.Success, NotificationUpdateDto);
            }
            else
            {
                return new DataResult<NotificationUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Bildirim"));
            }
        }

        public async Task<IDataResult<NotificationListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var notifications = await UnitOfWork.Notifications.GetAllWithNamesAsync(c => !c.IsDeleted && c.IsActive);
            if (notifications.Count > -1)
            {
                return new DataResult<NotificationListDto>(ResultStatus.Success, new NotificationListDto
                {
                    NotificationListWithRelatedTables = notifications,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<NotificationListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Bildirim"));
        }



        public async Task<bool> AddAsync(string message, string title, int userId,  NotificationTypes notificationType= NotificationTypes.DatabaseTracking)
        {
            NotificationAddDto notificationAddDto = new NotificationAddDto
            {
                IsRead = false,
                Description = message,
                Title = title,
                UserId=userId,
                NotificationType= NotificationMessageService.GetType(notificationType),
                CreatedByName="admin",
                ModifiedByName="admin",
            };
            var notification = Mapper.Map<Notification>(notificationAddDto);
            var addedNotification = await UnitOfWork.Notifications.AddAsync(notification);
            await UnitOfWork.SaveAsync();
            return true;
        }

        public async Task<bool> UpdateAsync(NotificationUpdateDto NotificationUpdateDto, string modifiedByName)
        {
            var oldNotification = await UnitOfWork.Notifications.GetAsync(c => c.Id == NotificationUpdateDto.Id);
            var notification = Mapper.Map<NotificationUpdateDto, Notification>(NotificationUpdateDto, oldNotification);
            notification.ModifiedByName = modifiedByName;
            var updatedNotification = await UnitOfWork.Notifications.UpdateAsync(notification);
            notification = await UnitOfWork.Notifications.GetAsync(a => a.Id == NotificationUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return true;
        }
        public async Task<IDataResult<NotificationDto>> DeleteAsync(int NotificationId, string modifiedByName)
        {
            var notification = await UnitOfWork.Notifications.GetAsync(c => c.Id == NotificationId);
            if (notification != null)
            {
                notification.IsDeleted = true;
                //notification.IsActive = false;
                notification.ModifiedByName = modifiedByName;
                notification.ModifiedDate = DateTime.Now;
                var deletedNotification = await UnitOfWork.Notifications.UpdateAsync(notification);
                await UnitOfWork.SaveAsync();
                return new DataResult<NotificationDto>(ResultStatus.Success, new NotificationDto
                {
                    Notification = deletedNotification,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.General.GiveMessage(notification.Title, "Bildirim", MessagesConstants.DeletedSuccess)

                }, Messages.General.GiveMessage(notification.Title, "Bildirim", MessagesConstants.DeletedSuccess));
            }
            return new DataResult<NotificationDto>(ResultStatus.Error, new NotificationDto
            {
                Notification = null,
            }, Messages.General.GiveMessage(notification.Title, "Bildirim", MessagesConstants.DeletedError));
        }

        public async Task<IResult> HardDeleteAsync(int NotificationId)
        {
            var notification = await UnitOfWork.Notifications.GetAsync(c => c.Id == NotificationId);
            if (notification != null)
            {
                await UnitOfWork.Notifications.DeleteAsync(notification);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(notification.Title, "Bildirim", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.NotFound(isPlural: false, "Bildirim"));
        }
    }
}
