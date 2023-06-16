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
            }, Messages.General.NotFound(isPlural: false, "Ödeme"));
        }
        public async Task<IDataResult<PaymentListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var payments = await UnitOfWork.Payments.GetAllAsync(x => !x.IsDeleted);
            var paymentWithRelated = await UnitOfWork.Payments.GetAllWithNamesAsync(x => !x.IsDeleted);
            if (payments.Count > -1)
            {
                return new DataResult<PaymentListDto>(ResultStatus.Success, new PaymentListDto
                {
                    Payments = payments,
                    PaymentListWithRelatedTables = paymentWithRelated,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PaymentListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Ödeme"));

        }


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
            }, Messages.General.NotFound(isPlural: true, "Ödeme"));
        }

        public async Task<IResult> AddAsync(PaymentAddDto PaymentAddDto, string createdByName, int userId)
        {
            var payment = Mapper.Map<Payment>(PaymentAddDto);
            payment.CreatedByName = createdByName;
            payment.ModifiedByName = createdByName;
            var addedPayment = await UnitOfWork.Payments.AddAsync(payment);
            await UnitOfWork.SaveAsync();
            return new DataResult<PaymentDto>(ResultStatus.Success, new PaymentDto
            {
                Payment = addedPayment,
            }, Messages.General.GiveMessage(PaymentAddDto.AmountPaid.ToString().ToString(), "Ödeme", "eklendi."));
        }

        public async Task<IResult> UpdateAsync(PaymentUpdateDto PaymentUpdateDto, string modifiedByName)
        {
            var oldPayment = await UnitOfWork.Payments.GetAsync(a => a.Id == PaymentUpdateDto.Id);
            var payment = Mapper.Map<PaymentUpdateDto, Payment>(PaymentUpdateDto, oldPayment);
            payment.ModifiedByName = modifiedByName;
            await UnitOfWork.Payments.UpdateAsync(payment);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.General.GiveMessage(payment.AmountPaid.ToString(), "Ödeme", "Güncellendi"));
        }

        public async Task<IDataResult<PaymentListDto>> GetAllByDeletedAsync()
        {
            var payments = await UnitOfWork.Payments.GetAllWithNamesAsync(x => x.IsDeleted);
            if (payments.Count > -1)
            {
                return new DataResult<PaymentListDto>(ResultStatus.Success, new PaymentListDto
                {
                    PaymentListWithRelatedTables = payments,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PaymentListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Ödeme"));
        }

        public async Task<IDataResult<PaymentDto>> DeleteAsync(int PaymentId, string modifiedByName)
        {
            var payment = await UnitOfWork.Payments.GetAsync(c => c.Id == PaymentId);
            if (payment != null)
            {
                payment.IsDeleted = true;
                payment.IsActive = false;
                payment.ModifiedByName = modifiedByName;
                payment.ModifiedDate = DateTime.Now;
                var deletedPayment = await UnitOfWork.Payments.UpdateAsync(payment);
                await UnitOfWork.SaveAsync();
                return new DataResult<PaymentDto>(ResultStatus.Success, new PaymentDto
                {
                    Payment = deletedPayment,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.General.GiveMessage(payment.AmountPaid.ToString(), "Ödeme", MessagesConstants.DeletedSuccess)

                }, Messages.General.GiveMessage(payment.AmountPaid.ToString(), "Ödeme", MessagesConstants.DeletedSuccess));
            }
            return new DataResult<PaymentDto>(ResultStatus.Error, new PaymentDto
            {
                Payment = null,
            }, Messages.General.GiveMessage(payment.AmountPaid.ToString(), "Ödeme", MessagesConstants.DeletedError));
        }
        public async Task<IDataResult<PaymentUpdateDto>> GetPaymentUpdateDtoAsync(int PaymentId)
        {
            var result = await UnitOfWork.Payments.AnyAsync(c => c.Id == PaymentId);
            if (result)
            {
                var Payment = await UnitOfWork.Payments.GetAsync(c => c.Id == PaymentId);
                var PaymentUpdateDto = Mapper.Map<PaymentUpdateDto>(Payment);
                return new DataResult<PaymentUpdateDto>(ResultStatus.Success, PaymentUpdateDto);
            }
            else
            {
                return new DataResult<PaymentUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Ödeme"));
            }
        }
        public async Task<IResult> HardDeleteAsync(int PaymentId)
        {
            var payment = await UnitOfWork.Payments.GetAsync(c => c.Id == PaymentId);
            if (payment != null)
            {
                await UnitOfWork.Payments.DeleteAsync(payment);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(payment.AmountPaid.ToString(), "Ödeme", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.NotFound(isPlural: false, "Ödeme"));
        }

        public async Task<IDataResult<int>> CountAsync()
        {
            var PaymentsCount = await UnitOfWork.Payments.CountAsync();
            if (PaymentsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, PaymentsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var PaymentsCount = await UnitOfWork.Payments.CountAsync(c => !c.IsDeleted);
            if (PaymentsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, PaymentsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<PaymentDto>> UndoDeleteAsync(int paymentId, string modifiedByName)
        {
            var payment = await UnitOfWork.Payments.GetAsync(c => c.Id == paymentId);
            if (payment != null)
            {
                payment.IsDeleted = false;
                payment.IsActive = true;
                payment.ModifiedByName = modifiedByName;
                payment.ModifiedDate = DateTime.Now;
                var deletedPayment = await UnitOfWork.Payments.UpdateAsync(payment);
                await UnitOfWork.SaveAsync();
                return new DataResult<PaymentDto>(ResultStatus.Success, new PaymentDto
                {
                    Payment = deletedPayment,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.General.GiveMessage(payment.AmountPaid.ToString(), "Ödeme", MessagesConstants.UpdateSuccess)
                }, Messages.General.GiveMessage(payment.AmountPaid.ToString(), "Ödeme", MessagesConstants.UpdateError));
            }
            return new DataResult<PaymentDto>(ResultStatus.Error, new PaymentDto
            {
                Payment = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.General.NotFound(isPlural: false, "Ödeme")
            }, Messages.General.NotFound(isPlural: false, "Ödeme"));
        }
    }
}

