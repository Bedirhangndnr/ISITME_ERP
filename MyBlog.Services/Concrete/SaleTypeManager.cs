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
            }, Messages.General.NotFound(isPlural: false, "Hasta"));
        }
        public async Task<IDataResult<SaleTypeListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var customers = await UnitOfWork.SaleTypes.GetAllAsync(x => !x.IsDeleted);
            if (customers.Count > -1)
            {
                return new DataResult<SaleTypeListDto>(ResultStatus.Success, new SaleTypeListDto
                {
                    SaleTypes = customers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SaleTypeListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

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
                return new DataResult<SaleTypeUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Hasta Tipi"));
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
            }, Messages.General.NotFound(isPlural: true, "Hasta"));
        }
        public async Task<IDataResult<SaleTypeDto>> AddAsync(SaleTypeAddDto SaleTypeAddDto, string createdByName)
        {
            var saleType = Mapper.Map<SaleType>(SaleTypeAddDto);

            saleType.CreatedByName = createdByName;
            var addedSaleType = await UnitOfWork.SaleTypes.AddAsync(saleType);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(saleType);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<SaleTypeDto>(ResultStatus.Success, new SaleTypeDto
            {
                SaleType = addedSaleType,
            }, Messages.General.GiveMessage(addedSaleType.CreatedByName, "Hasta Tipi", "Eklendi"));
        }

        public async Task<IDataResult<SaleTypeDto>> UpdateAsync(SaleTypeUpdateDto SaleTypeUpdateDto, string modifiedByName)
        {
            var oldSaleType = await UnitOfWork.SaleTypes.GetAsync(c => c.Id == SaleTypeUpdateDto.Id);
            var saleType = Mapper.Map<SaleTypeUpdateDto, SaleType>(SaleTypeUpdateDto, oldSaleType);
            saleType.ModifiedByName = modifiedByName;
            var updatedSaleType = await UnitOfWork.SaleTypes.UpdateAsync(saleType);
            saleType = await UnitOfWork.SaleTypes.GetAsync(a => a.Id == SaleTypeUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<SaleTypeDto>(ResultStatus.Success, new SaleTypeDto
            {
                Message= Messages.General.GiveMessage(saleType.Title, "Hasta Tipi", "Güncellendi."),
                SaleType = updatedSaleType,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(saleType.Title, "Hasta Tipi", "Güncellendi."));
        }
        public async Task<IDataResult<SaleTypeDto>> DeleteAsync(int SaleTypeId, string modifiedByName)
        {
            var saleType = await UnitOfWork.SaleTypes.GetAsync(c => c.Id == SaleTypeId);
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
                    SaleType = deletedEmployeeType
                    
                }, Messages.General.GiveMessage(saleType.Title, "Hasta Tipi", "Güncellendi."));
            }
            return new DataResult<SaleTypeDto>(ResultStatus.Error, new SaleTypeDto
            {
                SaleType = null,
            }, Messages.General.GiveMessage(saleType.Title, "Hasta Tipi", "Güncellenemedi."));
        }
        //public async Task<IDataResult<SaleTypeListDto>> GetAllByDeletedAsync()
        //{
        //    var SaleTypes = await UnitOfWork.SaleTypes.GetAllAsync(c=>c.IsDeleted, c => c.SaleType);
        //    if (SaleTypes.Count > -1)
        //    {
        //        return new DataResult<SaleTypeListDto>(ResultStatus.Success, new SaleTypeListDto
        //        {
        //            SaleTypes = SaleTypes,
        //        });
        //    }
        //    return new DataResult<SaleTypeListDto>(ResultStatus.Error, new SaleTypeListDto
        //    {
        //        SaleTypes = null,
        //    }, Messages.SaleType.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<SaleTypeListDto>> GetAllByNonDeletedAsync()
        //{
        //    var SaleTypes = await UnitOfWork.SaleTypes.GetAllAsync(c => !c.IsDeleted, c => c.SaleType);
        //    if (SaleTypes.Count > -1)
        //    {
        //        return new DataResult<SaleTypeListDto>(ResultStatus.Success, new SaleTypeListDto
        //        {
        //            SaleTypes = SaleTypes,
        //        });
        //    }
        //    return new DataResult<SaleTypeListDto>(ResultStatus.Error, new SaleTypeListDto
        //    {
        //        SaleTypes = null,
        //    }, Messages.SaleType.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<SaleTypeListDto>> GetAllByNonDeletedAndActiveAsync()
        //{
        //    var SaleTypes = await UnitOfWork.SaleTypes.GetAllAsync(c => !c.IsDeleted && c.IsActive);
        //    if (SaleTypes.Count > -1)
        //    {
        //        return new DataResult<SaleTypeListDto>(ResultStatus.Success, new SaleTypeListDto
        //        {
        //            SaleTypes = SaleTypes,
        //        });
        //    }
        //    return new DataResult<SaleTypeListDto>(ResultStatus.Error, new SaleTypeListDto
        //    {
        //        SaleTypes = null,
        //    }, Messages.General.NotFound(isPlural: true, "Hasta"));
        //}



        //public async Task<IDataResult<SaleTypeDto>> DeleteAsync(int SaleTypeId, string modifiedByName)
        //{
        //    var SaleType = await UnitOfWork.SaleTypes.GetAsync(c => c.Id == SaleTypeId);
        //    if (SaleType != null)
        //    {
        //        SaleType.IsDeleted = true;
        //        SaleType.IsActive = false;
        //        SaleType.ModifiedByName = modifiedByName;
        //        SaleType.ModifiedDate = DateTime.Now;
        //        var deletedSaleType = await UnitOfWork.SaleTypes.UpdateAsync(SaleType);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<SaleTypeDto>(ResultStatus.Success, new SaleTypeDto
        //        {
        //            SaleType = deletedSaleType,
        //        }, Messages.SaleType.Delete(deletedSaleType.CreatedByName));
        //    }
        //    return new DataResult<SaleTypeDto>(ResultStatus.Error, new SaleTypeDto
        //    {
        //        SaleType = null,
        //    }, Messages.SaleType.NotFound(isPlural: false));
        //}

        //public async Task<IResult> HardDeleteAsync(int SaleTypeId)
        //{
        //    var SaleType = await UnitOfWork.SaleTypes.GetAsync(c => c.Id == SaleTypeId);
        //    if (SaleType != null)
        //    {
        //        await UnitOfWork.SaleTypes.DeleteAsync(SaleType);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.SaleType.HardDelete(SaleType.CreatedByName));
        //    }
        //    return new Result(ResultStatus.Error, Messages.SaleType.NotFound(isPlural: false));
        //}

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var SaleTypesCount = await UnitOfWork.SaleTypes.CountAsync();
        //    if (SaleTypesCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, SaleTypesCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1,$"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var SaleTypesCount = await UnitOfWork.SaleTypes.CountAsync(c=>!c.IsDeleted);
        //    if (SaleTypesCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, SaleTypesCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<SaleTypeDto>> ApproveAsync(int SaleTypeId, string modifiedByName)
        //{
        //    var SaleType = await UnitOfWork.SaleTypes.GetAsync(c => c.Id == SaleTypeId, c => c.SaleType);
        //    if (SaleType != null)
        //    {
        //        SaleType.IsActive = true;
        //        SaleType.ModifiedByName = modifiedByName;CustomerType
        //        SaleType.ModifiedDate = DateTime.Now;
        //        var updatedSaleType = await UnitOfWork.SaleTypes.UpdateAsync(SaleType);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<SaleTypeDto>(ResultStatus.Success, new SaleTypeDto
        //        {
        //            SaleType = updatedSaleType
        //        }, Messages.SaleType.Approve(SaleTypeId));
        //    }

        //    return new DataResult<SaleTypeDto>(ResultStatus.Error, null, Messages.SaleType.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<SaleTypeDto>> UndoDeleteAsync(int SaleTypeId, string modifiedByName)
        //{
        //    var SaleType = await UnitOfWork.SaleTypes.GetAsync(c => c.Id == SaleTypeId);
        //    if (SaleType != null)
        //    {
        //        SaleType.IsDeleted = false;
        //        SaleType.IsActive = true;
        //        SaleType.ModifiedByName = modifiedByName;
        //        SaleType.ModifiedDate = DateTime.Now;
        //        var deletedSaleType = await UnitOfWork.SaleTypes.UpdateAsync(SaleType);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<SaleTypeDto>(ResultStatus.Success, new SaleTypeDto
        //        {
        //            SaleType = deletedSaleType,
        //        }, Messages.SaleType.UndoDelete(deletedSaleType.CreatedByName));
        //    }
        //    return new DataResult<SaleTypeDto>(ResultStatus.Error, new SaleTypeDto
        //    {
        //        SaleType = null,
        //    }, Messages.SaleType.NotFound(isPlural: false));
        //}
    }
}
