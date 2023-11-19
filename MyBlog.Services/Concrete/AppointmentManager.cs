using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AppointmentDtos;
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
            }, Messages.General.NotFound(isPlural: false, "Randevu"));
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
                return new DataResult<AppointmentUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Randevu"));
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
            return new DataResult<AppointmentListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Randevu"));

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
            return new DataResult<AppointmentListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Randevu"));
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
            }, Messages.General.GiveMessage(appointment.Date.ToShortDateString().ToString(), "Tarihli Randevu", "eklendi."));
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
            }, Messages.General.GiveMessage(appointment.Date.ToShortDateString().ToString(), "Tarihli Randevu", "Güncellendi."));
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
            return new DataResult<AppointmentListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Randevu"));
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
            return new DataResult<AppointmentListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Randevu"));
        }
        public async Task<IDataResult<AppointmentDto>> DeleteAsync(int AppointmentId, string modifiedByName)
        {
            var appointment = await UnitOfWork.Appointments.GetAsync(c => c.Id == AppointmentId);
            if (appointment != null)
            {
                appointment.IsDeleted = true;
                //appointment.IsActive = false;
                appointment.ModifiedByName = modifiedByName;
                appointment.ModifiedDate = DateTime.Now;
                var deletedAppointment = await UnitOfWork.Appointments.UpdateAsync(appointment);
                await UnitOfWork.SaveAsync();
                return new DataResult<AppointmentDto>(ResultStatus.Success, new AppointmentDto
                {
                    Appointment = deletedAppointment,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.General.GiveMessage(appointment.Date.ToShortDateString().ToString(), "Tarihli Randevu", MessagesConstants.DeletedSuccess)

                }, Messages.General.GiveMessage(appointment.Date.ToShortDateString().ToString(), "Tarihli Randevu", MessagesConstants.DeletedSuccess));
            }
            return new DataResult<AppointmentDto>(ResultStatus.Error, new AppointmentDto
            {
                Appointment = null,
            }, Messages.General.GiveMessage(appointment.Date.ToShortDateString().ToString(), "Tarihli Randevu", MessagesConstants.DeletedError));
        }

        public async Task<IResult> HardDeleteAsync(int AppointmentId)
        {
            var appointment = await UnitOfWork.Appointments.GetAsync(c => c.Id == AppointmentId);
            if (appointment != null)
            {
                await UnitOfWork.Appointments.DeleteAsync(appointment);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(appointment.Date.ToShortDateString().ToString(), "Tarihli Randevu", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.NotFound(isPlural: false, "Randevu"));
        }
        public async Task<IDataResult<int>> CountAsync(bool isRestOfDay)
        {
            try
            {
                int appointmentsCount;

                if (isRestOfDay)
                {
                    appointmentsCount = await UnitOfWork.Appointments.CountAsync(a => a.Date >= DateTime.Today);
                }
                else
                {
                    appointmentsCount = await UnitOfWork.Appointments.CountAsync();
                }

                return new DataResult<int>(ResultStatus.Success, appointmentsCount);
            }
            catch (Exception ex)
            {
                // Hata durumunda gerekli işlemler yapılabilir
                return new DataResult<int>(ResultStatus.Error, -1, "Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }


        public async Task<IDataResult<int>> CountByNonDeletedAsync(bool isRestOfDay)
        {
            try
            {
                int appointmentsCount;

                if (isRestOfDay)
                {
                    appointmentsCount = await UnitOfWork.Appointments.CountAsync(a => a.Date >= DateTime.Today && !a.IsDeleted);
                }
                else
                {
                    appointmentsCount = await UnitOfWork.Appointments.CountAsync(a => !a.IsDeleted);
                }

                return new DataResult<int>(ResultStatus.Success, appointmentsCount);
            }
            catch (Exception ex)
            {
                // Hata durumunda gerekli işlemler yapılabilir
                return new DataResult<int>(ResultStatus.Error, -1, "Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<AppointmentDto>> UndoDeleteAsync(int appointmentId, string modifiedByName)
        {
            var appointment = await UnitOfWork.Appointments.GetAsync(c => c.Id == appointmentId);
            if (appointment != null)
            {
                appointment.IsDeleted = false;
                //appointment.IsActive = true;
                appointment.ModifiedByName = modifiedByName;
                appointment.ModifiedDate = DateTime.Now;
                var deletedAppointment = await UnitOfWork.Appointments.UpdateAsync(appointment);
                await UnitOfWork.SaveAsync();
                return new DataResult<AppointmentDto>(ResultStatus.Success, new AppointmentDto
                {
                    Appointment = deletedAppointment,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.General.GiveMessage(appointment.Date.ToShortDateString().ToString(), "Tarihli Randevu", MessagesConstants.UpdateSuccess)
                }, Messages.General.GiveMessage(appointment.Date.ToShortDateString().ToString(), "Tarihli Randevu", MessagesConstants.UpdateError));
            }
            return new DataResult<AppointmentDto>(ResultStatus.Error, new AppointmentDto
            {
                Appointment = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.General.NotFound(isPlural: false, "Randevu")
            }, Messages.General.NotFound(isPlural: false, "Randevu"));
        }
    }
}
