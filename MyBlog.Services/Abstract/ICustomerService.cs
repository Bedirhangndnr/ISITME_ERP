using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CustomerDtos;

namespace MyBlog.Services.Abstract
{
    public interface ICustomerService : IGenericService<Customer>
    {
        Task<IDataResult<CustomerDto>> GetAsync(int CustomerId);
        Task<IDataResult<CustomerUpdateDto>> GetCustomerUpdateDtoAsync(int CustomerId);
        Task<IDataResult<CustomerListDto>> GetAllAsync();
        //Task<IDataResult<CustomerListDto>> GetAllByDeletedAsync();
        //Task<IDataResult<CustomerListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<CustomerListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<CustomerListDto>> GetAllForRemainds();
        Task<IResult> AddAsync(CustomerAddDto CustomerAddDto, string createdByName, int userId);
        //Task<IResult> ApproveAsync(int CustomerId, string modifiedByName);
        Task<IResult> UpdateAsync(CustomerUpdateDto CustomerUpdateDto, string modifiedByName);
        //Task<IResult> DeleteAsync(int CustomerId, string modifiedByName);
        //Task<IResult> UndoDeleteAsync(int CustomerId, string modifiedByName);
        //Task<IResult> HardDeleteAsync(int CustomerId);
        //Task<IDataResult<int>> CountAsync();
        //Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}