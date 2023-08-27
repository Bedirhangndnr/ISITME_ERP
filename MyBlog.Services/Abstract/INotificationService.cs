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
using MyBlog.Entities.Dtos.NotificationDtos;

namespace MyBlog.Services.Abstract
{
    public interface INotificationService : IGenericService<Notification>
    {
        Task<IDataResult<NotificationDto>> GetAsync(int NotificationId);
        Task<IDataResult<NotificationUpdateDto>> GetNotificationUpdateDtoAsync(int NotificationId);
        Task<IDataResult<NotificationListDto>> GetAllByNonDeletedAndActiveAsync(string notificationType="All", int customerId=0  ); //--
        Task<bool> AddAsync(string message, string title, int userId, NotificationTypes notificationType = NotificationTypes.DatabaseTracking, int customerId = 0);//--
        Task<bool> UpdateAsync(NotificationUpdateDto NotificationUpdateDto, string modifiedByName);

        Task<IDataResult<NotificationDto>> DeleteAsync(int NotificationId, string modifiedByName);

        Task<IResult> HardDeleteAsync(int NotificationId);


    }
}