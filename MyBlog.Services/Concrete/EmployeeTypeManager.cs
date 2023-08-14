using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CustomerDtos;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;

namespace MyBlog.Services.Concrete
{
    public class EmployeeTypeManager:ManagerBase,IEmployeeTypeService
    {
        public EmployeeTypeManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<EmployeeTypeDto>> GetAsync(int EmployeeTypeId)
        {
            var EmployeeType = await UnitOfWork.EmployeeTypes.GetAsync(c => c.Id == EmployeeTypeId);
            if (EmployeeType != null)
            {
                return new DataResult<EmployeeTypeDto>(ResultStatus.Success, new EmployeeTypeDto
                {
                    EmployeeType = EmployeeType,
                });
            }
            return new DataResult<EmployeeTypeDto>(ResultStatus.Error, new EmployeeTypeDto
            {
                EmployeeType = null,
            }, Messages.General.NotFound(isPlural: false, "Personel"));
        }
        public async Task<IDataResult<EmployeeTypeListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var employeeTypes = await UnitOfWork.EmployeeTypes.GetAllAsync(x => !x.IsDeleted);
            if (employeeTypes.Count > -1)
            {
                return new DataResult<EmployeeTypeListDto>(ResultStatus.Success, new EmployeeTypeListDto
                {
                    EmployeeTypes = employeeTypes,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EmployeeTypeListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Personel"));

        }
        public async Task<IDataResult<EmployeeTypeUpdateDto>> GetEmployeeTypeUpdateDtoAsync(int EmployeeTypeId)
        {
            var result = await UnitOfWork.EmployeeTypes.AnyAsync(c => c.Id == EmployeeTypeId);
            if (result)
            {
                var EmployeeType = await UnitOfWork.EmployeeTypes.GetAsync(c => c.Id == EmployeeTypeId);
                var EmployeeTypeUpdateDto = Mapper.Map<EmployeeTypeUpdateDto>(EmployeeType);
                return new DataResult<EmployeeTypeUpdateDto>(ResultStatus.Success, EmployeeTypeUpdateDto);
            }
            else
            {
                return new DataResult<EmployeeTypeUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Personel Tipi"));
            }
        }

        public async Task<IDataResult<EmployeeTypeListDto>> GetAllAsync()
        {
            var EmployeeTypes = await UnitOfWork.EmployeeTypes.GetAllAsync(null);
            if (EmployeeTypes.Count > -1)
            {
                return new DataResult<EmployeeTypeListDto>(ResultStatus.Success, new EmployeeTypeListDto
                {
                    EmployeeTypes = EmployeeTypes,
                });
            }
            return new DataResult<EmployeeTypeListDto>(ResultStatus.Error, new EmployeeTypeListDto
            {
                EmployeeTypes = null,
            }, Messages.General.NotFound(isPlural: true, "Personel"));
        }
        public async Task<IDataResult<EmployeeTypeDto>> AddAsync(EmployeeTypeAddDto EmployeeTypeAddDto, string createdByName)
        {
            var EmployeeType = Mapper.Map<EmployeeType>(EmployeeTypeAddDto);
            EmployeeType.CreatedByName = createdByName;
            EmployeeType.ModifiedByName = createdByName;
            var addedEmployeeType = await UnitOfWork.EmployeeTypes.AddAsync(EmployeeType);
            await UnitOfWork.SaveAsync();
            return new DataResult<EmployeeTypeDto>(ResultStatus.Success, new EmployeeTypeDto
            {
                EmployeeType = addedEmployeeType,
                Message= Messages.General.GiveMessage(addedEmployeeType.CreatedByName, "Personel Tipi", "Eklendi")
            }, Messages.General.GiveMessage(addedEmployeeType.CreatedByName, "Personel Tipi", "Eklendi"));
        }

        public async Task<IDataResult<EmployeeTypeDto>> UpdateAsync(EmployeeTypeUpdateDto EmployeeTypeUpdateDto, string modifiedByName)
        {
            var oldEmployeeType = await UnitOfWork.EmployeeTypes.GetAsync(c => c.Id == EmployeeTypeUpdateDto.Id);
            var employeeType = Mapper.Map<EmployeeTypeUpdateDto, EmployeeType>(EmployeeTypeUpdateDto, oldEmployeeType);
            employeeType.ModifiedByName = modifiedByName;
            var updatedEmployeeType = await UnitOfWork.EmployeeTypes.UpdateAsync(employeeType);
            employeeType = await UnitOfWork.EmployeeTypes.GetAsync(a => a.Id == EmployeeTypeUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<EmployeeTypeDto>(ResultStatus.Success, new EmployeeTypeDto
            {
                Message= Messages.General.GiveMessage(employeeType.Title, "Personel Tipi", "Güncellendi."),
                EmployeeType = updatedEmployeeType,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(employeeType.Title, "Personel Tipi", "Güncellendi."));
        }
        public async Task<IDataResult<EmployeeTypeDto>> DeleteAsync(int EmployeeTypeId, string modifiedByName)
        {
            var employeeType = await UnitOfWork.EmployeeTypes.GetAsync(c => c.Id == EmployeeTypeId);
            if (employeeType != null)
            {
                employeeType.IsDeleted = true;
                employeeType.IsActive = false;
                employeeType.ModifiedByName = modifiedByName;
                employeeType.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.EmployeeTypes.UpdateAsync(employeeType);
                await UnitOfWork.SaveAsync();
                return new DataResult<EmployeeTypeDto>(ResultStatus.Success, new EmployeeTypeDto
                {
                    Message = Messages.General.GiveMessage(employeeType.Title, "Personel Tipi", "Güncellendi."),
                    EmployeeType = deletedEmployeeType,
                    ResultStatus = ResultStatus.Success,
                }, Messages.General.GiveMessage(employeeType.Title, "Personel Tipi", "Güncellendi."));
            }
            return new DataResult<EmployeeTypeDto>(ResultStatus.Error, new EmployeeTypeDto
            {
                EmployeeType = null,
            }, Messages.General.GiveMessage(employeeType.Title, "Personel Tipi", "Güncellendi."));
        }
        public async Task<IDataResult<EmployeeTypeListDto>> GetAllByDeletedAsync()
        {
            var employeeTypes = await UnitOfWork.EmployeeTypes.GetAllAsync(c => c.IsDeleted);
            if (employeeTypes.Count > -1)
            {
                return new DataResult<EmployeeTypeListDto>(ResultStatus.Success, new EmployeeTypeListDto
                {
                    EmployeeTypes = employeeTypes,
                });
            }
            return new DataResult<EmployeeTypeListDto>(ResultStatus.Error, new EmployeeTypeListDto
            {
                EmployeeTypes = null,
            }, Messages.General.TableNotFound("Personel Tipi"));
        }


        public async Task<IResult> HardDeleteAsync(int EmployeeTypeId)
        {
            var employeeType = await UnitOfWork.EmployeeTypes.GetAsync(c => c.Id == EmployeeTypeId);
            if (employeeType != null)
            {
                await UnitOfWork.EmployeeTypes.DeleteAsync(employeeType);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(employeeType.Title, "Personel Tipi", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.GiveMessage(employeeType.Title, "Personel Tipi", MessagesConstants.HardDeletedSuccess));
        }

        public async Task<IDataResult<int>> CountAsync()
        {
            var EmployeeTypesCount = await UnitOfWork.EmployeeTypes.CountAsync();
            if (EmployeeTypesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, EmployeeTypesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var EmployeeTypesCount = await UnitOfWork.EmployeeTypes.CountAsync(c => !c.IsDeleted);
            if (EmployeeTypesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, EmployeeTypesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }
        public async Task<IDataResult<EmployeeTypeDto>> UndoDeleteAsync(int EmployeeTypeId, string modifiedByName)
        {
            var employeeType = await UnitOfWork.EmployeeTypes.GetAsync(c => c.Id == EmployeeTypeId);
            if (employeeType != null)
            {
                employeeType.IsDeleted = false;
                employeeType.IsActive = true;
                employeeType.ModifiedByName = modifiedByName;
                employeeType.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.EmployeeTypes.UpdateAsync(employeeType);
                await UnitOfWork.SaveAsync();
                return new DataResult<EmployeeTypeDto>(ResultStatus.Success, new EmployeeTypeDto
                {
                    EmployeeType = deletedEmployeeType,
                }, Messages.General.GiveMessage(employeeType.Title, "Personel Tipi", MessagesConstants.UndoDeletedSuccess));
            }
            return new DataResult<EmployeeTypeDto>(ResultStatus.Error, new EmployeeTypeDto
            {
                EmployeeType = null,
            }, Messages.General.GiveMessage(employeeType.Title, "Personel Tipi", MessagesConstants.UndoDeletedError));
        }


    }
}
