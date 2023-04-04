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
using MyBlog.Entities.Dtos.SaleStatusDtos;
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
    public class SaleStatusManager:ManagerBase,ISaleStatusService
    {
        private readonly MyBlogContext _dbContext;

        public SaleStatusManager(MyBlogContext dbContext, IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<IDataResult<SaleStatusDto>> GetAsync(int SaleStatusId)
        {
            var SaleStatus = await UnitOfWork.SaleStatuses.GetAsync(c => c.Id == SaleStatusId);
            if (SaleStatus != null)
            {
                return new DataResult<SaleStatusDto>(ResultStatus.Success, new SaleStatusDto
                {
                    SaleStatus = SaleStatus,
                });
            }
            return new DataResult<SaleStatusDto>(ResultStatus.Error, new SaleStatusDto
            {
                SaleStatus = null,
            }, Messages.General.NotFound(isPlural: false, "Hasta"));
        }
        public async Task<IDataResult<SaleStatusListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var saleStatuses = await UnitOfWork.SaleStatuses.GetAllAsync(x => !x.IsDeleted);
            if (saleStatuses.Count > -1)
            {
                return new DataResult<SaleStatusListDto>(ResultStatus.Success, new SaleStatusListDto
                {
                    SaleStatuses = saleStatuses,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SaleStatusListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

        }
        public async Task<IDataResult<SaleStatusUpdateDto>> GetSaleStatusUpdateDtoAsync(int SaleStatusId)
        {
            var result = await UnitOfWork.SaleStatuses.AnyAsync(c => c.Id == SaleStatusId);
            if (result)
            {
                var SaleStatus = await UnitOfWork.SaleStatuses.GetAsync(c => c.Id == SaleStatusId);
                var SaleStatusUpdateDto = Mapper.Map<SaleStatusUpdateDto>(SaleStatus);
                return new DataResult<SaleStatusUpdateDto>(ResultStatus.Success, SaleStatusUpdateDto);
            }
            else
            {
                return new DataResult<SaleStatusUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Hasta Tipi"));
            }
        }

        public async Task<IDataResult<SaleStatusListDto>> GetAllAsync()
        {
            var SaleStatuses = await UnitOfWork.SaleStatuses.GetAllAsync(null);
            if (SaleStatuses.Count > -1)
            {
                return new DataResult<SaleStatusListDto>(ResultStatus.Success, new SaleStatusListDto
                {
                    SaleStatuses = SaleStatuses,
                });
            }
            return new DataResult<SaleStatusListDto>(ResultStatus.Error, new SaleStatusListDto
            {
                SaleStatuses = null,
            }, Messages.General.NotFound(isPlural: true, "Hasta"));
        }
        public async Task<IDataResult<SaleStatusDto>> AddAsync(SaleStatusAddDto SaleStatusAddDto, string createdByName)
        {
            var saleStatus = Mapper.Map<SaleStatus>(SaleStatusAddDto);

            saleStatus.CreatedByName = createdByName;
            var addedSaleStatus = await UnitOfWork.SaleStatuses.AddAsync(saleStatus);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(saleStatus);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<SaleStatusDto>(ResultStatus.Success, new SaleStatusDto
            {
                SaleStatus = addedSaleStatus,
            }, Messages.General.GiveMessage(addedSaleStatus.CreatedByName, "Hasta Tipi", "Eklendi"));
        }

        public async Task<IDataResult<SaleStatusDto>> UpdateAsync(SaleStatusUpdateDto SaleStatusUpdateDto, string modifiedByName)
        {
            var oldSaleStatus = await UnitOfWork.SaleStatuses.GetAsync(c => c.Id == SaleStatusUpdateDto.Id);
            var saleStatus = Mapper.Map<SaleStatusUpdateDto, SaleStatus>(SaleStatusUpdateDto, oldSaleStatus);
            saleStatus.ModifiedByName = modifiedByName;
            var updatedSaleStatus = await UnitOfWork.SaleStatuses.UpdateAsync(saleStatus);
            saleStatus = await UnitOfWork.SaleStatuses.GetAsync(a => a.Id == SaleStatusUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<SaleStatusDto>(ResultStatus.Success, new SaleStatusDto
            {
                Message= Messages.General.GiveMessage(saleStatus.Title, "Hasta Tipi", "Güncellendi."),
                SaleStatus = updatedSaleStatus,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(saleStatus.Title, "Hasta Tipi", "Güncellendi."));
        }
        public async Task<IDataResult<SaleStatusDto>> DeleteAsync(int SaleStatusId, string modifiedByName)
        {
            var saleStatus = await UnitOfWork.SaleStatuses.GetAsync(c => c.Id == SaleStatusId);
            if (saleStatus != null)
            {
                saleStatus.IsDeleted = true;
                saleStatus.IsActive = false;
                saleStatus.ModifiedByName = modifiedByName;
                saleStatus.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.SaleStatuses.UpdateAsync(saleStatus);
                await UnitOfWork.SaveAsync();
                return new DataResult<SaleStatusDto>(ResultStatus.Success, new SaleStatusDto
                {
                    SaleStatus = deletedEmployeeType
                    
                }, Messages.General.GiveMessage(saleStatus.Title, "Hasta Tipi", "Güncellendi."));
            }
            return new DataResult<SaleStatusDto>(ResultStatus.Error, new SaleStatusDto
            {
                SaleStatus = null,
            }, Messages.General.GiveMessage(saleStatus.Title, "Hasta Tipi", "Güncellenemedi."));
        }
        //public async Task<IDataResult<SaleStatusListDto>> GetAllByDeletedAsync()
        //{
        //    var SaleStatuses = await UnitOfWork.SaleStatuses.GetAllAsync(c=>c.IsDeleted, c => c.SaleStatus);
        //    if (SaleStatuses.Count > -1)
        //    {
        //        return new DataResult<SaleStatusListDto>(ResultStatus.Success, new SaleStatusListDto
        //        {
        //            SaleStatuses = SaleStatuses,
        //        });
        //    }
        //    return new DataResult<SaleStatusListDto>(ResultStatus.Error, new SaleStatusListDto
        //    {
        //        SaleStatuses = null,
        //    }, Messages.SaleStatus.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<SaleStatusListDto>> GetAllByNonDeletedAsync()
        //{
        //    var SaleStatuses = await UnitOfWork.SaleStatuses.GetAllAsync(c => !c.IsDeleted, c => c.SaleStatus);
        //    if (SaleStatuses.Count > -1)
        //    {
        //        return new DataResult<SaleStatusListDto>(ResultStatus.Success, new SaleStatusListDto
        //        {
        //            SaleStatuses = SaleStatuses,
        //        });
        //    }
        //    return new DataResult<SaleStatusListDto>(ResultStatus.Error, new SaleStatusListDto
        //    {
        //        SaleStatuses = null,
        //    }, Messages.SaleStatus.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<SaleStatusListDto>> GetAllByNonDeletedAndActiveAsync()
        //{
        //    var SaleStatuses = await UnitOfWork.SaleStatuses.GetAllAsync(c => !c.IsDeleted && c.IsActive);
        //    if (SaleStatuses.Count > -1)
        //    {
        //        return new DataResult<SaleStatusListDto>(ResultStatus.Success, new SaleStatusListDto
        //        {
        //            SaleStatuses = SaleStatuses,
        //        });
        //    }
        //    return new DataResult<SaleStatusListDto>(ResultStatus.Error, new SaleStatusListDto
        //    {
        //        SaleStatuses = null,
        //    }, Messages.General.NotFound(isPlural: true, "Hasta"));
        //}



        //public async Task<IDataResult<SaleStatusDto>> DeleteAsync(int SaleStatusId, string modifiedByName)
        //{
        //    var SaleStatus = await UnitOfWork.SaleStatuses.GetAsync(c => c.Id == SaleStatusId);
        //    if (SaleStatus != null)
        //    {
        //        SaleStatus.IsDeleted = true;
        //        SaleStatus.IsActive = false;
        //        SaleStatus.ModifiedByName = modifiedByName;
        //        SaleStatus.ModifiedDate = DateTime.Now;
        //        var deletedSaleStatus = await UnitOfWork.SaleStatuses.UpdateAsync(SaleStatus);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<SaleStatusDto>(ResultStatus.Success, new SaleStatusDto
        //        {
        //            SaleStatus = deletedSaleStatus,
        //        }, Messages.SaleStatus.Delete(deletedSaleStatus.CreatedByName));
        //    }
        //    return new DataResult<SaleStatusDto>(ResultStatus.Error, new SaleStatusDto
        //    {
        //        SaleStatus = null,
        //    }, Messages.SaleStatus.NotFound(isPlural: false));
        //}

        //public async Task<IResult> HardDeleteAsync(int SaleStatusId)
        //{
        //    var SaleStatus = await UnitOfWork.SaleStatuses.GetAsync(c => c.Id == SaleStatusId);
        //    if (SaleStatus != null)
        //    {
        //        await UnitOfWork.SaleStatuses.DeleteAsync(SaleStatus);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.SaleStatus.HardDelete(SaleStatus.CreatedByName));
        //    }
        //    return new Result(ResultStatus.Error, Messages.SaleStatus.NotFound(isPlural: false));
        //}

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var SaleStatusesCount = await UnitOfWork.SaleStatuses.CountAsync();
        //    if (SaleStatusesCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, SaleStatusesCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1,$"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var SaleStatusesCount = await UnitOfWork.SaleStatuses.CountAsync(c=>!c.IsDeleted);
        //    if (SaleStatusesCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, SaleStatusesCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<SaleStatusDto>> ApproveAsync(int SaleStatusId, string modifiedByName)
        //{
        //    var SaleStatus = await UnitOfWork.SaleStatuses.GetAsync(c => c.Id == SaleStatusId, c => c.SaleStatus);
        //    if (SaleStatus != null)
        //    {
        //        SaleStatus.IsActive = true;
        //        SaleStatus.ModifiedByName = modifiedByName;CustomerType
        //        SaleStatus.ModifiedDate = DateTime.Now;
        //        var updatedSaleStatus = await UnitOfWork.SaleStatuses.UpdateAsync(SaleStatus);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<SaleStatusDto>(ResultStatus.Success, new SaleStatusDto
        //        {
        //            SaleStatus = updatedSaleStatus
        //        }, Messages.SaleStatus.Approve(SaleStatusId));
        //    }

        //    return new DataResult<SaleStatusDto>(ResultStatus.Error, null, Messages.SaleStatus.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<SaleStatusDto>> UndoDeleteAsync(int SaleStatusId, string modifiedByName)
        //{
        //    var SaleStatus = await UnitOfWork.SaleStatuses.GetAsync(c => c.Id == SaleStatusId);
        //    if (SaleStatus != null)
        //    {
        //        SaleStatus.IsDeleted = false;
        //        SaleStatus.IsActive = true;
        //        SaleStatus.ModifiedByName = modifiedByName;
        //        SaleStatus.ModifiedDate = DateTime.Now;
        //        var deletedSaleStatus = await UnitOfWork.SaleStatuses.UpdateAsync(SaleStatus);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<SaleStatusDto>(ResultStatus.Success, new SaleStatusDto
        //        {
        //            SaleStatus = deletedSaleStatus,
        //        }, Messages.SaleStatus.UndoDelete(deletedSaleStatus.CreatedByName));
        //    }
        //    return new DataResult<SaleStatusDto>(ResultStatus.Error, new SaleStatusDto
        //    {
        //        SaleStatus = null,
        //    }, Messages.SaleStatus.NotFound(isPlural: false));
        //}
    }
}
