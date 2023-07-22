using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentTypeDtos;
using MyBlog.Entities.Dtos.PaymentTypeDtos;

namespace MyBlog.Services.Abstract
{
    public interface IPaymentTypeService : IGenericService<PaymentType>
    {
        Task<IDataResult<PaymentTypeDto>> GetAsync(int PaymentTypeId);
        Task<IDataResult<PaymentTypeUpdateDto>> GetPaymentTypeUpdateDtoAsync(int PaymentTypeId);
        Task<IDataResult<PaymentTypeListDto>> GetAllAsync();
        Task<IDataResult<PaymentTypeDto>> DeleteAsync(int PaymentTypeId, string modifiedByName);

        //Task<IDataResult<PaymentTypeListDto>> GetAllByDeletedAsync();
        //Task<IDataResult<PaymentTypeListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<PaymentTypeListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<PaymentTypeDto>> AddAsync(PaymentTypeAddDto PaymentTypeAddDto, string createdByName);
        //Task<IDataResult<PaymentTypeDto>> ApproveAsync(int PaymentTypeId, string modifiedByName);
        Task<IDataResult<PaymentTypeDto>> UpdateAsync(PaymentTypeUpdateDto PaymentTypeUpdateDto, string modifiedByName);
    }
}