using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentTypeDtos;
using MyBlog.Entities.Dtos.ProductGroupDtos;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;

namespace MyBlog.Services.Abstract
{
    public interface IProductGroupService : IGenericService<ProductGroup>
    {
        Task<IDataResult<ProductGroupDto>> GetAsync(int ProductGroupId);
        Task<IDataResult<ProductGroupUpdateDto>> GetProductGroupUpdateDtoAsync(int ProductGroupId);
        Task<IDataResult<ProductGroupListDto>> GetAllAsync();
        Task<IDataResult<ProductGroupDto>> DeleteAsync(int ProductGroupId, string modifiedByName);

        //Task<IDataResult<ProductGroupListDto>> GetAllByDeletedAsync();
        //Task<IDataResult<ProductGroupListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<ProductGroupListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<ProductGroupDto>> AddAsync(ProductGroupAddDto ProductGroupAddDto, string createdByName);
        //Task<IDataResult<ProductGroupDto>> ApproveAsync(int ProductGroupId, string modifiedByName);
        Task<IDataResult<ProductGroupDto>> UpdateAsync(ProductGroupUpdateDto ProductGroupUpdateDto, string modifiedByName);
    }
}