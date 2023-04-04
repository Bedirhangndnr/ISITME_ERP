using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentTypeDtos;
using MyBlog.Entities.Dtos.AppointmentTypeDtos;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;

namespace MyBlog.Services.Abstract
{
    public interface IAppointmentTypeService : IGenericService<AppointmentType>
    {
        Task<IDataResult<AppointmentTypeDto>> GetAsync(int AppointmentTypeId);
        Task<IDataResult<AppointmentTypeUpdateDto>> GetAppointmentTypeUpdateDtoAsync(int AppointmentTypeId);
        Task<IDataResult<AppointmentTypeListDto>> GetAllAsync();
        Task<IDataResult<AppointmentTypeDto>> DeleteAsync(int AppointmentTypeId, string modifiedByName);
        Task<IDataResult<AppointmentTypeListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<AppointmentTypeDto>> AddAsync(AppointmentTypeAddDto AppointmentTypeAddDto, string createdByName);
        Task<IDataResult<AppointmentTypeDto>> UpdateAsync(AppointmentTypeUpdateDto AppointmentTypeUpdateDto, string modifiedByName);

        Task<IDataResult<AppointmentTypeListDto>> GetAllByDeletedAsync();
        Task<IDataResult<AppointmentTypeDto>> UndoDeleteAsync(int EmployeeTypeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}