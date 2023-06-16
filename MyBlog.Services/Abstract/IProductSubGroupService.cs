using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentTypeDtos;
using MyBlog.Entities.Dtos.ProductSubGroupDtos;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;
using MyBlog.Entities.Dtos.ProductGroupDtos;

namespace MyBlog.Services.Abstract
{
    public interface IProductSubGroupService : IGenericService<ProductSubGroup>
    {
        Task<IDataResult<ProductSubGroupDto>> GetAsync(int ProductSubGroupId);
        Task<IDataResult<ProductSubGroupUpdateDto>> GetProductSubGroupUpdateDtoAsync(int ProductSubGroupId);
        Task<IDataResult<ProductSubGroupListDto>> GetAllAsync();
        Task<IDataResult<ProductSubGroupDto>> DeleteAsync(int ProductSubGroupId, string modifiedByName);
        Task<IDataResult<ProductSubGroupListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<ProductSubGroupDto>> AddAsync(ProductSubGroupAddDto ProductSubGroupAddDto, string createdByName);
        Task<IDataResult<ProductSubGroupDto>> UpdateAsync(ProductSubGroupUpdateDto ProductSubGroupUpdateDto, string modifiedByName);


        Task<IDataResult<ProductSubGroupListDto>> GetAllByDeletedAsync();
        Task<IDataResult<ProductSubGroupDto>> UndoDeleteAsync(int EmployeeTypeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}