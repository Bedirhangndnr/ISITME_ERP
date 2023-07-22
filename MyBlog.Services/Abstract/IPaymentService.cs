using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentDtos;
using MyBlog.Entities.Dtos.ProductDtos;

namespace MyBlog.Services.Abstract
{
    public interface IPaymentService : IGenericService<Payment>
    {
        Task<IDataResult<PaymentDto>> GetAsync(int PaymentId);
        Task<IDataResult<PaymentListDto>> GetAllAsync();
        Task<IDataResult<PaymentListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<PaymentListDto>> GetAllByDeletedAsync();
        Task<IDataResult<PaymentUpdateDto>> GetPaymentUpdateDtoAsync(int ProductId);



        Task<IResult> AddAsync(PaymentAddDto PaymentAddDto, string createdByName, int userId);
        Task<IResult> UpdateAsync(PaymentUpdateDto PaymentUpdateDto, string modifiedByName);
        Task<IDataResult<PaymentDto>> DeleteAsync(int PaymentId, string modifiedByName);
        Task<IDataResult<PaymentDto>> UndoDeleteAsync(int PaymentId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int PaymentId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}