using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentTypeDtos;
using MyBlog.Entities.Dtos.BrandDtos;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;

namespace MyBlog.Services.Abstract
{
    public interface IBrandService : IGenericService<Brand>
    {
        Task<IDataResult<BrandDto>> GetAsync(int BrandId);
        Task<IDataResult<BrandUpdateDto>> GetBrandUpdateDtoAsync(int BrandId);
        Task<IDataResult<BrandListDto>> GetAllAsync();
        Task<IDataResult<BrandDto>> DeleteAsync(int BrandId, string modifiedByName);

        //Task<IDataResult<BrandListDto>> GetAllByDeletedAsync();
        //Task<IDataResult<BrandListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<BrandListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<BrandDto>> AddAsync(BrandAddDto BrandAddDto, string createdByName);
        //Task<IDataResult<BrandDto>> ApproveAsync(int BrandId, string modifiedByName);
        Task<IDataResult<BrandDto>> UpdateAsync(BrandUpdateDto BrandUpdateDto, string modifiedByName);
    }
}