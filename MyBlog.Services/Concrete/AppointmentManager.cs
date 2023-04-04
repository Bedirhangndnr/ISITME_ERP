using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using static MyBlog.Services.Utilities.Messages;

namespace MyBlog.Services.Concrete
{
    public class AppointmentManager : ManagerBase, IAppointmentService
    {
        public AppointmentManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<AppointmentDto>> GetAsync(int AppointmentId)
        {
            var appointment = await UnitOfWork.Appointments.GetAsync(c => c.Id == AppointmentId);
            if (appointment != null)
            {
                return new DataResult<AppointmentDto>(ResultStatus.Success, new AppointmentDto
                {
                    Appointment = appointment,
                });
            }
            return new DataResult<AppointmentDto>(ResultStatus.Error, new AppointmentDto
            {
                Appointment = null,
            }, Messages.General.NotFound(isPlural: false, "Çalışan"));
        }
        public async Task<IDataResult<AppointmentUpdateDto>> GetAppointmentUpdateDtoAsync(int AppointmentId)
        {
            var result = await UnitOfWork.Appointments.AnyAsync(c => c.Id == AppointmentId);
            if (result)
            {
                var Appointment = await UnitOfWork.Appointments.GetAsync(c => c.Id == AppointmentId);
                var AppointmentUpdateDto = Mapper.Map<AppointmentUpdateDto>(Appointment);
                return new DataResult<AppointmentUpdateDto>(ResultStatus.Success, AppointmentUpdateDto);
            }
            else
            {
                return new DataResult<AppointmentUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Çalışan"));
            }
        }

