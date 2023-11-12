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
using MyBlog.Entities.Dtos.AppointmentTypeDtos;

namespace MyBlog.Services.Abstract
{
    public interface IBrandService : IGenericService<Brand>
    {
        Task<IDataResult<BrandDto>> GetAsync(int BrandId);
        Task<IDataResult<BrandUpdateDto>> GetBrandUpdateDtoAsync(int BrandId);
        Task<IDataResult<BrandListDto>> GetAllAsync();
        Task<IDataResult<BrandDto>> DeleteAsync(int BrandId, string modifiedByName);
        Task<IDataResult<BrandListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<BrandListDto>> GetAllByNonDeletedAndActiveAccessoryAsync();
        Task<IDataResult<BrandDto>> AddAsync(BrandAddDto BrandAddDto, string createdByName);
        Task<IDataResult<BrandDto>> UpdateAsync(BrandUpdateDto BrandUpdateDto, string modifiedByName);

        Task<IDataResult<BrandListDto>> GetAllByDeletedAsync();
        Task<IDataResult<BrandDto>> UndoDeleteAsync(int EmployeeTypeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();

    }
}