using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentTypeDtos;
using MyBlog.Entities.Dtos.MessageToDeveloperDtos;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;
using MyBlog.Entities.Dtos.AppointmentTypeDtos;

namespace MyBlog.Services.Abstract
{
    public interface IMessageToDeveloperService : IGenericService<MessageToDeveloper>
    {
        Task<IDataResult<MessageToDeveloperDto>> GetAsync(int MessageToDeveloperId);
        Task<IDataResult<MessageToDeveloperUpdateDto>> GetMessageToDeveloperUpdateDtoAsync(int MessageToDeveloperId);
        Task<IDataResult<MessageToDeveloperListDto>> GetAllAsync();
        Task<IDataResult<MessageToDeveloperDto>> DeleteAsync(int MessageToDeveloperId, string modifiedByName);
        Task<IDataResult<MessageToDeveloperListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<MessageToDeveloperDto>> AddAsync(MessageToDeveloperAddDto MessageToDeveloperAddDto, string createdByName);
        Task<IDataResult<MessageToDeveloperDto>> UpdateAsync(MessageToDeveloperUpdateDto MessageToDeveloperUpdateDto, string modifiedByName);

        Task<IDataResult<MessageToDeveloperListDto>> GetAllByDeletedAsync();
        Task<IDataResult<MessageToDeveloperDto>> UndoDeleteAsync(int EmployeeTypeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();

    }
}