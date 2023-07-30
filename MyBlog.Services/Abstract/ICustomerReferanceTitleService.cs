using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Dtos.CustomerReferanceTitleDtos;
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Entities.Dtos.CustomerDtos;
using MyBlog.Entities.Dtos.CustomerReferanceTitleDtos;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;

namespace MyBlog.Services.Abstract
{
    public interface ICustomerReferanceTitleService
    {
        Task<IDataResult<CustomerReferanceTitleDto>> GetAsync(int referanceTitleId);
        Task<IDataResult<CustomerReferanceTitleListDto>> GetAllAsync();
        Task<IDataResult<CustomerReferanceTitleUpdateDto>> GetCustomerReferanceTitleUpdateDtoAsync(int commentId);
        Task<IDataResult<CustomerReferanceTitleListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<CustomerReferanceTitleDto>> AddAsync(CustomerReferanceTitleAddDto customerReferanceUnvanAddDto, string createdByName);
        Task<IDataResult<CustomerReferanceTitleDto>> UpdateAsync(CustomerReferanceTitleUpdateDto commentUpdateDto, string modifiedByName);
        Task<IDataResult<CustomerReferanceTitleDto>> DeleteAsync(int BrandId, string modifiedByName);


        Task<IDataResult<CustomerReferanceTitleListDto>> GetAllByDeletedAsync();
        Task<IDataResult<CustomerReferanceTitleDto>> UndoDeleteAsync(int EmployeeTypeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
