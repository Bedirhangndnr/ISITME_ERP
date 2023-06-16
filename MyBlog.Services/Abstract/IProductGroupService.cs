using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ProductGroupDtos;

namespace MyBlog.Services.Abstract
{
    public interface IProductGroupService : IGenericService<ProductGroup>
    {
        Task<IDataResult<ProductGroupDto>> GetAsync(int ProductGroupId);
        Task<IDataResult<ProductGroupUpdateDto>> GetProductGroupUpdateDtoAsync(int ProductGroupId);
        Task<IDataResult<ProductGroupListDto>> GetAllAsync();
        Task<IDataResult<ProductGroupDto>> DeleteAsync(int ProductGroupId, string modifiedByName);
        Task<IDataResult<ProductGroupListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<ProductGroupDto>> AddAsync(ProductGroupAddDto ProductGroupAddDto, string createdByName);
        Task<IDataResult<ProductGroupDto>> UpdateAsync(ProductGroupUpdateDto ProductGroupUpdateDto, string modifiedByName);



        Task<IDataResult<ProductGroupListDto>> GetAllByDeletedAsync();
        Task<IDataResult<ProductGroupDto>> UndoDeleteAsync(int EmployeeTypeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}