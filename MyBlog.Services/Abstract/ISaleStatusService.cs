using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.SaleStatusDtos;

namespace MyBlog.Services.Abstract
{
    public interface ISaleStatusService : IGenericService<SaleStatus>
    {
        Task<IDataResult<SaleStatusDto>> GetAsync(int SaleStatusId);
        Task<IDataResult<SaleStatusUpdateDto>> GetSaleStatusUpdateDtoAsync(int SaleStatusId);
        Task<IDataResult<SaleStatusListDto>> GetAllAsync();
        Task<IDataResult<SaleStatusDto>> DeleteAsync(int SaleStatusId, string modifiedByName);

        //Task<IDataResult<SaleStatusListDto>> GetAllByDeletedAsync();
        //Task<IDataResult<SaleStatusListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<SaleStatusListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<SaleStatusDto>> AddAsync(SaleStatusAddDto SaleStatusAddDto, string createdByName);
        //Task<IDataResult<SaleStatusDto>> ApproveAsync(int SaleStatusId, string modifiedByName);
        Task<IDataResult<SaleStatusDto>> UpdateAsync(SaleStatusUpdateDto SaleStatusUpdateDto, string modifiedByName);
    }
}