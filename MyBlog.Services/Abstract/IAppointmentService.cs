using MyBlog.Entities.Dtos;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Entities.Dtos.SaleDtos;

namespace MyBlog.Services.Abstract
{
    public interface IAppointmentService : IGenericService<Appointment>
    {
        Task<IDataResult<AppointmentDto>> GetAsync(int AppointmentId);
        Task<IDataResult<AppointmentUpdateDto>> GetAppointmentUpdateDtoAsync(int AppointmentId);
        Task<IDataResult<AppointmentListDto>> GetAllAsync();
        Task<IDataResult<AppointmentListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<AppointmentListDto>> GetAllByDeletedAsync();
        Task<IDataResult<AppointmentListDto>> GetAllByNonDeletedAsync();
        Task<IResult> AddAsync(AppointmentAddDto AppointmentAddDto, string createdByName, int userId);
        //Task<IDataResult<AppointmentDto>> ApproveAsync(int AppointmentId, string modifiedByName);
        Task<IResult> UpdateAsync(AppointmentUpdateDto AppointmentUpdateDto, string modifiedByName);
        //Task<IDataResult<AppointmentDto>> DeleteAsync(int AppointmentId, string modifiedByName);
        //Task<IDataResult<AppointmentDto>> UndoDeleteAsync(int AppointmentId, string modifiedByName);
        //Task<IResult> HardDeleteAsync(int AppointmentId);
        //Task<IDataResult<int>> CountAsync();
        //Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}