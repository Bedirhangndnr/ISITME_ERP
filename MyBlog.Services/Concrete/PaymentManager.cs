using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;

namespace MyBlog.Services.Concrete
{
    public class PaymentManager:ManagerBase,IPaymentService
    {
        public PaymentManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<PaymentDto>> GetAsync(int PaymentId)
        {
            var Payment = await UnitOfWork.Payments.GetAsync(c => c.Id == PaymentId);
            if (Payment != null)
            {
                return new DataResult<PaymentDto>(ResultStatus.Success, new PaymentDto
                {
                    Payment = Payment,
                });
            }
            return new DataResult<PaymentDto>(ResultStatus.Error, new PaymentDto
            {
                Payment = null,
            }, Messages.General.NotFound(isPlural: false, "Müşteri"));
        }
        public async Task<IDataResult<PaymentListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var payments = await UnitOfWork.Payments.GetAllAsync(x => !x.IsDeleted);
            if (payments.Count > -1)
            {
                return new DataResult<PaymentListDto>(ResultStatus.Success, new PaymentListDto
                {
                    Payments = payments,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PaymentListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

        }
        //public async Task<IDataResult<PaymentUpdateDto>> GetPaymentUpdateDtoAsync(int PaymentId)
        //{
        //    var result = await UnitOfWork.Payments.AnyAsync(c => c.Id == PaymentId);
        //    if (result)
        //    {
        //        var Payment = await UnitOfWork.Payments.GetAsync(c => c.Id == PaymentId);
        //        var PaymentUpdateDto = Mapper.Map<PaymentUpdateDto>(Payment);
        //        return new DataResult<PaymentUpdateDto>(ResultStatus.Success, PaymentUpdateDto);
        //    }
        //    else
        //    {
        //        return new DataResult<PaymentUpdateDto>(ResultStatus.Error, null, Messages.Payment.NotFound(isPlural: false));
        //    }
        //}

        public async Task<IDataResult<PaymentListDto>> GetAllAsync()
        {
            var Payments = await UnitOfWork.Payments.GetAllAsync(null);
            if (Payments.Count > -1)
            {
                return new DataResult<PaymentListDto>(ResultStatus.Success, new PaymentListDto
                {
                    Payments = Payments,
                });
            }
            return new DataResult<PaymentListDto>(ResultStatus.Error, new PaymentListDto
            {
                Payments = null,
            }, Messages.General.NotFound(isPlural: true, "Müşteri"));
        }

        //public async Task<IDataResult<PaymentListDto>> GetAllByDeletedAsync()
        //{
        //    var Payments = await UnitOfWork.Payments.GetAllAsync(c=>c.IsDeleted, c => c.Payment);
        //    if (Payments.Count > -1)
        //    {
        //        return new DataResult<PaymentListDto>(ResultStatus.Success, new PaymentListDto
        //        {
        //            Payments = Payments,
        //        });
        //    }
        //    return new DataResult<PaymentListDto>(ResultStatus.Error, new PaymentListDto
        //    {
        //        Payments = null,
        //    }, Messages.Payment.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<PaymentListDto>> GetAllByNonDeletedAsync()
        //{
        //    var Payments = await UnitOfWork.Payments.GetAllAsync(c => !c.IsDeleted, c => c.Payment);
        //    if (Payments.Count > -1)
        //    {
        //        return new DataResult<PaymentListDto>(ResultStatus.Success, new PaymentListDto
        //        {
        //            Payments = Payments,
        //        });
        //    }
        //    return new DataResult<PaymentListDto>(ResultStatus.Error, new PaymentListDto
        //    {
        //        Payments = null,
        //    }, Messages.Payment.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<PaymentListDto>> GetAllByNonDeletedAndActiveAsync()
        //{
        //    var Payments = await UnitOfWork.Payments.GetAllAsync(c => !c.IsDeleted && c.IsActive);
        //    if (Payments.Count > -1)
        //    {
        //        return new DataResult<PaymentListDto>(ResultStatus.Success, new PaymentListDto
        //        {
        //            Payments = Payments,
        //        });
        //    }
        //    return new DataResult<PaymentListDto>(ResultStatus.Error, new PaymentListDto
        //    {
        //        Payments = null,
        //    }, Messages.General.NotFound(isPlural: true, "Hasta"));
        //}

        //public async Task<IDataResult<PaymentDto>> AddAsync(PaymentAddDto PaymentAddDto)
        //{
        //    var Payment = Mapper.Map<Payment>(PaymentAddDto);
        //    var addedPayment = await UnitOfWork.Payments.AddAsync(Payment);
        //    await UnitOfWork.SaveAsync();
        //    return new DataResult<PaymentDto>(ResultStatus.Success, new PaymentDto
        //    {
        //        Payment = addedPayment,
        //    }, Messages.Payment.Add(PaymentAddDto.CreatedByName));
        //}

        //public async Task<IDataResult<PaymentDto>> UpdateAsync(PaymentUpdateDto PaymentUpdateDto, string modifiedByName)
        //{
        //    var oldPayment = await UnitOfWork.Payments.GetAsync(c => c.Id == PaymentUpdateDto.Id);
        //    var Payment = Mapper.Map<PaymentUpdateDto, Payment>(PaymentUpdateDto, oldPayment);
        //    Payment.ModifiedByName = modifiedByName;
        //    var updatedPayment = await UnitOfWork.Payments.UpdateAsync(Payment);
        //    updatedPayment.Payment = await UnitOfWork.Payments.GetAsync(a=>a.Id==PaymentUpdateDto.PaymentId);
        //    await UnitOfWork.SaveAsync();
        //    return new DataResult<PaymentDto>(ResultStatus.Success, new PaymentDto
        //    {
        //        Payment = updatedPayment,
        //    }, Messages.Payment.Update(Payment.CreatedByName));
        //}

        //public async Task<IDataResult<PaymentDto>> DeleteAsync(int PaymentId, string modifiedByName)
        //{
        //    var Payment = await UnitOfWork.Payments.GetAsync(c => c.Id == PaymentId);
        //    if (Payment != null)
        //    {
        //        Payment.IsDeleted = true;
        //        Payment.IsActive = false;
        //        Payment.ModifiedByName = modifiedByName;
        //        Payment.ModifiedDate = DateTime.Now;
        //        var deletedPayment = await UnitOfWork.Payments.UpdateAsync(Payment);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<PaymentDto>(ResultStatus.Success, new PaymentDto
        //        {
        //            Payment = deletedPayment,
        //        }, Messages.Payment.Delete(deletedPayment.CreatedByName));
        //    }
        //    return new DataResult<PaymentDto>(ResultStatus.Error, new PaymentDto
        //    {
        //        Payment = null,
        //    }, Messages.Payment.NotFound(isPlural: false));
        //}

        //public async Task<IResult> HardDeleteAsync(int PaymentId)
        //{
        //    var Payment = await UnitOfWork.Payments.GetAsync(c => c.Id == PaymentId);
        //    if (Payment != null)
        //    {
        //        await UnitOfWork.Payments.DeleteAsync(Payment);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.Payment.HardDelete(Payment.CreatedByName));
        //    }
        //    return new Result(ResultStatus.Error, Messages.Payment.NotFound(isPlural: false));
        //}

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var PaymentsCount = await UnitOfWork.Payments.CountAsync();
        //    if (PaymentsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, PaymentsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1,$"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var PaymentsCount = await UnitOfWork.Payments.CountAsync(c=>!c.IsDeleted);
        //    if (PaymentsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, PaymentsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<PaymentDto>> ApproveAsync(int PaymentId, string modifiedByName)
        //{
        //    var Payment = await UnitOfWork.Payments.GetAsync(c => c.Id == PaymentId, c => c.Payment);
        //    if (Payment != null)
        //    {
        //        Payment.IsActive = true;
        //        Payment.ModifiedByName = modifiedByName;
        //        Payment.ModifiedDate = DateTime.Now;
        //        var updatedPayment = await UnitOfWork.Payments.UpdateAsync(Payment);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<PaymentDto>(ResultStatus.Success, new PaymentDto
        //        {
        //            Payment = updatedPayment
        //        }, Messages.Payment.Approve(PaymentId));
        //    }

        //    return new DataResult<PaymentDto>(ResultStatus.Error, null, Messages.Payment.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<PaymentDto>> UndoDeleteAsync(int PaymentId, string modifiedByName)
        //{
        //    var Payment = await UnitOfWork.Payments.GetAsync(c => c.Id == PaymentId);
        //    if (Payment != null)
        //    {
        //        Payment.IsDeleted = false;
        //        Payment.IsActive = true;
        //        Payment.ModifiedByName = modifiedByName;
        //        Payment.ModifiedDate = DateTime.Now;
        //        var deletedPayment = await UnitOfWork.Payments.UpdateAsync(Payment);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<PaymentDto>(ResultStatus.Success, new PaymentDto
        //        {
        //            Payment = deletedPayment,
        //        }, Messages.Payment.UndoDelete(deletedPayment.CreatedByName));
        //    }
        //    return new DataResult<PaymentDto>(ResultStatus.Error, new PaymentDto
        //    {
        //        Payment = null,
        //    }, Messages.Payment.NotFound(isPlural: false));
        //}
    }
}
