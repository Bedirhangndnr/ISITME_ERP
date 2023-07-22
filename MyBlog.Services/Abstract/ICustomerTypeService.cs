using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CustomerTypeDtos;
using MyBlog.Entities.Dtos.CustomerReferanceDtos;

namespace MyBlog.Services.Abstract
{
    public interface ICustomerTypeService : IGenericService<CustomerType>
    {
        Task<IDataResult<CustomerTypeDto>> GetAsync(int CustomerTypeId);
        Task<IDataResult<CustomerTypeUpdateDto>> GetCustomerTypeUpdateDtoAsync(int CustomerTypeId);
        Task<IDataResult<CustomerTypeListDto>> GetAllAsync();
        Task<IDataResult<CustomerTypeListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<CustomerTypeDto>> AddAsync(CustomerTypeAddDto CustomerTypeAddDto, string createdByName);
        Task<IDataResult<CustomerTypeDto>> UpdateAsync(CustomerTypeUpdateDto CustomerTypeUpdateDto, string modifiedByName);

        Task<IDataResult<CustomerTypeDto>> DeleteAsync(int TypeId, string modifiedByName);
        Task<IDataResult<CustomerTypeListDto>> GetAllByDeletedAsync();
        Task<IDataResult<CustomerTypeDto>> UndoDeleteAsync(int EmployeeTypeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}