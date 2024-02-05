using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CustomerDtos;
using MyBlog.Entities.Dtos;

namespace MyBlog.Services.Abstract
{
    public interface ICustomerService : IGenericService<Customer>
    {
        Task<IDataResult<CustomerDto>> GetAsync(int CustomerId);
        Task<IDataResult<CustomerUpdateDto>> GetCustomerUpdateDtoAsync(int CustomerId);
        Task<IDataResult<CustomerListDto>> GetAllAsync();
        Task<IDataResult<CustomerListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<CustomerListDto>> GetAllForRemainds();
        Task<IResult> AddAsync(CustomerAddDto CustomerAddDto, string createdByName, int userId);
        Task<IResult> UpdateAsync(CustomerUpdateDto CustomerUpdateDto, string modifiedByName);


        Task<IDataResult<CustomerDto>> DeleteAsync(int CustomerId, string modifiedByName);
        Task<IDataResult<CustomerDto>> UndoDeleteAsync(int CustomerId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int CustomerId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}