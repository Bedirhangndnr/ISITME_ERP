using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //Task<IDataResult<CustomerReferanceListDto>> GetAllByDeletedAsync();
        //Task<IDataResult<CustomerReferanceListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<CustomerReferanceListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<CustomerReferanceDto>> AddAsync(CustomerReferanceAddDto customerReferanceAddDto, string createdByName);

        //Task<IResult> ApproveAsync(int commentId, string modifiedByName);
        Task<IDataResult<CustomerReferanceDto>> UpdateAsync(CustomerReferanceUpdateDto commentUpdateDto, string modifiedByName);
        //Task<IResult> DeleteAsync(int commentId, string modifiedByName);
        //Task<IResult> UndoDeleteAsync(int commentId, string modifiedByName);
        //Task<IResult> HardDeleteAsync(int commentId);
        //Task<IDataResult<int>> CountAsync();
        //Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
