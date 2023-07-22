using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.BrandDtos;
using MyBlog.Entities.Dtos.PaymentTypeDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using static MyBlog.Services.Utilities.Messages;

namespace MyBlog.Services.Concrete
{
    public class PaymentTypeManager:ManagerBase,IPaymentTypeService
    {
        public PaymentTypeManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<PaymentTypeDto>> GetAsync(int PaymentTypeId)
        {
            var PaymentType = await UnitOfWork.PaymentTypes.GetAsync(c => c.Id == PaymentTypeId);
            if (PaymentType != null)
            {
                return new DataResult<PaymentTypeDto>(ResultStatus.Success, new PaymentTypeDto
                {
                    PaymentType = PaymentType,
                });
            }
            return new DataResult<PaymentTypeDto>(ResultStatus.Error, new PaymentTypeDto
            {
                PaymentType = null,
            }, Messages.General.NotFound(isPlural: false, "Müşteri"));
        }
        public async Task<IDataResult<PaymentTypeListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var paymentTypes = await UnitOfWork.PaymentTypes.GetAllAsync(x => !x.IsDeleted);
            if (paymentTypes.Count > -1)
            {
                return new DataResult<PaymentTypeListDto>(ResultStatus.Success, new PaymentTypeListDto
                {
                    PaymentTypes = paymentTypes,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PaymentTypeListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

        }
        public async Task<IDataResult<PaymentTypeUpdateDto>> GetPaymentTypeUpdateDtoAsync(int PaymentTypeId)
        {
            var result = await UnitOfWork.PaymentTypes.AnyAsync(c => c.Id == PaymentTypeId);
            if (result)
            {
                var PaymentType = await UnitOfWork.PaymentTypes.GetAsync(c => c.Id == PaymentTypeId);
                var PaymentTypeUpdateDto = Mapper.Map<PaymentTypeUpdateDto>(PaymentType);
                return new DataResult<PaymentTypeUpdateDto>(ResultStatus.Success, PaymentTypeUpdateDto);
            }
            else
            {
                return new DataResult<PaymentTypeUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Hasta"));
            }
        }

        public async Task<IDataResult<PaymentTypeListDto>> GetAllAsync()
        {
            var PaymentTypes = await UnitOfWork.PaymentTypes.GetAllAsync(null);
            if (PaymentTypes.Count > -1)
            {
                return new DataResult<PaymentTypeListDto>(ResultStatus.Success, new PaymentTypeListDto
                {
                    PaymentTypes = PaymentTypes,
                });
            }
            return new DataResult<PaymentTypeListDto>(ResultStatus.Error, new PaymentTypeListDto
            {
                PaymentTypes = null,
            }, Messages.General.NotFound(isPlural: true, "Müşteri"));
        }
        public async Task<IDataResult<PaymentTypeDto>> AddAsync(PaymentTypeAddDto PaymentTypeAddDto, string createdByName)
        {
            var paymentType = Mapper.Map<PaymentType>(PaymentTypeAddDto);

            paymentType.CreatedByName = createdByName;
            var addedPaymentType = await UnitOfWork.PaymentTypes.AddAsync(paymentType);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(paymentType);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<PaymentTypeDto>(ResultStatus.Success, new PaymentTypeDto
            {
                PaymentType = addedPaymentType,
            }, Messages.General.GiveMessage(addedPaymentType.CreatedByName, "Ödeme Tipi", "Eklendi"));
        }

        public async Task<IDataResult<PaymentTypeDto>> UpdateAsync(PaymentTypeUpdateDto PaymentTypeUpdateDto, string modifiedByName)
        {
            var oldPaymentType = await UnitOfWork.PaymentTypes.GetAsync(c => c.Id == PaymentTypeUpdateDto.Id);
            var paymentType = Mapper.Map<PaymentTypeUpdateDto, PaymentType>(PaymentTypeUpdateDto, oldPaymentType);
            paymentType.ModifiedByName = modifiedByName;
            var updatedPaymentType = await UnitOfWork.PaymentTypes.UpdateAsync(paymentType);
            paymentType = await UnitOfWork.PaymentTypes.GetAsync(a => a.Id == PaymentTypeUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<PaymentTypeDto>(ResultStatus.Success, new PaymentTypeDto
            {
                Message = Messages.General.GiveMessage(paymentType.Title, "Ödeme Tipi", "Güncellendi."),
                PaymentType = updatedPaymentType,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(paymentType.Title, "Ödeme Tipi", "Güncellendi."));
        }
        public async Task<IDataResult<PaymentTypeDto>> DeleteAsync(int PaymentTypeId, string modifiedByName)
        {
            var paymentType = await UnitOfWork.PaymentTypes.GetAsync(c => c.Id == PaymentTypeId);
            if (paymentType != null)
            {
                paymentType.IsDeleted = true;
                paymentType.IsActive = false;
                paymentType.ModifiedByName = modifiedByName;
                paymentType.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.PaymentTypes.UpdateAsync(paymentType);
                await UnitOfWork.SaveAsync();
                return new DataResult<PaymentTypeDto>(ResultStatus.Success, new PaymentTypeDto
                {
                    PaymentType = deletedEmployeeType

                }, Messages.General.GiveMessage(paymentType.Title, "Ödeme Tipi", "Güncellendi."));
            }
            return new DataResult<PaymentTypeDto>(ResultStatus.Error, new PaymentTypeDto
            {
                PaymentType = null,
            }, Messages.General.GiveMessage(paymentType.Title, "Ödeme Tipi", "Güncellenemedi."));
        }

        //public async Task<IDataResult<PaymentTypeListDto>> GetAllByDeletedAsync()
        //{
        //    var PaymentTypes = await UnitOfWork.PaymentTypes.GetAllAsync(c=>c.IsDeleted, c => c.PaymentType);
        //    if (PaymentTypes.Count > -1)
        //    {
        //        return new DataResult<PaymentTypeListDto>(ResultStatus.Success, new PaymentTypeListDto
        //        {
        //            PaymentTypes = PaymentTypes,
        //        });
        //    }
        //    return new DataResult<PaymentTypeListDto>(ResultStatus.Error, new PaymentTypeListDto
        //    {
        //        PaymentTypes = null,
        //    }, Messages.PaymentType.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<PaymentTypeListDto>> GetAllByNonDeletedAsync()
        //{
        //    var PaymentTypes = await UnitOfWork.PaymentTypes.GetAllAsync(c => !c.IsDeleted, c => c.PaymentType);
        //    if (PaymentTypes.Count > -1)
        //    {
        //        return new DataResult<PaymentTypeListDto>(ResultStatus.Success, new PaymentTypeListDto
        //        {
        //            PaymentTypes = PaymentTypes,
        //        });
        //    }
        //    return new DataResult<PaymentTypeListDto>(ResultStatus.Error, new PaymentTypeListDto
        //    {
        //        PaymentTypes = null,
        //    }, Messages.PaymentType.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<PaymentTypeListDto>> GetAllByNonDeletedAndActiveAsync()
        //{
        //    var PaymentTypes = await UnitOfWork.PaymentTypes.GetAllAsync(c => !c.IsDeleted && c.IsActive);
        //    if (PaymentTypes.Count > -1)
        //    {
        //        return new DataResult<PaymentTypeListDto>(ResultStatus.Success, new PaymentTypeListDto
        //        {
        //            PaymentTypes = PaymentTypes,
        //        });
        //    }
        //    return new DataResult<PaymentTypeListDto>(ResultStatus.Error, new PaymentTypeListDto
        //    {
        //        PaymentTypes = null,
        //    }, Messages.General.NotFound(isPlural: true, "Hasta"));
        //}

        public async Task<IDataResult<PaymentTypeDto>> AddAsync(PaymentTypeAddDto PaymentTypeAddDto, string createdByName, int userId)
        {
            var customer = Mapper.Map<PaymentType>(PaymentTypeAddDto);
            customer.CreatedByName = createdByName;
            customer.ModifiedByName = createdByName;
            var addedPaymentType = await UnitOfWork.PaymentTypes.AddAsync(customer);
            await UnitOfWork.SaveAsync();
            return new DataResult<PaymentTypeDto>(ResultStatus.Success, new PaymentTypeDto
            {
                PaymentType = addedPaymentType,
            }, Messages.General.GiveMessage(PaymentTypeAddDto.Title,"Başlıklı Ödeme Tipi", "Eklendi."));
        }

  

        //public async Task<IDataResult<PaymentTypeDto>> UpdateAsync(PaymentTypeUpdateDto PaymentTypeUpdateDto, string modifiedByName)
        //{
        //    var oldPaymentType = await UnitOfWork.PaymentTypes.GetAsync(c => c.Id == PaymentTypeUpdateDto.Id);
        //    var PaymentType = Mapper.Map<PaymentTypeUpdateDto, PaymentType>(PaymentTypeUpdateDto, oldPaymentType);
        //    PaymentType.ModifiedByName = modifiedByName;
        //    var updatedPaymentType = await UnitOfWork.PaymentTypes.UpdateAsync(PaymentType);
        //    updatedPaymentType.PaymentType = await UnitOfWork.PaymentTypes.GetAsync(a=>a.Id==PaymentTypeUpdateDto.PaymentTypeId);
        //    await UnitOfWork.SaveAsync();
        //    return new DataResult<PaymentTypeDto>(ResultStatus.Success, new PaymentTypeDto
        //    {
        //        PaymentType = updatedPaymentType,
        //    }, Messages.PaymentType.Update(PaymentType.CreatedByName));
        //}

        //public async Task<IDataResult<PaymentTypeDto>> DeleteAsync(int PaymentTypeId, string modifiedByName)
        //{
        //    var PaymentType = await UnitOfWork.PaymentTypes.GetAsync(c => c.Id == PaymentTypeId);
        //    if (PaymentType != null)
        //    {
        //        PaymentType.IsDeleted = true;
        //        PaymentType.IsActive = false;
        //        PaymentType.ModifiedByName = modifiedByName;
        //        PaymentType.ModifiedDate = DateTime.Now;
        //        var deletedPaymentType = await UnitOfWork.PaymentTypes.UpdateAsync(PaymentType);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<PaymentTypeDto>(ResultStatus.Success, new PaymentTypeDto
        //        {
        //            PaymentType = deletedPaymentType,
        //        }, Messages.PaymentType.Delete(deletedPaymentType.CreatedByName));
        //    }
        //    return new DataResult<PaymentTypeDto>(ResultStatus.Error, new PaymentTypeDto
        //    {
        //        PaymentType = null,
        //    }, Messages.PaymentType.NotFound(isPlural: false));
        //}

        //public async Task<IResult> HardDeleteAsync(int PaymentTypeId)
        //{
        //    var PaymentType = await UnitOfWork.PaymentTypes.GetAsync(c => c.Id == PaymentTypeId);
        //    if (PaymentType != null)
        //    {
        //        await UnitOfWork.PaymentTypes.DeleteAsync(PaymentType);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.PaymentType.HardDelete(PaymentType.CreatedByName));
        //    }
        //    return new Result(ResultStatus.Error, Messages.PaymentType.NotFound(isPlural: false));
        //}

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var PaymentTypesCount = await UnitOfWork.PaymentTypes.CountAsync();
        //    if (PaymentTypesCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, PaymentTypesCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1,$"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var PaymentTypesCount = await UnitOfWork.PaymentTypes.CountAsync(c=>!c.IsDeleted);
        //    if (PaymentTypesCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, PaymentTypesCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<PaymentTypeDto>> ApproveAsync(int PaymentTypeId, string modifiedByName)
        //{
        //    var PaymentType = await UnitOfWork.PaymentTypes.GetAsync(c => c.Id == PaymentTypeId, c => c.PaymentType);
        //    if (PaymentType != null)
        //    {
        //        PaymentType.IsActive = true;
        //        PaymentType.ModifiedByName = modifiedByName;
        //        PaymentType.ModifiedDate = DateTime.Now;
        //        var updatedPaymentType = await UnitOfWork.PaymentTypes.UpdateAsync(PaymentType);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<PaymentTypeDto>(ResultStatus.Success, new PaymentTypeDto
        //        {
        //            PaymentType = updatedPaymentType
        //        }, Messages.PaymentType.Approve(PaymentTypeId));
        //    }

        //    return new DataResult<PaymentTypeDto>(ResultStatus.Error, null, Messages.PaymentType.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<PaymentTypeDto>> UndoDeleteAsync(int PaymentTypeId, string modifiedByName)
        //{
        //    var PaymentType = await UnitOfWork.PaymentTypes.GetAsync(c => c.Id == PaymentTypeId);
        //    if (PaymentType != null)
        //    {
        //        PaymentType.IsDeleted = false;
        //        PaymentType.IsActive = true;
        //        PaymentType.ModifiedByName = modifiedByName;
        //        PaymentType.ModifiedDate = DateTime.Now;
        //        var deletedPaymentType = await UnitOfWork.PaymentTypes.UpdateAsync(PaymentType);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<PaymentTypeDto>(ResultStatus.Success, new PaymentTypeDto
        //        {
        //            PaymentType = deletedPaymentType,
        //        }, Messages.PaymentType.UndoDelete(deletedPaymentType.CreatedByName));
        //    }
        //    return new DataResult<PaymentTypeDto>(ResultStatus.Error, new PaymentTypeDto
        //    {
        //        PaymentType = null,
        //    }, Messages.PaymentType.NotFound(isPlural: false));
        //}
    }
}
