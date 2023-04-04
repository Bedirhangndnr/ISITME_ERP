using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentDtos;

namespace MyBlog.Services.Abstract
{
    public interface IPaymentService : IGenericService<Payment>
    {
        Task<IDataResult<PaymentDto>> GetAsync(int PaymentId);
        //Task<IDataResult<PaymentUpdateDto>> GetPaymentUpdateDtoAsync(int PaymentId);
        Task<IDataResult<PaymentListDto>> GetAllAsync();
        //Task<IDataResult<PaymentListDto>> GetAllByDeletedAsync();
        //Task<IDataResult<PaymentListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<PaymentListDto>> GetAllByNonDeletedAndActiveAsync();
        //Task<IDataResult<PaymentDto>> AddAsync(PaymentAddDto PaymentAddDto);
        //Task<IDataResult<PaymentDto>> ApproveAsync(int PaymentId, string modifiedByName);
        //Task<IDataResult<PaymentDto>> UpdateAsync(PaymentUpdateDto PaymentUpdateDto, string modifiedByName);
        //Task<IDataResult<PaymentDto>> DeleteAsync(int PaymentId, string modifiedByName);
        //Task<IDataResult<PaymentDto>> UndoDeleteAsync(int PaymentId, string modifiedByName);
        //Task<IResult> HardDeleteAsync(int PaymentId);
        //Task<IDataResult<int>> CountAsync();
        //Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}