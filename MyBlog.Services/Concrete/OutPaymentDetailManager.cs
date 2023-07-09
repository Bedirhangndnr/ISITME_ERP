using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.OutPaymentDetailDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using MyBlog.Data.Concrete.EntityFramework.Context;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;
using MyBlog.Entities.Dtos.OutPaymentDetailDtos;

namespace MyBlog.Services.Concrete
{
    public class OutPaymentDetailManager:ManagerBase,IOutPaymentDetailService
    {
        private readonly MyBlogContext _dbContext;

        public OutPaymentDetailManager(MyBlogContext dbContext, IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<IDataResult<OutPaymentDetailDto>> GetAsync(int OutPaymentDetailId)
        {
            var OutPaymentDetail = await UnitOfWork.OutPaymentDetails.GetAsync(c => c.Id == OutPaymentDetailId);
            if (OutPaymentDetail != null)
            {
                return new DataResult<OutPaymentDetailDto>(ResultStatus.Success, new OutPaymentDetailDto
                {
                    OutPaymentDetail = OutPaymentDetail,
                });
            }
            return new DataResult<OutPaymentDetailDto>(ResultStatus.Error, new OutPaymentDetailDto
            {
                OutPaymentDetail = null,
            }, Messages.General.NotFound(isPlural: false, "Satış Tipi"));
        }
        public async Task<IDataResult<OutPaymentDetailListDto>> GetAllByNonDeletedAndActiveAsync(int outPaymentId=0)
        {

            IList<OutPaymentDetail> outPaymentDetails;
            if (outPaymentId == 0)
            {
                outPaymentDetails= await UnitOfWork.OutPaymentDetails.GetAllAsync(x => !x.IsDeleted);
            }
            else
            {
                outPaymentDetails = await UnitOfWork.OutPaymentDetails.GetAllAsync(x => !x.IsDeleted && x.OutPaymentId == outPaymentId);
            }
            if (outPaymentDetails.Count > -1)
            {
                return new DataResult<OutPaymentDetailListDto>(ResultStatus.Success, new OutPaymentDetailListDto
                {
                    OutPaymentDetails = outPaymentDetails,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OutPaymentDetailListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Satış Tipi"));

        }
        public async Task<IDataResult<OutPaymentDetailUpdateDto>> GetOutPaymentDetailUpdateDtoAsync(int OutPaymentDetailId)
        {
            var result = await UnitOfWork.OutPaymentDetails.AnyAsync(c => c.Id == OutPaymentDetailId);
            if (result)
            {
                var OutPaymentDetail = await UnitOfWork.OutPaymentDetails.GetAsync(c => c.Id == OutPaymentDetailId);
                var OutPaymentDetailUpdateDto = Mapper.Map<OutPaymentDetailUpdateDto>(OutPaymentDetail);
                return new DataResult<OutPaymentDetailUpdateDto>(ResultStatus.Success, OutPaymentDetailUpdateDto);
            }
            else
            {
                return new DataResult<OutPaymentDetailUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Satış Tipi"));
            }
        }

        public async Task<IDataResult<OutPaymentDetailListDto>> GetAllAsync()
        {
            var OutPaymentDetails = await UnitOfWork.OutPaymentDetails.GetAllAsync(null);
            if (OutPaymentDetails.Count > -1)
            {
                return new DataResult<OutPaymentDetailListDto>(ResultStatus.Success, new OutPaymentDetailListDto
                {
                    OutPaymentDetails = OutPaymentDetails,
                });
            }
            return new DataResult<OutPaymentDetailListDto>(ResultStatus.Error, new OutPaymentDetailListDto
            {
                OutPaymentDetails = null,
            }, Messages.General.NotFound(isPlural: true, "Satış Tipi"));
        }
        public async Task<IDataResult<OutPaymentDetailDto>> AddAsync(OutPaymentDetailAddDto OutPaymentDetailAddDto, string createdByName)
        {
            var outPaymentDetail = Mapper.Map<OutPaymentDetail>(OutPaymentDetailAddDto);

            outPaymentDetail.ModifiedByName = createdByName;
            outPaymentDetail.CreatedByName = createdByName;
            var addedOutPaymentDetail = await UnitOfWork.OutPaymentDetails.AddAsync(outPaymentDetail);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(outPaymentDetail);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<OutPaymentDetailDto>(ResultStatus.Success, new OutPaymentDetailDto
            {
                Message= Messages.General.GiveMessage(addedOutPaymentDetail.CreatedByName, "Satış Tipi", MessagesConstants.AddSuccess),
                OutPaymentDetail = addedOutPaymentDetail,
            }, Messages.General.GiveMessage(addedOutPaymentDetail.CreatedByName, "Satış Tipi", MessagesConstants.AddSuccess));
        }

        public async Task<IDataResult<OutPaymentDetailDto>> UpdateAsync(OutPaymentDetailUpdateDto OutPaymentDetailUpdateDto, string modifiedByName)
        {
            var oldOutPaymentDetail = await UnitOfWork.OutPaymentDetails.GetAsync(c => c.Id == OutPaymentDetailUpdateDto.Id);
            var outPaymentDetail = Mapper.Map<OutPaymentDetailUpdateDto, OutPaymentDetail>(OutPaymentDetailUpdateDto, oldOutPaymentDetail);
            outPaymentDetail.ModifiedByName = modifiedByName;
            var updatedOutPaymentDetail = await UnitOfWork.OutPaymentDetails.UpdateAsync(outPaymentDetail);
            outPaymentDetail = await UnitOfWork.OutPaymentDetails.GetAsync(a => a.Id == OutPaymentDetailUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<OutPaymentDetailDto>(ResultStatus.Success, new OutPaymentDetailDto
            {
                Message= Messages.General.GiveMessage(outPaymentDetail.AmountPaid.ToString(), "Satış Tipi", MessagesConstants.UpdateSuccess),
                OutPaymentDetail = updatedOutPaymentDetail,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(outPaymentDetail.AmountPaid.ToString(), "Satış Tipi", MessagesConstants.UpdateSuccess));
        }
        public async Task<IDataResult<OutPaymentDetailDto>> DeleteAsync(int OutPaymentDetailId, string modifiedByName)
        {
            var outPaymentDetail = await UnitOfWork.OutPaymentDetails.GetAsync(c => c.Id == OutPaymentDetailId);
            if (outPaymentDetail != null)
            {
                outPaymentDetail.IsDeleted = true;
                outPaymentDetail.IsActive = false;
                outPaymentDetail.ModifiedByName = modifiedByName;
                outPaymentDetail.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.OutPaymentDetails.UpdateAsync(outPaymentDetail);
                await UnitOfWork.SaveAsync();
                return new DataResult<OutPaymentDetailDto>(ResultStatus.Success, new OutPaymentDetailDto
                {
                    Message= Messages.General.GiveMessage(outPaymentDetail.AmountPaid.ToString(), "Satış Tipi", MessagesConstants.DeletedSuccess),
                    OutPaymentDetail = deletedEmployeeType
                    
                }, Messages.General.GiveMessage(outPaymentDetail.AmountPaid.ToString(), "Satış Tipi", MessagesConstants.DeletedSuccess));
            }
            return new DataResult<OutPaymentDetailDto>(ResultStatus.Error, new OutPaymentDetailDto
            {
                OutPaymentDetail = null,
            }, Messages.General.GiveMessage(outPaymentDetail.AmountPaid.ToString(), "Satış Tipi", MessagesConstants.UpdateError));
        }
        public async Task<IDataResult<OutPaymentDetailListDto>> GetAllByDeletedAsync()
        {
            var outPaymentDetails = await UnitOfWork.OutPaymentDetails.GetAllAsync(c => c.IsDeleted);
            if (outPaymentDetails.Count > -1)
            {
                return new DataResult<OutPaymentDetailListDto>(ResultStatus.Success, new OutPaymentDetailListDto
                {
                    OutPaymentDetails = outPaymentDetails,
                });
            }
            return new DataResult<OutPaymentDetailListDto>(ResultStatus.Error, new OutPaymentDetailListDto
            {
                OutPaymentDetails = null,
            }, Messages.General.TableNotFound("Satış Tipleri"));
        }
        public async Task<IResult> HardDeleteAsync(int outPaymentDetailId)
        {
            var outPaymentDetail = await UnitOfWork.OutPaymentDetails.GetAsync(c => c.Id == outPaymentDetailId);
            if (outPaymentDetail != null)
            {
                await UnitOfWork.OutPaymentDetails.DeleteAsync(outPaymentDetail);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(outPaymentDetail.AmountPaid.ToString(), "Satış Tipi", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.GiveMessage(outPaymentDetail.AmountPaid.ToString(), "Satış Tipi", MessagesConstants.HardDeletedSuccess));
        }


        public async Task<IDataResult<OutPaymentDetailDto>> UndoDeleteAsync(int outPaymentDetailId, string modifiedByName)
        {
            var outPaymentDetail = await UnitOfWork.OutPaymentDetails.GetAsync(c => c.Id == outPaymentDetailId);
            if (outPaymentDetail != null)
            {
                outPaymentDetail.IsDeleted = false;
                outPaymentDetail.IsActive = true;
                outPaymentDetail.ModifiedByName = modifiedByName;
                outPaymentDetail.ModifiedDate = DateTime.Now;
                var deletedOutPaymentDetail = await UnitOfWork.OutPaymentDetails.UpdateAsync(outPaymentDetail);
                await UnitOfWork.SaveAsync();
                return new DataResult<OutPaymentDetailDto>(ResultStatus.Success, new OutPaymentDetailDto
                {
                    Message = Messages.General.GiveMessage(outPaymentDetail.AmountPaid.ToString(), "Satış Tipi", MessagesConstants.UndoDeletedSuccess),
                    OutPaymentDetail = deletedOutPaymentDetail,
                }, Messages.General.GiveMessage(outPaymentDetail.AmountPaid.ToString(), "Satış Tipi", MessagesConstants.UndoDeletedSuccess));
            }
            return new DataResult<OutPaymentDetailDto>(ResultStatus.Error, new OutPaymentDetailDto
            {
                OutPaymentDetail = null,
            }, Messages.General.GiveMessage(outPaymentDetail.AmountPaid.ToString(), "Satış Tipi", MessagesConstants.UndoDeletedError));
        }
        public async Task<IDataResult<int>> CountAsync()
        {
            var outPaymentDetailsCount = await UnitOfWork.OutPaymentDetails.CountAsync();
            if (outPaymentDetailsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, outPaymentDetailsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var outPaymentDetailsCount = await UnitOfWork.OutPaymentDetails.CountAsync(c => !c.IsDeleted);
            if (outPaymentDetailsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, outPaymentDetailsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }
    }
}
