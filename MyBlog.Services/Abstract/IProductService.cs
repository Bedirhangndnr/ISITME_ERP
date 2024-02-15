using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ProductDtos;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Entities.Dtos;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ProductDtos;
using MyBlog.Entities.Dtos.SaleDtos;

namespace MyBlog.Services.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        Task<IDataResult<ProductDto>> GetAsync(int ProductId);
        Task<IDataResult<ProductUpdateDto>> GetProductUpdateDtoAsync(int ProductId);
        Task<IDataResult<ProductListDto>> GetAllAsync();
        Task<IDataResult<ProductListDto>> GetAllByNonDeletedAndActiveAsync(bool getSolds = false, bool? IsUpdatePage = false, int Id = 0);
        Task<IDataResult<ProductListDto>> GetAllProductsAsync();
        Task<IDataResult<ProductListDto>> GetAllProductsForUpdateAsync(int productId=-1);
        Task<IDataResult<ProductListDto>> GetAllByNonDeletedAndActiveAccessoryAsync(bool getSolds = false, bool? IsUpdatePage = false, int Id = 0);
        Task<IDataResult<ProductListDto>> GetAllByDeletedAsync();
        Task<IDataResult<ProductListDto>> GetAllByNonDeletedAsync();
        Task<IResult> AddAsync(ProductAddDto ProductAddDto, string createdByName, int userId);
        Task<IResult> UpdateAsync(ProductUpdateDto ProductUpdateDto, string modifiedByName);


        Task<IDataResult<ProductDto>> DeleteAsync(int ProductId, string modifiedByName);
        Task<IDataResult<ProductDto>> UndoDeleteAsync(int ProductId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int ProductId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}