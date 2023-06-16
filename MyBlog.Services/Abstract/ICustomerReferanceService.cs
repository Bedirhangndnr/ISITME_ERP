using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Dtos.CustomerReferanceDtos;
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Entities.Dtos.CustomerDtos;
using MyBlog.Entities.Dtos.CustomerReferanceDtos;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;

namespace MyBlog.Services.Abstract
{
    public interface ICustomerReferanceService
    {
        Task<IDataResult<CustomerReferanceDto>> GetAsync(int referanceId);
        Task<IDataResult<CustomerReferanceListDto>> GetAllAsync();
        Task<IDataResult<CustomerReferanceUpdateDto>> GetCustomerReferanceUpdateDtoAsync(int commentId);
        Task<IDataResult<CustomerReferanceListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<CustomerReferanceDto>> AddAsync(CustomerReferanceAddDto customerReferanceAddDto, string createdByName);
        Task<IDataResult<CustomerReferanceDto>> UpdateAsync(CustomerReferanceUpdateDto commentUpdateDto, string modifiedByName);
        Task<IDataResult<CustomerReferanceDto>> DeleteAsync(int BrandId, string modifiedByName);


        Task<IDataResult<CustomerReferanceListDto>> GetAllByDeletedAsync();
        Task<IDataResult<CustomerReferanceDto>> UndoDeleteAsync(int EmployeeTypeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
