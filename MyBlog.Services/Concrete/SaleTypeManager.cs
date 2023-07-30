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
using MyBlog.Entities.Dtos.SaleTypeDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using MyBlog.Data.Concrete.EntityFramework.Context;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;
using MyBlog.Entities.Dtos.SaleTypeDtos;

namespace MyBlog.Services.Concrete
{
    public class SaleTypeManager:ManagerBase,ISaleTypeService
    {
        private readonly MyBlogContext _dbContext;

        public SaleTypeManager(MyBlogContext dbContext, IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<IDataResult<SaleTypeDto>> GetAsync(int SaleTypeId)
        {
            var SaleType = await UnitOfWork.SaleTypes.GetAsync(c => c.Id == SaleTypeId);
            if (SaleType != null)
            {
                return new DataResult<SaleTypeDto>(ResultStatus.Success, new SaleTypeDto
                {
                    SaleType = SaleType,
                });
            }
            return new DataResult<SaleTypeDto>(ResultStatus.Error, new SaleTypeDto
            {
                SaleType = null,
            }, Messages.General.NotFound(isPlural: false, "Satış Durumu"));
        }
        public async Task<IDataResult<SaleTypeListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var saleTypes = await UnitOfWork.SaleTypes.GetAllAsync(x => !x.IsDeleted);
            if (saleTypes.Count > -1)
            {
                return new DataResult<SaleTypeListDto>(ResultStatus.Success, new SaleTypeListDto
                {
                    SaleTypes = saleTypes,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SaleTypeListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Satış Durumu"));

        }
        public async Task<IDataResult<SaleTypeUpdateDto>> GetSaleTypeUpdateDtoAsync(int SaleTypeId)
        {
            var result = await UnitOfWork.SaleTypes.AnyAsync(c => c.Id == SaleTypeId);
            if (result)
            {
                var SaleType = await UnitOfWork.SaleTypes.GetAsync(c => c.Id == SaleTypeId);
                var SaleTypeUpdateDto = Mapper.Map<SaleTypeUpdateDto>(SaleType);
                return new DataResult<SaleTypeUpdateDto>(ResultStatus.Success, SaleTypeUpdateDto);
            }
            else
            {
                return new DataResult<SaleTypeUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Satış Durumu Tipi"));
            }
        }

        public async Task<IDataResult<SaleTypeListDto>> GetAllAsync()
        {
            var SaleTypes = await UnitOfWork.SaleTypes.GetAllAsync(null);
            if (SaleTypes.Count > -1)
            {
                return new DataResult<SaleTypeListDto>(ResultStatus.Success, new SaleTypeListDto
                {
                    SaleTypes = SaleTypes,
                });
            }
            return new DataResult<SaleTypeListDto>(ResultStatus.Error, new SaleTypeListDto
            {
                SaleTypes = null,
            }, Messages.General.NotFound(isPlural: true, "Satış Durumu"));
        }
        public async Task<IDataResult<SaleTypeDto>> AddAsync(SaleTypeAddDto saleTypeAddDto, string createdByName)
        {
            var saleType = Mapper.Map<SaleType>(saleTypeAddDto);

            saleType.ModifiedByName = createdByName;
            saleType.CreatedByName = createdByName;
            var addedSaleType = await UnitOfWork.SaleTypes.AddAsync(saleType);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(saleType);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<SaleTypeDto>(ResultStatus.Success, new SaleTypeDto
            {
                Message= Messages.General.GiveMessage(addedSaleType.CreatedByName, "Satış Durumu Tipi", MessagesConstants.AddSuccess),
                SaleType = addedSaleType,
            }, Messages.General.GiveMessage(addedSaleType.CreatedByName, "Satış Durumu Tipi", MessagesConstants.AddSuccess));
        }

        public async Task<IDataResult<SaleTypeDto>> UpdateAsync(SaleTypeUpdateDto saleTypeUpdateDto, string modifiedByName)
        {
            var oldSaleType = await UnitOfWork.SaleTypes.GetAsync(c => c.Id == saleTypeUpdateDto.Id);
            var saleType = Mapper.Map<SaleTypeUpdateDto, SaleType>(saleTypeUpdateDto, oldSaleType);
            saleType.ModifiedByName = modifiedByName;
            var updatedSaleType = await UnitOfWork.SaleTypes.UpdateAsync(saleType);
            saleType = await UnitOfWork.SaleTypes.GetAsync(a => a.Id == saleTypeUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<SaleTypeDto>(ResultStatus.Success, new SaleTypeDto
            {
                Message= Messages.General.GiveMessage(saleType.Title, "Satış Durumu Tipi", MessagesConstants.UpdateSuccess),
                SaleType = updatedSaleType,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(saleType.Title, "Satış Durumu Tipi", MessagesConstants.UpdateSuccess));
        }
        public async Task<IDataResult<SaleTypeDto>> DeleteAsync(int saleTypeId, string modifiedByName)
        {
            var saleType = await UnitOfWork.SaleTypes.GetAsync(c => c.Id == saleTypeId);
            if (saleType != null)
            {
                saleType.IsDeleted = true;
                saleType.IsActive = false;
                saleType.ModifiedByName = modifiedByName;
                saleType.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.SaleTypes.UpdateAsync(saleType);
                await UnitOfWork.SaveAsync();
                return new DataResult<SaleTypeDto>(ResultStatus.Success, new SaleTypeDto
                {
                    Message= Messages.General.GiveMessage(saleType.Title, "Satış Durumu Tipi", MessagesConstants.UpdateSuccess),
                    SaleType = deletedEmployeeType
                    
                }, Messages.General.GiveMessage(saleType.Title, "Satış Durumu Tipi", MessagesConstants.UpdateSuccess));
            }
            return new DataResult<SaleTypeDto>(ResultStatus.Error, new SaleTypeDto
            {
                SaleType = null,
            }, Messages.General.GiveMessage(saleType.Title, "Satış Durumu Tipi", MessagesConstants.UpdateError));
        }
        public async Task<IDataResult<SaleTypeListDto>> GetAllByDeletedAsync()
        {
            var saleTypes = await UnitOfWork.SaleTypes.GetAllAsync(c => c.IsDeleted);
            if (saleTypes.Count > -1)
            {
                return new DataResult<SaleTypeListDto>(ResultStatus.Success, new SaleTypeListDto
                {
                    SaleTypes = saleTypes,
                });
            }
            return new DataResult<SaleTypeListDto>(ResultStatus.Error, new SaleTypeListDto
            {
                SaleTypes = null,
            }, Messages.General.TableNotFound("Ürün Alt Grupları"));
        }
        public async Task<IResult> HardDeleteAsync(int saleTypeId)
        {
            var saleType = await UnitOfWork.SaleTypes.GetAsync(c => c.Id == saleTypeId);
            if (saleType != null)
            {
                await UnitOfWork.SaleTypes.DeleteAsync(saleType);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(saleType.Title, "Satış Durumu", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.GiveMessage(saleType.Title, "Satış Durumu", MessagesConstants.HardDeletedSuccess));
        }


        public async Task<IDataResult<SaleTypeDto>> UndoDeleteAsync(int saleTypeId, string modifiedByName)
        {
            var saleType = await UnitOfWork.SaleTypes.GetAsync(c => c.Id == saleTypeId);
            if (saleType != null)
            {
                saleType.IsDeleted = false;
                saleType.IsActive = true;
                saleType.ModifiedByName = modifiedByName;
                saleType.ModifiedDate = DateTime.Now;
                var deletedSaleType = await UnitOfWork.SaleTypes.UpdateAsync(saleType);
                await UnitOfWork.SaveAsync();
                return new DataResult<SaleTypeDto>(ResultStatus.Success, new SaleTypeDto
                {
                    Message = Messages.General.GiveMessage(saleType.Title, "Satış Durumu", MessagesConstants.UndoDeletedSuccess),
                    SaleType = deletedSaleType,
                }, Messages.General.GiveMessage(saleType.Title, "Satış Durumu", MessagesConstants.UndoDeletedSuccess));
            }
            return new DataResult<SaleTypeDto>(ResultStatus.Error, new SaleTypeDto
            {
                SaleType = null,
            }, Messages.General.GiveMessage(saleType.Title, "Satış Durumu", MessagesConstants.UndoDeletedError));
        }
        public async Task<IDataResult<int>> CountAsync()
        {
            var saleTypesCount = await UnitOfWork.SaleTypes.CountAsync();
            if (saleTypesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, saleTypesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var saleTypesCount = await UnitOfWork.SaleTypes.CountAsync(c => !c.IsDeleted);
            if (saleTypesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, saleTypesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }
    }
}
