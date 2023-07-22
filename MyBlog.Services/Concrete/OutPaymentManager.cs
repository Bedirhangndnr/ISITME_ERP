using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.OutPaymentDtos;
using MyBlog.Entities.Dtos.PaymentDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;

namespace MyBlog.Services.Concrete
{
    public class OutPaymentManager:ManagerBase,IOutPaymentService
    {
        public OutPaymentManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<OutPaymentDto>> GetAsync(int OutPaymentId)
        {
            var OutPayment = await UnitOfWork.OutPayments.GetAsync(c => c.Id == OutPaymentId);
            if (OutPayment != null)
            {
                return new DataResult<OutPaymentDto>(ResultStatus.Success, new OutPaymentDto
                {
                    OutPayment = OutPayment,
                });
            }
            return new DataResult<OutPaymentDto>(ResultStatus.Error, new OutPaymentDto
            {
                OutPayment = null,
            }, Messages.General.NotFound(isPlural: false, "Ödeme"));
        }
        public async Task<IDataResult<OutPaymentListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var OutPayments = await UnitOfWork.OutPayments.GetAllAsync(x => !x.IsDeleted);
            if (OutPayments.Count > -1)
            {
                return new DataResult<OutPaymentListDto>(ResultStatus.Success, new OutPaymentListDto
                {
                    OutPayments = OutPayments,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OutPaymentListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Ödeme"));

        }


        public async Task<IDataResult<OutPaymentListDto>> GetAllAsync()
        {
            var OutPayments = await UnitOfWork.OutPayments.GetAllAsync(null);
            if (OutPayments.Count > -1)
            {
                return new DataResult<OutPaymentListDto>(ResultStatus.Success, new OutPaymentListDto
                {
                    OutPayments = OutPayments,
                });
            }
            return new DataResult<OutPaymentListDto>(ResultStatus.Error, new OutPaymentListDto
            {
                OutPayments = null,
            }, Messages.General.NotFound(isPlural: true, "Ödeme"));
        }
        public async Task<IDataResult<OutPaymentListDto>> GetAllByDeletedAsync()
        {
            var OutPayments = await UnitOfWork.OutPayments.GetAllAsync(x => x.IsDeleted);
            if (OutPayments.Count > -1)
            {
                return new DataResult<OutPaymentListDto>(ResultStatus.Success, new OutPaymentListDto
                {
                    OutPayments = OutPayments,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OutPaymentListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Ödeme"));
        }

        public async Task<IResult> AddAsync(OutPaymentAddDto OutPaymentAddDto, string createdByName, int userId)
        {
            var payment = Mapper.Map<OutPayment>(OutPaymentAddDto);
            payment.CreatedByName = createdByName;
            payment.ModifiedByName = createdByName;
            var addedOutPayment = await UnitOfWork.OutPayments.AddAsync(payment);
            await UnitOfWork.SaveAsync();
            return new DataResult<OutPaymentDto>(ResultStatus.Success, new OutPaymentDto
            {
                OutPayment = addedOutPayment,
            }, Messages.General.GiveMessage(OutPaymentAddDto.AmountPaid.ToString().ToString(), "Ödeme", "eklendi."));
        }

        public async Task<IResult> UpdateAsync(OutPaymentUpdateDto OutPaymentUpdateDto, string modifiedByName)
        {
            var oldOutPayment = await UnitOfWork.OutPayments.GetAsync(a => a.Id == OutPaymentUpdateDto.Id);
            var payment = Mapper.Map<OutPaymentUpdateDto, OutPayment>(OutPaymentUpdateDto, oldOutPayment);
            payment.ModifiedByName = modifiedByName;
            await UnitOfWork.OutPayments.UpdateAsync(payment);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.General.GiveMessage(payment.AmountPaid.ToString(), "Ödeme", "Güncellendi"));
        }


        public async Task<IDataResult<OutPaymentDto>> DeleteAsync(int OutPaymentId, string modifiedByName)
        {
            var payment = await UnitOfWork.OutPayments.GetAsync(c => c.Id == OutPaymentId);
            if (payment != null)
            {
                payment.IsDeleted = true;
                payment.IsActive = false;
                payment.ModifiedByName = modifiedByName;
                payment.ModifiedDate = DateTime.Now;
                var deletedOutPayment = await UnitOfWork.OutPayments.UpdateAsync(payment);
                await UnitOfWork.SaveAsync();
                return new DataResult<OutPaymentDto>(ResultStatus.Success, new OutPaymentDto
                {
                    OutPayment = deletedOutPayment,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.General.GiveMessage(payment.AmountPaid.ToString(), "Ödeme", MessagesConstants.DeletedSuccess)

                }, Messages.General.GiveMessage(payment.AmountPaid.ToString(), "Ödeme", MessagesConstants.DeletedSuccess));
            }
            return new DataResult<OutPaymentDto>(ResultStatus.Error, new OutPaymentDto
            {
                OutPayment = null,
            }, Messages.General.GiveMessage(payment.AmountPaid.ToString(), "Ödeme", MessagesConstants.DeletedError));
        }
        public async Task<IDataResult<OutPaymentUpdateDto>> GetOutPaymentUpdateDtoAsync(int OutPaymentId)
        {
            var result = await UnitOfWork.OutPayments.AnyAsync(c => c.Id == OutPaymentId);
            if (result)
            {
                var OutPayment = await UnitOfWork.OutPayments.GetAsync(c => c.Id == OutPaymentId);
                var OutPaymentUpdateDto = Mapper.Map<OutPaymentUpdateDto>(OutPayment);
                return new DataResult<OutPaymentUpdateDto>(ResultStatus.Success, OutPaymentUpdateDto);
            }
            else
            {
                return new DataResult<OutPaymentUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Ödeme"));
            }
        }
        public async Task<IResult> HardDeleteAsync(int OutPaymentId)
        {
            var payment = await UnitOfWork.OutPayments.GetAsync(c => c.Id == OutPaymentId);
            if (payment != null)
            {
                await UnitOfWork.OutPayments.DeleteAsync(payment);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(payment.AmountPaid.ToString(), "Ödeme", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.NotFound(isPlural: false, "Ödeme"));
        }

        public async Task<IDataResult<int>> CountAsync()
        {
            var OutPaymentsCount = await UnitOfWork.OutPayments.CountAsync();
            if (OutPaymentsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, OutPaymentsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var OutPaymentsCount = await UnitOfWork.OutPayments.CountAsync(c => !c.IsDeleted);
            if (OutPaymentsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, OutPaymentsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<OutPaymentDto>> UndoDeleteAsync(int paymentId, string modifiedByName)
        {
            var payment = await UnitOfWork.OutPayments.GetAsync(c => c.Id == paymentId);
            if (payment != null)
            {
                payment.IsDeleted = false;
                payment.IsActive = true;
                payment.ModifiedByName = modifiedByName;
                payment.ModifiedDate = DateTime.Now;
                var deletedOutPayment = await UnitOfWork.OutPayments.UpdateAsync(payment);
                await UnitOfWork.SaveAsync();
                return new DataResult<OutPaymentDto>(ResultStatus.Success, new OutPaymentDto
                {
                    OutPayment = deletedOutPayment,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.General.GiveMessage(payment.AmountPaid.ToString(), "Ödeme", MessagesConstants.UpdateSuccess)
                }, Messages.General.GiveMessage(payment.AmountPaid.ToString(), "Ödeme", MessagesConstants.UpdateError));
            }
            return new DataResult<OutPaymentDto>(ResultStatus.Error, new OutPaymentDto
            {
                OutPayment = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.General.NotFound(isPlural: false, "Ödeme")
            }, Messages.General.NotFound(isPlural: false, "Ödeme"));
        }
    }
}

