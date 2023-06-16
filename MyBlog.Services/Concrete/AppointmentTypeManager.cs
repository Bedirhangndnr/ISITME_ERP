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
using MyBlog.Entities.Dtos.AppointmentTypeDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using MyBlog.Data.Concrete.EntityFramework.Context;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;

namespace MyBlog.Services.Concrete
{
    public class AppointmentTypeManager:ManagerBase,IAppointmentTypeService
    {
        private readonly MyBlogContext _dbContext;

        public AppointmentTypeManager(MyBlogContext dbContext, IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<IDataResult<AppointmentTypeDto>> GetAsync(int AppointmentTypeId)
        {
            var AppointmentType = await UnitOfWork.AppointmentTypes.GetAsync(c => c.Id == AppointmentTypeId);
            if (AppointmentType != null)
            {
                return new DataResult<AppointmentTypeDto>(ResultStatus.Success, new AppointmentTypeDto
                {
                    AppointmentType = AppointmentType,
                });
            }
            return new DataResult<AppointmentTypeDto>(ResultStatus.Error, new AppointmentTypeDto
            {
                AppointmentType = null,
            }, Messages.General.NotFound(isPlural: false, "Randevu Tipi"));
        }
        public async Task<IDataResult<AppointmentTypeListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var customers = await UnitOfWork.AppointmentTypes.GetAllAsync(x => !x.IsDeleted);
            if (customers.Count > -1)
            {
                return new DataResult<AppointmentTypeListDto>(ResultStatus.Success, new AppointmentTypeListDto
                {
                    AppointmentTypes = customers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<AppointmentTypeListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Randevu Tipi"));

        }
        public async Task<IDataResult<AppointmentTypeUpdateDto>> GetAppointmentTypeUpdateDtoAsync(int AppointmentTypeId)
        {
            var result = await UnitOfWork.AppointmentTypes.AnyAsync(c => c.Id == AppointmentTypeId);
            if (result)
            {
                var AppointmentType = await UnitOfWork.AppointmentTypes.GetAsync(c => c.Id == AppointmentTypeId);
                var AppointmentTypeUpdateDto = Mapper.Map<AppointmentTypeUpdateDto>(AppointmentType);
                return new DataResult<AppointmentTypeUpdateDto>(ResultStatus.Success, AppointmentTypeUpdateDto);
            }
            else
            {
                return new DataResult<AppointmentTypeUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Randevu Tipi"));
            }
        }

        public async Task<IDataResult<AppointmentTypeListDto>> GetAllAsync()
        {
            var AppointmentTypes = await UnitOfWork.AppointmentTypes.GetAllAsync(null);
            if (AppointmentTypes.Count > -1)
            {
                return new DataResult<AppointmentTypeListDto>(ResultStatus.Success, new AppointmentTypeListDto
                {
                    AppointmentTypes = AppointmentTypes,
                });
            }
            return new DataResult<AppointmentTypeListDto>(ResultStatus.Error, new AppointmentTypeListDto
            {
                AppointmentTypes = null,
            }, Messages.General.NotFound(isPlural: true, "Randevu Tipi"));
        }
        public async Task<IDataResult<AppointmentTypeDto>> AddAsync(AppointmentTypeAddDto AppointmentTypeAddDto, string createdByName)
        {
            var appointmentType = Mapper.Map<AppointmentType>(AppointmentTypeAddDto);

            appointmentType.CreatedByName = createdByName;
            appointmentType.ModifiedByName = createdByName;

            var addedAppointmentType = await UnitOfWork.AppointmentTypes.AddAsync(appointmentType);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(appointmentType);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<AppointmentTypeDto>(ResultStatus.Success, new AppointmentTypeDto
            {
                AppointmentType = addedAppointmentType,
                Message=Messages.General.GiveMessage(addedAppointmentType.CreatedByName, "Randevu Tipi", MessagesConstants.AddSuccess)
            }, Messages.General.GiveMessage(addedAppointmentType.CreatedByName, "Randevu Tipi", MessagesConstants.AddSuccess));
        }

        public async Task<IDataResult<AppointmentTypeDto>> UpdateAsync(AppointmentTypeUpdateDto AppointmentTypeUpdateDto, string modifiedByName)
        {
            var oldAppointmentType = await UnitOfWork.AppointmentTypes.GetAsync(c => c.Id == AppointmentTypeUpdateDto.Id);
            var appointmentType = Mapper.Map<AppointmentTypeUpdateDto, AppointmentType>(AppointmentTypeUpdateDto, oldAppointmentType);
            appointmentType.ModifiedByName = modifiedByName;
            var updatedAppointmentType = await UnitOfWork.AppointmentTypes.UpdateAsync(appointmentType);
            appointmentType = await UnitOfWork.AppointmentTypes.GetAsync(a => a.Id == AppointmentTypeUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<AppointmentTypeDto>(ResultStatus.Success, new AppointmentTypeDto
            {
                Message= Messages.General.GiveMessage(appointmentType.Title, "Randevu Tipi", MessagesConstants.UpdateSuccess),
                AppointmentType = updatedAppointmentType,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(appointmentType.Title, "Randevu Tipi", MessagesConstants.UpdateSuccess));
        }
        public async Task<IDataResult<AppointmentTypeDto>> DeleteAsync(int AppointmentTypeId, string modifiedByName)
        {
            var appointmentType = await UnitOfWork.AppointmentTypes.GetAsync(c => c.Id == AppointmentTypeId);
            if (appointmentType != null)
            {
                appointmentType.IsDeleted = true;
                appointmentType.IsActive = false;
                appointmentType.ModifiedByName = modifiedByName;
                appointmentType.ModifiedDate = DateTime.Now;
                var deletedAppointmentType = await UnitOfWork.AppointmentTypes.UpdateAsync(appointmentType);
                await UnitOfWork.SaveAsync();
                return new DataResult<AppointmentTypeDto>(ResultStatus.Success, new AppointmentTypeDto
                {
                    AppointmentType = deletedAppointmentType,
                    Message= Messages.General.GiveMessage(appointmentType.Title, "Randevu Tipi", MessagesConstants.UpdateSuccess)
                }, Messages.General.GiveMessage(appointmentType.Title, "Randevu Tipi", MessagesConstants.UpdateSuccess));
            }
            return new DataResult<AppointmentTypeDto>(ResultStatus.Error, new AppointmentTypeDto
            {
                AppointmentType = null,
            }, Messages.General.GiveMessage(appointmentType.Title, "Randevu Tipi", MessagesConstants.UpdateError));
        }

        public async Task<IDataResult<AppointmentTypeListDto>> GetAllByDeletedAsync()
        {
            var appointmentTypes = await UnitOfWork.AppointmentTypes.GetAllAsync(c => c.IsDeleted);
            if (appointmentTypes.Count > -1)
            {
                return new DataResult<AppointmentTypeListDto>(ResultStatus.Success, new AppointmentTypeListDto
                {
                    AppointmentTypes = appointmentTypes,
                });
            }
            return new DataResult<AppointmentTypeListDto>(ResultStatus.Error, new AppointmentTypeListDto
            {
                AppointmentTypes = null,
            }, Messages.General.TableNotFound("Çalışan Tipi"));
        }
        public async Task<IResult> HardDeleteAsync(int AppointmentTypeId)
        {
            var appointmentType = await UnitOfWork.AppointmentTypes.GetAsync(c => c.Id == AppointmentTypeId);
            if (appointmentType != null)
            {
                await UnitOfWork.AppointmentTypes.DeleteAsync(appointmentType);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(appointmentType.Title, "Randevu Tipi", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.GiveMessage(appointmentType.Title, "Randevu Tipi", MessagesConstants.HardDeletedSuccess));
        }

   
        public async Task<IDataResult<AppointmentTypeDto>> UndoDeleteAsync(int AppointmentTypeId, string modifiedByName)
        {
            var appointmentType = await UnitOfWork.AppointmentTypes.GetAsync(c => c.Id == AppointmentTypeId);
            if (appointmentType != null)
            {
                appointmentType.IsDeleted = false;
                appointmentType.IsActive = true;
                appointmentType.ModifiedByName = modifiedByName;
                appointmentType.ModifiedDate = DateTime.Now;
                 var deletedAppointmentType = await UnitOfWork.AppointmentTypes.UpdateAsync(appointmentType);
                await UnitOfWork.SaveAsync();
                return new DataResult<AppointmentTypeDto>(ResultStatus.Success, new AppointmentTypeDto
                {
                    Message = Messages.General.GiveMessage(appointmentType.Title, "Randevu Tipi", MessagesConstants.UndoDeletedSuccess),
                    AppointmentType = deletedAppointmentType,
                }, Messages.General.GiveMessage(appointmentType.Title, "Randevu Tipi", MessagesConstants.UndoDeletedSuccess));
            }
            return new DataResult<AppointmentTypeDto>(ResultStatus.Error, new AppointmentTypeDto
            {
                AppointmentType = null,
            }, Messages.General.GiveMessage(appointmentType.Title, "Randevu Tipi", MessagesConstants.UndoDeletedError));
        }
        public async Task<IDataResult<int>> CountAsync()
        {
            var AppointmentTypesCount = await UnitOfWork.AppointmentTypes.CountAsync();
            if (AppointmentTypesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, AppointmentTypesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var AppointmentTypesCount = await UnitOfWork.AppointmentTypes.CountAsync(c => !c.IsDeleted);
            if (AppointmentTypesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, AppointmentTypesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }
    }
}