        public async Task<IDataResult<AppointmentListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var appointments = await UnitOfWork.Appointments.GetAllWithNamesAsync(c => !c.IsDeleted && c.IsActive);
            if (appointments.Count > -1)
            {
                return new DataResult<AppointmentListDto>(ResultStatus.Success, new AppointmentListDto
                {
                    AppointmentListWithRelatedTables = appointments,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<AppointmentListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Çalışan"));

        }

        public async Task<IDataResult<AppointmentListDto>> GetAllAsync()
        {
            var appointments = await UnitOfWork.Appointments.GetAllWithNamesAsync();
            if (appointments.Count > -1)
            {
                return new DataResult<AppointmentListDto>(ResultStatus.Success, new AppointmentListDto
                {
                    AppointmentListWithRelatedTables = appointments,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<AppointmentListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Çalışan"));
        }
        public async Task<IResult> AddAsync(AppointmentAddDto AppointmentAddDto, string createdByName, int userId)
        {
            var appointment = Mapper.Map<Appointment>(AppointmentAddDto);
            appointment.CreatedByName = createdByName;
            appointment.ModifiedByName = createdByName;
            var addedAppointment = await UnitOfWork.Appointments.AddAsync(appointment);
            await UnitOfWork.SaveAsync();
            return new DataResult<AppointmentDto>(ResultStatus.Success, new AppointmentDto
            {
                Appointment = addedAppointment,
            }, Messages.General.GiveMessage("xxKx", "Çalışan", "eklendi."));
        }
        public async Task<IResult> UpdateAsync(AppointmentUpdateDto AppointmentUpdateDto, string modifiedByName)
        {
            var oldAppointment = await UnitOfWork.Appointments.GetAsync(c => c.Id == AppointmentUpdateDto.Id);
            var appointment = Mapper.Map<AppointmentUpdateDto, Appointment>(AppointmentUpdateDto, oldAppointment);
            appointment.ModifiedByName = modifiedByName;
            var updatedAppointment = await UnitOfWork.Appointments.UpdateAsync(appointment);
            await UnitOfWork.SaveAsync();
            return new DataResult<AppointmentDto>(ResultStatus.Success, new AppointmentDto
            {
                Appointment = updatedAppointment,
            }, Messages.General.GiveMessage("xxKx", "Çalışan", "Güncellendi."));
        }
        public async Task<IDataResult<AppointmentListDto>> GetAllByDeletedAsync()
        {
            var appointments = await UnitOfWork.Appointments.GetAllWithNamesAsync(x => x.IsDeleted);
            if (appointments.Count > -1)
            {
                return new DataResult<AppointmentListDto>(ResultStatus.Success, new AppointmentListDto
                {
                    AppointmentListWithRelatedTables = appointments,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<AppointmentListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Çalışan"));
        }

        public async Task<IDataResult<AppointmentListDto>> GetAllByNonDeletedAsync()
        {
            var appointments = await UnitOfWork.Appointments.GetAllWithNamesAsync(x => !x.IsDeleted);
            if (appointments.Count > -1)
            {
                return new DataResult<AppointmentListDto>(ResultStatus.Success, new AppointmentListDto
                {
                    AppointmentListWithRelatedTables = appointments,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<AppointmentListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Çalışan"));
        }

        //public async Task<IDataResult<AppointmentListDto>> GetAllByNonDeletedAndActiveAsync()
        //{
        //    var appointments = await UnitOfWork.Appointments.GetAllAsync(c => !c.IsDeleted && c.IsActive);
        //    if (appointments.Count > -1)
        //    {
        //        return new DataResult<AppointmentListDto>(ResultStatus.Success, new AppointmentListDto
        //        {
        //            Appointments = appointments,
        //        });
        //    }
        //    return new DataResult<AppointmentListDto>(ResultStatus.Error, new AppointmentListDto
        //    {
        //        Appointments = null,
        //    }, Messages.General.NotFound(isPlural: true, "Çalışan"));
        //}





        //public async Task<IDataResult<AppointmentDto>> DeleteAsync(int AppointmentId, string modifiedByName)
        //{
        //    var appointment = await UnitOfWork.Appointments.GetAsync(c => c.Id == AppointmentId);
        //    if (appointment != null)
        //    {
        //        Appointment.IsDeleted = true;
        //        Appointment.IsActive = false;
        //        Appointment.ModifiedByName = modifiedByName;
        //        Appointment.ModifiedDate = DateTime.Now;
        //        var deletedAppointment = await UnitOfWork.Appointments.UpdateAsync(Appointment);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<AppointmentDto>(ResultStatus.Success, new AppointmentDto
        //        {
        //            Appointment = deletedAppointment,
        //        }, Messages.Appointment.Delete(deletedAppointment.CreatedByName));
        //    }
        //    return new DataResult<AppointmentDto>(ResultStatus.Error, new AppointmentDto
        //    {
        //        Appointment = null,
        //    }, Messages.Appointment.NotFound(isPlural: false));
        //}

        //public async Task<IResult> HardDeleteAsync(int AppointmentId)
        //{
        //    var appointment = await UnitOfWork.Appointments.GetAsync(c => c.Id == AppointmentId);
        //    if (appointment != null)
        //    {
        //        await UnitOfWork.Appointments.DeleteAsync(Appointment);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.Appointment.HardDelete(Appointment.CreatedByName));
        //    }
        //    return new Result(ResultStatus.Error, Messages.Appointment.NotFound(isPlural: false));
        //}

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var appointmentsCount = await UnitOfWork.Appointments.CountAsync();
        //    if (appointmentsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, AppointmentsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1,$"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var appointmentsCount = await UnitOfWork.Appointments.CountAsync(c=>!c.IsDeleted);
        //    if (appointmentsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, AppointmentsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<AppointmentDto>> ApproveAsync(int AppointmentId, string modifiedByName)
        //{
        //    var appointment = await UnitOfWork.Appointments.GetAsync(c => c.Id == AppointmentId, c => c.Appointment);
        //    if (appointment != null)
        //    {
        //        appointment.IsActive = true;
        //        appointment.ModifiedByName = modifiedByName;
        //        appointment.ModifiedDate = DateTime.Now;
        //        var updatedAppointment = await UnitOfWork.Appointments.UpdateAsync(Appointment);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<AppointmentDto>(ResultStatus.Success, new AppointmentDto
        //        {
        //            Appointment = updatedAppointment
        //        }, Messages.Appointment.Approve(AppointmentId));
        //    }

        //    return new DataResult<AppointmentDto>(ResultStatus.Error, null, Messages.Appointment.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<AppointmentDto>> UndoDeleteAsync(int AppointmentId, string modifiedByName)
        //{
        //    var appointment = await UnitOfWork.Appointments.GetAsync(c => c.Id == AppointmentId);
        //    if (appointment != null)
        //    {
        //        appointment.IsDeleted = false;
        //        appointment.IsActive = true;
        //        appointment.ModifiedByName = modifiedByName;
        //        appointment.ModifiedDate = DateTime.Now;
        //        var deletedAppointment = await UnitOfWork.Appointments.UpdateAsync(Appointment);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<AppointmentDto>(ResultStatus.Success, new AppointmentDto
        //        {
        //            Appointment = deletedAppointment,
        //        }, Messages.Appointment.UndoDelete(deletedAppointment.CreatedByName));
        //    }
        //    return new DataResult<AppointmentDto>(ResultStatus.Error, new AppointmentDto
        //    {
        //        Appointment = null,
        //    }, Messages.Appointment.NotFound(isPlural: false));
        //}
    }
}
