using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.OutPaymentDtos;
using MyBlog.Entities.Dtos.ProductDtos;
using MyBlog.Entities.Dtos.PaymentDtos;

namespace MyBlog.Services.Abstract
{
    public interface IOutPaymentService : IGenericService<OutPayment>
    {
        Task<IDataResult<OutPaymentDto>> GetAsync(int OutPaymentId);
        Task<IDataResult<OutPaymentListDto>> GetAllAsync();
        Task<IDataResult<OutPaymentListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<OutPaymentListDto>> GetAllByDeletedAsync();
        Task<IDataResult<OutPaymentUpdateDto>> GetOutPaymentUpdateDtoAsync(int ProductId);



        Task<IResult> AddAsync(OutPaymentAddDto OutPaymentAddDto, string createdByName, int userId);
        Task<IResult> UpdateAsync(OutPaymentUpdateDto OutPaymentUpdateDto, string modifiedByName);
        Task<IDataResult<OutPaymentDto>> DeleteAsync(int OutPaymentId, string modifiedByName);
        Task<IDataResult<OutPaymentDto>> UndoDeleteAsync(int OutPaymentId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int OutPaymentId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}