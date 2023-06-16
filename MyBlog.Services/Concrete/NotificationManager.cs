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
            }, Messages.General.NotFound(isPlural: false, "Hasta"));
        }
        public async Task<IDataResult<NotificationListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var notifications = await UnitOfWork.Notifications.GetAllAsync(x => !x.IsDeleted);
            if (notifications.Count > -1)
            {
                return new DataResult<NotificationListDto>(ResultStatus.Success, new NotificationListDto
                {
                    Notifications = notifications,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<NotificationListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

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
                return new DataResult<NotificationUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Hasta Tipi"));
            }
        }

        //public async Task<IDataResult<NotificationListDto>> GetAllAsync()
        //{
        //    var Notifications = await UnitOfWork.Notifications.GetAllAsync(null);
        //    if (Notifications.Count > -1)
        //    {
        //        return new DataResult<NotificationListDto>(ResultStatus.Success, new NotificationListDto
        //        {
        //            Notifications = Notifications,
        //        });
        //    }
        //    return new DataResult<NotificationListDto>(ResultStatus.Error, new NotificationListDto
        //    {
        //        Notifications = null,
        //    }, Messages.General.NotFound(isPlural: true, "Hasta"));
        //}
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

        //public async Task<IDataResult<NotificationListDto>> GetAllByDeletedAsync()
        //{
        //    var Notifications = await UnitOfWork.Notifications.GetAllAsync(c=>c.IsDeleted, c => c.Notification);
        //    if (Notifications.Count > -1)
        //    {
        //        return new DataResult<NotificationListDto>(ResultStatus.Success, new NotificationListDto
        //        {
        //            Notifications = Notifications,
        //        });
        //    }
        //    return new DataResult<NotificationListDto>(ResultStatus.Error, new NotificationListDto
        //    {
        //        Notifications = null,
        //    }, Messages.Notification.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<NotificationListDto>> GetAllByNonDeletedAsync()
        //{
        //    var Notifications = await UnitOfWork.Notifications.GetAllAsync(c => !c.IsDeleted, c => c.Notification);
        //    if (Notifications.Count > -1)
        //    {
        //        return new DataResult<NotificationListDto>(ResultStatus.Success, new NotificationListDto
        //        {
        //            Notifications = Notifications,
        //        });
        //    }
        //    return new DataResult<NotificationListDto>(ResultStatus.Error, new NotificationListDto
        //    {
        //        Notifications = null,
        //    }, Messages.Notification.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<NotificationListDto>> GetAllByNonDeletedAndActiveAsync()
        //{
        //    var Notifications = await UnitOfWork.Notifications.GetAllAsync(c => !c.IsDeleted && c.IsActive);
        //    if (Notifications.Count > -1)
        //    {
        //        return new DataResult<NotificationListDto>(ResultStatus.Success, new NotificationListDto
        //        {
        //            Notifications = Notifications,
        //        });
        //    }
        //    return new DataResult<NotificationListDto>(ResultStatus.Error, new NotificationListDto
        //    {
        //        Notifications = null,
        //    }, Messages.General.NotFound(isPlural: true, "Hasta"));
        //}



        //public async Task<IDataResult<NotificationDto>> DeleteAsync(int NotificationId, string modifiedByName)
        //{
        //    var Notification = await UnitOfWork.Notifications.GetAsync(c => c.Id == NotificationId);
        //    if (Notification != null)
        //    {
        //        Notification.IsDeleted = true;
        //        Notification.IsActive = false;
        //        Notification.ModifiedByName = modifiedByName;
        //        Notification.ModifiedDate = DateTime.Now;
        //        var deletedNotification = await UnitOfWork.Notifications.UpdateAsync(Notification);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<NotificationDto>(ResultStatus.Success, new NotificationDto
        //        {
        //            Notification = deletedNotification,
        //        }, Messages.Notification.Delete(deletedNotification.CreatedByName));
        //    }
        //    return new DataResult<NotificationDto>(ResultStatus.Error, new NotificationDto
        //    {
        //        Notification = null,
        //    }, Messages.Notification.NotFound(isPlural: false));
        //}

        //public async Task<IResult> HardDeleteAsync(int NotificationId)
        //{
        //    var Notification = await UnitOfWork.Notifications.GetAsync(c => c.Id == NotificationId);
        //    if (Notification != null)
        //    {
        //        await UnitOfWork.Notifications.DeleteAsync(Notification);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.Notification.HardDelete(Notification.CreatedByName));
        //    }
        //    return new Result(ResultStatus.Error, Messages.Notification.NotFound(isPlural: false));
        //}

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var NotificationsCount = await UnitOfWork.Notifications.CountAsync();
        //    if (NotificationsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, NotificationsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1,$"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var NotificationsCount = await UnitOfWork.Notifications.CountAsync(c=>!c.IsDeleted);
        //    if (NotificationsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, NotificationsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<NotificationDto>> ApproveAsync(int NotificationId, string modifiedByName)
        //{
        //    var Notification = await UnitOfWork.Notifications.GetAsync(c => c.Id == NotificationId, c => c.Notification);
        //    if (Notification != null)
        //    {
        //        Notification.IsActive = true;
        //        Notification.ModifiedByName = modifiedByName;
        //        Notification.ModifiedDate = DateTime.Now;
        //        var updatedNotification = await UnitOfWork.Notifications.UpdateAsync(Notification);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<NotificationDto>(ResultStatus.Success, new NotificationDto
        //        {
        //            Notification = updatedNotification
        //        }, Messages.Notification.Approve(NotificationId));
        //    }

        //    return new DataResult<NotificationDto>(ResultStatus.Error, null, Messages.Notification.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<NotificationDto>> UndoDeleteAsync(int NotificationId, string modifiedByName)
        //{
        //    var Notification = await UnitOfWork.Notifications.GetAsync(c => c.Id == NotificationId);
        //    if (Notification != null)
        //    {
        //        Notification.IsDeleted = false;
        //        Notification.IsActive = true;
        //        Notification.ModifiedByName = modifiedByName;
        //        Notification.ModifiedDate = DateTime.Now;
        //        var deletedNotification = await UnitOfWork.Notifications.UpdateAsync(Notification);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<NotificationDto>(ResultStatus.Success, new NotificationDto
        //        {
        //            Notification = deletedNotification,
        //        }, Messages.Notification.UndoDelete(deletedNotification.CreatedByName));
        //    }
        //    return new DataResult<NotificationDto>(ResultStatus.Error, new NotificationDto
        //    {
        //        Notification = null,
        //    }, Messages.Notification.NotFound(isPlural: false));
        //}
    }
}
