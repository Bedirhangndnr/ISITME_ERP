using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentTypeDtos;
using MyBlog.Entities.Dtos.SaleTypeDtos;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;

namespace MyBlog.Services.Abstract
{
    public interface ISaleTypeService : IGenericService<SaleType>
    {
        Task<IDataResult<SaleTypeDto>> GetAsync(int SaleTypeId);
        Task<IDataResult<SaleTypeUpdateDto>> GetSaleTypeUpdateDtoAsync(int SaleTypeId);
        Task<IDataResult<SaleTypeListDto>> GetAllAsync();
        Task<IDataResult<SaleTypeDto>> DeleteAsync(int SaleTypeId, string modifiedByName);
        Task<IDataResult<SaleTypeListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<SaleTypeDto>> AddAsync(SaleTypeAddDto SaleTypeAddDto, string createdByName);
        Task<IDataResult<SaleTypeDto>> UpdateAsync(SaleTypeUpdateDto SaleTypeUpdateDto, string modifiedByName);

        Task<IDataResult<SaleTypeListDto>> GetAllByDeletedAsync();
        Task<IDataResult<SaleTypeDto>> UndoDeleteAsync(int saleTypeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}