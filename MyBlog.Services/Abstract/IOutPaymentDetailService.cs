using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentTypeDtos;
using MyBlog.Entities.Dtos.OutPaymentDetailDtos;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;

namespace MyBlog.Services.Abstract
{
    public interface IOutPaymentDetailService : IGenericService<OutPaymentDetail>
    {
        Task<IDataResult<OutPaymentDetailDto>> GetAsync(int OutPaymentDetailId);
        Task<IDataResult<OutPaymentDetailUpdateDto>> GetOutPaymentDetailUpdateDtoAsync(int OutPaymentDetailId);
        Task<IDataResult<OutPaymentDetailListDto>> GetAllAsync();
        Task<IDataResult<OutPaymentDetailDto>> DeleteAsync(int OutPaymentDetailId, string modifiedByName);
        Task<IDataResult<OutPaymentDetailListDto>> GetAllByNonDeletedAndActiveAsync(int outPaymentId = 0);
        Task<IDataResult<OutPaymentDetailDto>> AddAsync(OutPaymentDetailAddDto OutPaymentDetailAddDto, string createdByName);
        Task<IDataResult<OutPaymentDetailDto>> UpdateAsync(OutPaymentDetailUpdateDto OutPaymentDetailUpdateDto, string modifiedByName);

        Task<IDataResult<OutPaymentDetailListDto>> GetAllByDeletedAsync();
        Task<IDataResult<OutPaymentDetailDto>> UndoDeleteAsync(int saleTypeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();

        Task<IResult> DeleteByOutPaymentIdAsync(int outPaymentDetailId, string modifiedByName);
        Task<IResult> HardDeleteByOutPaymentIdAsync(int outPaymentId);
        Task<IDataResult<OutPaymentDetailDto>> UndoDeleteByOutPaymentIdAsync(int outPaymentId, string modifiedByName);
    }
}