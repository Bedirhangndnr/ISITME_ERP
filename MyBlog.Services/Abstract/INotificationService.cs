using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.NotificationDtos;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;

namespace MyBlog.Services.Abstract
{
    public interface INotificationService : IGenericService<Notification>
    {
        Task<IDataResult<NotificationDto>> GetAsync(int NotificationId);
        Task<IDataResult<NotificationUpdateDto>> GetNotificationUpdateDtoAsync(int NotificationId);
        //Task<IDataResult<NotificationListDto>> GetAllAsync();
        //Task<IDataResult<NotificationListDto>> GetAllByDeletedAsync();
        //Task<IDataResult<NotificationListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<NotificationListDto>> GetAllByNonDeletedAndActiveAsync();
        //Task<bool> AddAsync(string message, string title, int customerId, DateTime? targetDate);
        Task<bool> AddAsync(string message, string title, NotificationTypes notificationType = NotificationTypes.DatabaseTracking);

        //Task<IDataResult<NotificationDto>> ApproveAsync(int NotificationId, string modifiedByName);
        Task<bool> UpdateAsync(NotificationUpdateDto NotificationUpdateDto, string modifiedByName);
        //Task<IDataResult<NotificationDto>> DeleteAsync(int NotificationId, string modifiedByName);
        //Task<IDataResult<NotificationDto>> UndoDeleteAsync(int NotificationId, string modifiedByName);
        //Task<IResult> HardDeleteAsync(int NotificationId);
        //Task<IDataResult<int>> CountAsync();
        //Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}