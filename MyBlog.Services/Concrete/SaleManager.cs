using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.SaleDtos;
using MyBlog.Entities.Dtos.SaleDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using static MyBlog.Services.Utilities.Messages;

namespace MyBlog.Services.Concrete
{
    public class SaleManager : ManagerBase, ISaleService
    {
        public SaleManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<SaleDto>> GetAsync(int SaleId)
        {
            var Sale = await UnitOfWork.Sales.GetAsync(c => c.Id == SaleId);
            if (Sale != null)
            {
                return new DataResult<SaleDto>(ResultStatus.Success, new SaleDto
                {
                    Sale = Sale,
                });
            }
            return new DataResult<SaleDto>(ResultStatus.Error, new SaleDto
            {
                Sale = null,
            }, Messages.General.NotFound(isPlural: false, "Çalışan"));
        }
        public async Task<IDataResult<SaleUpdateDto>> GetSaleUpdateDtoAsync(int SaleId)
        {
            var result = await UnitOfWork.Sales.AnyAsync(c => c.Id == SaleId);
            if (result)
            {
                var Sale = await UnitOfWork.Sales.GetAsync(c => c.Id == SaleId);
                var SaleUpdateDto = Mapper.Map<SaleUpdateDto>(Sale);
                return new DataResult<SaleUpdateDto>(ResultStatus.Success, SaleUpdateDto);
            }
            else
            {
                return new DataResult<SaleUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Çalışan"));
            }
        }

        public async Task<IDataResult<SaleListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var Sales = await UnitOfWork.Sales.GetAllWithNamesAsync(c => !c.IsDeleted && c.IsActive);
            if (Sales.Count > -1)
            {
                return new DataResult<SaleListDto>(ResultStatus.Success, new SaleListDto
                {
                    SaleListWithRelatedTables = Sales,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SaleListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Çalışan"));

        }

        public async Task<IDataResult<SaleListDto>> GetAllAsync()
        {
            var Sales = await UnitOfWork.Sales.GetAllWithNamesAsync();
            if (Sales.Count > -1)
            {
                return new DataResult<SaleListDto>(ResultStatus.Success, new SaleListDto
                {
                    SaleListWithRelatedTables = Sales,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SaleListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Çalışan"));
        }
        public async Task<IResult> AddAsync(SaleAddDto SaleAddDto, string createdByName, int userId)
        {
            var Sale = Mapper.Map<Sale>(SaleAddDto);
            Sale.CreatedByName = createdByName;
            Sale.ModifiedByName = createdByName;
            var addedSale = await UnitOfWork.Sales.AddAsync(Sale);
            await UnitOfWork.SaveAsync();
            return new DataResult<SaleDto>(ResultStatus.Success, new SaleDto
            {
                Sale = addedSale,
            }, Messages.General.GiveMessage("xxKx", "Çalışan", "eklendi."));
        }
        public async Task<IResult> UpdateAsync(SaleUpdateDto SaleUpdateDto, string modifiedByName)
        {
            var oldSale = await UnitOfWork.Sales.GetAsync(c => c.Id == SaleUpdateDto.Id);
            var Sale = Mapper.Map<SaleUpdateDto, Sale>(SaleUpdateDto, oldSale);
            Sale.ModifiedByName = modifiedByName;
            var updatedSale = await UnitOfWork.Sales.UpdateAsync(Sale);
            updatedSale.SaleType = await UnitOfWork.SaleTypes.GetAsync(a => a.Id == SaleUpdateDto.SaleTypeId);
            await UnitOfWork.SaveAsync();
            return new DataResult<SaleDto>(ResultStatus.Success, new SaleDto
            {
                Sale = updatedSale,
            }, Messages.General.GiveMessage("xxKx", "Çalışan", "Güncellendi."));
        }
        public async Task<IDataResult<SaleListDto>> GetAllByDeletedAsync()
        {
            var Sales = await UnitOfWork.Sales.GetAllWithNamesAsync(x => x.IsDeleted);
            if (Sales.Count > -1)
            {
                return new DataResult<SaleListDto>(ResultStatus.Success, new SaleListDto
                {
                    SaleListWithRelatedTables = Sales,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SaleListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Çalışan"));
        }

        public async Task<IDataResult<SaleListDto>> GetAllByNonDeletedAsync()
        {
            var Sales = await UnitOfWork.Sales.GetAllWithNamesAsync(x => !x.IsDeleted);
            if (Sales.Count > -1)
            {
                return new DataResult<SaleListDto>(ResultStatus.Success, new SaleListDto
                {
                    SaleListWithRelatedTables = Sales,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SaleListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Çalışan"));
        }

        public async Task<IDataResult<SaleDto>> DeleteAsync(int SaleId, string modifiedByName)
        {
            var sale = await UnitOfWork.Sales.GetAsync(c => c.Id == SaleId);
            if (sale != null)
            {
                sale.IsDeleted = true;
                sale.IsActive = false;
                sale.ModifiedByName = modifiedByName;
                sale.ModifiedDate = DateTime.Now;
                var deletedSale = await UnitOfWork.Sales.UpdateAsync(sale);
                await UnitOfWork.SaveAsync();
                return new DataResult<SaleDto>(ResultStatus.Success, new SaleDto
                {
                    Sale = deletedSale,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.General.GiveMessage("Satış", "Hasta", MessagesConstants.DeletedSuccess)

                }, Messages.General.GiveMessage("Satış", "Hasta", MessagesConstants.DeletedSuccess));
            }
            return new DataResult<SaleDto>(ResultStatus.Error, new SaleDto
            {
                Sale = null,
            }, Messages.General.GiveMessage("Satış", "Hasta", MessagesConstants.DeletedError));
        }

        public async Task<IResult> HardDeleteAsync(int SaleId)
        {
            var sale = await UnitOfWork.Sales.GetAsync(c => c.Id == SaleId);
            if (sale != null)
            {
                await UnitOfWork.Sales.DeleteAsync(sale);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage("Satış", "Hasta", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.NotFound(isPlural: false, "Hasta"));
        }

        public async Task<IDataResult<int>> CountAsync()
        {
            var SalesCount = await UnitOfWork.Sales.CountAsync();
            if (SalesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, SalesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var SalesCount = await UnitOfWork.Sales.CountAsync(c => !c.IsDeleted);
            if (SalesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, SalesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<SaleDto>> UndoDeleteAsync(int saleId, string modifiedByName)
        {
            var sale = await UnitOfWork.Sales.GetAsync(c => c.Id == saleId);
            if (sale != null)
            {
                sale.IsDeleted = false;
                sale.IsActive = true;
                sale.ModifiedByName = modifiedByName;
                sale.ModifiedDate = DateTime.Now;
                var deletedSale = await UnitOfWork.Sales.UpdateAsync(sale);
                await UnitOfWork.SaveAsync();
                return new DataResult<SaleDto>(ResultStatus.Success, new SaleDto
                {
                    Sale = deletedSale,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.General.GiveMessage("Satış", "Hasta", MessagesConstants.UpdateSuccess)
                }, Messages.General.GiveMessage("Satış", "Hasta", MessagesConstants.UpdateError));
            }
            return new DataResult<SaleDto>(ResultStatus.Error, new SaleDto
            {
                Sale = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.General.NotFound(isPlural: false, "Hasta")
            }, Messages.General.NotFound(isPlural: false, "Hasta"));
        }
    }
}
