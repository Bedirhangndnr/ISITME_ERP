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
using MyBlog.Entities.Dtos.SaleStatusDtos;

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
            }, Messages.General.NotFound(isPlural: false, "Satış Durumu"));
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
            return new DataResult<SaleStatusListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Satış Durumu"));

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
                return new DataResult<SaleStatusUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Satış Durumu Tipi"));
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
            }, Messages.General.NotFound(isPlural: true, "Satış Durumu"));
        }
        public async Task<IDataResult<SaleStatusDto>> AddAsync(SaleStatusAddDto saleStatusAddDto, string createdByName)
        {
            var saleStatus = Mapper.Map<SaleStatus>(saleStatusAddDto);

            saleStatus.ModifiedByName = createdByName;
            saleStatus.CreatedByName = createdByName;
            var addedSaleStatus = await UnitOfWork.SaleStatuses.AddAsync(saleStatus);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(saleStatus);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<SaleStatusDto>(ResultStatus.Success, new SaleStatusDto
            {
                Message= Messages.General.GiveMessage(addedSaleStatus.CreatedByName, "Satış Durumu Tipi", MessagesConstants.AddSuccess),
                SaleStatus = addedSaleStatus,
            }, Messages.General.GiveMessage(addedSaleStatus.CreatedByName, "Satış Durumu Tipi", MessagesConstants.AddSuccess));
        }

        public async Task<IDataResult<SaleStatusDto>> UpdateAsync(SaleStatusUpdateDto saleStatusUpdateDto, string modifiedByName)
        {
            var oldSaleStatus = await UnitOfWork.SaleStatuses.GetAsync(c => c.Id == saleStatusUpdateDto.Id);
            var saleStatus = Mapper.Map<SaleStatusUpdateDto, SaleStatus>(saleStatusUpdateDto, oldSaleStatus);
            saleStatus.ModifiedByName = modifiedByName;
            var updatedSaleStatus = await UnitOfWork.SaleStatuses.UpdateAsync(saleStatus);
            saleStatus = await UnitOfWork.SaleStatuses.GetAsync(a => a.Id == saleStatusUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<SaleStatusDto>(ResultStatus.Success, new SaleStatusDto
            {
                Message= Messages.General.GiveMessage(saleStatus.Title, "Satış Durumu Tipi", MessagesConstants.UpdateSuccess),
                SaleStatus = updatedSaleStatus,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(saleStatus.Title, "Satış Durumu Tipi", MessagesConstants.UpdateSuccess));
        }
        public async Task<IDataResult<SaleStatusDto>> DeleteAsync(int saleStatusId, string modifiedByName)
        {
            var saleStatus = await UnitOfWork.SaleStatuses.GetAsync(c => c.Id == saleStatusId);
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
                    Message= Messages.General.GiveMessage(saleStatus.Title, "Satış Durumu Tipi", MessagesConstants.UpdateSuccess),
                    SaleStatus = deletedEmployeeType
                    
                }, Messages.General.GiveMessage(saleStatus.Title, "Satış Durumu Tipi", MessagesConstants.UpdateSuccess));
            }
            return new DataResult<SaleStatusDto>(ResultStatus.Error, new SaleStatusDto
            {
                SaleStatus = null,
            }, Messages.General.GiveMessage(saleStatus.Title, "Satış Durumu Tipi", MessagesConstants.UpdateError));
        }
        public async Task<IDataResult<SaleStatusListDto>> GetAllByDeletedAsync()
        {
            var saleStatuses = await UnitOfWork.SaleStatuses.GetAllAsync(c => c.IsDeleted);
            if (saleStatuses.Count > -1)
            {
                return new DataResult<SaleStatusListDto>(ResultStatus.Success, new SaleStatusListDto
                {
                    SaleStatuses = saleStatuses,
                });
            }
            return new DataResult<SaleStatusListDto>(ResultStatus.Error, new SaleStatusListDto
            {
                SaleStatuses = null,
            }, Messages.General.TableNotFound("Ürün Alt Grupları"));
        }
        public async Task<IResult> HardDeleteAsync(int saleStatusId)
        {
            var saleStatus = await UnitOfWork.SaleStatuses.GetAsync(c => c.Id == saleStatusId);
            if (saleStatus != null)
            {
                await UnitOfWork.SaleStatuses.DeleteAsync(saleStatus);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(saleStatus.Title, "Satış Durumu", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.GiveMessage(saleStatus.Title, "Satış Durumu", MessagesConstants.HardDeletedSuccess));
        }


        public async Task<IDataResult<SaleStatusDto>> UndoDeleteAsync(int saleStatusId, string modifiedByName)
        {
            var saleStatus = await UnitOfWork.SaleStatuses.GetAsync(c => c.Id == saleStatusId);
            if (saleStatus != null)
            {
                saleStatus.IsDeleted = false;
                saleStatus.IsActive = true;
                saleStatus.ModifiedByName = modifiedByName;
                saleStatus.ModifiedDate = DateTime.Now;
                var deletedSaleStatus = await UnitOfWork.SaleStatuses.UpdateAsync(saleStatus);
                await UnitOfWork.SaveAsync();
                return new DataResult<SaleStatusDto>(ResultStatus.Success, new SaleStatusDto
                {
                    Message = Messages.General.GiveMessage(saleStatus.Title, "Satış Durumu", MessagesConstants.UndoDeletedSuccess),
                    SaleStatus = deletedSaleStatus,
                }, Messages.General.GiveMessage(saleStatus.Title, "Satış Durumu", MessagesConstants.UndoDeletedSuccess));
            }
            return new DataResult<SaleStatusDto>(ResultStatus.Error, new SaleStatusDto
            {
                SaleStatus = null,
            }, Messages.General.GiveMessage(saleStatus.Title, "Satış Durumu", MessagesConstants.UndoDeletedError));
        }
        public async Task<IDataResult<int>> CountAsync()
        {
            var saleStatusesCount = await UnitOfWork.SaleStatuses.CountAsync();
            if (saleStatusesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, saleStatusesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var saleStatusesCount = await UnitOfWork.SaleStatuses.CountAsync(c => !c.IsDeleted);
            if (saleStatusesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, saleStatusesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }
    }
}
