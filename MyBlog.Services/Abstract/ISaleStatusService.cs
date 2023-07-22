using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.SaleStatusDtos;
using MyBlog.Entities.Dtos.ProductSubGroupDtos;

namespace MyBlog.Services.Abstract
{
    public interface ISaleStatusService : IGenericService<SaleStatus>
    {
        Task<IDataResult<SaleStatusDto>> GetAsync(int SaleStatusId);
        Task<IDataResult<SaleStatusUpdateDto>> GetSaleStatusUpdateDtoAsync(int SaleStatusId);
        Task<IDataResult<SaleStatusListDto>> GetAllAsync();
        Task<IDataResult<SaleStatusDto>> DeleteAsync(int SaleStatusId, string modifiedByName);
        Task<IDataResult<SaleStatusListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<SaleStatusDto>> AddAsync(SaleStatusAddDto SaleStatusAddDto, string createdByName);
        Task<IDataResult<SaleStatusDto>> UpdateAsync(SaleStatusUpdateDto SaleStatusUpdateDto, string modifiedByName);


        Task<IDataResult<SaleStatusListDto>> GetAllByDeletedAsync();
        Task<IDataResult<SaleStatusDto>> UndoDeleteAsync(int saleStatusId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}