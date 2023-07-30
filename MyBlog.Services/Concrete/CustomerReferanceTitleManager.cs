using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CustomerReferanceTitleDtos;
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Entities.Dtos.CustomerReferanceTitleDtos;
using MyBlog.Entities.Dtos.CustomerTypeDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Dtos.CustomerReferanceTitleDtos;

namespace MyBlog.Services.Concrete
{
    public class CustomerReferanceTitleManager : ManagerBase, ICustomerReferanceTitleService
    {
        public CustomerReferanceTitleManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<CustomerReferanceTitleDto>> AddAsync(CustomerReferanceTitleAddDto customerReferanceUnvanAddDto, string createdByName)
        {
            var addedCustomerReferanceTitle = Mapper.Map<CustomerReferanceTitle>(customerReferanceUnvanAddDto);
            addedCustomerReferanceTitle.CreatedByName = createdByName;
            addedCustomerReferanceTitle.ModifiedByName = createdByName;
            await UnitOfWork.CustomerReferanceTitles.AddAsync(addedCustomerReferanceTitle);
            await UnitOfWork.SaveAsync();
            return new DataResult<CustomerReferanceTitleDto>(ResultStatus.Success,
                new CustomerReferanceTitleDto
                {
                    CustomerReferanceTitle = addedCustomerReferanceTitle,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.Category.Add(addedCustomerReferanceTitle.Title)
                }, Messages.General.GiveMessage(customerReferanceUnvanAddDto.Title, "Hasta Referansı", "Eklenmiştir."));
        }

        public async Task<IDataResult<CustomerReferanceTitleDto>> GetAsync(int referanceTitleId)
        {
            var customerReferanceUnvan = await UnitOfWork.CustomerReferanceTitles.GetAsync(a => a.Id == referanceTitleId);
            if (customerReferanceUnvan != null)
            {
                return new DataResult<CustomerReferanceTitleDto>(ResultStatus.Success, new CustomerReferanceTitleDto
                {
                    CustomerReferanceTitle = customerReferanceUnvan
                });
            }
            return new DataResult<CustomerReferanceTitleDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta Referansı"));

        }

        public async Task<IDataResult<CustomerReferanceTitleListDto>> GetAllAsync()
        {
            var customerReferanceUnvans = await UnitOfWork.CustomerReferanceTitles.GetAllAsync(null);
            if (customerReferanceUnvans.Count > -1)
            {
                return new DataResult<CustomerReferanceTitleListDto>(ResultStatus.Success, new CustomerReferanceTitleListDto
                {
                    CustomerReferanceTitles = customerReferanceUnvans,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CustomerReferanceTitleListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta Referansı"));
        }



        public async Task<IDataResult<CustomerReferanceTitleListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var customerReferanceUnvans = await UnitOfWork.CustomerReferanceTitles.GetAllAsync(a => !a.IsDeleted && a.IsActive);
            if (customerReferanceUnvans.Count > -1)
            {
                return new DataResult<CustomerReferanceTitleListDto>(ResultStatus.Success, new CustomerReferanceTitleListDto
                {
                    CustomerReferanceTitles = customerReferanceUnvans,
                    ResultStatus = ResultStatus.Success,
                });
            }
            return new DataResult<CustomerReferanceTitleListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta Referansı"));
        }



        public async Task<IDataResult<CustomerReferanceTitleDto>> UpdateAsync(CustomerReferanceTitleUpdateDto CustomerReferanceTitleUpdateDto, string modifiedByName)
        {
            var oldCustomerReferanceTitle = await UnitOfWork.CustomerReferanceTitles.GetAsync(a => a.Id == CustomerReferanceTitleUpdateDto.Id);
            var customerReferanceUnvan = Mapper.Map<CustomerReferanceTitleUpdateDto, CustomerReferanceTitle>(CustomerReferanceTitleUpdateDto, oldCustomerReferanceTitle);
            customerReferanceUnvan.ModifiedByName = modifiedByName;
            var updatedReferanceTitle = await UnitOfWork.CustomerReferanceTitles.UpdateAsync(customerReferanceUnvan);
            await UnitOfWork.SaveAsync();
            return new DataResult<CustomerReferanceTitleDto>(ResultStatus.Success, new CustomerReferanceTitleDto
            {
                CustomerReferanceTitle = updatedReferanceTitle,
                ResultStatus = ResultStatus.Success,
                Message = Messages.Category.Update(updatedReferanceTitle.Title)
            }, Messages.Category.Update(updatedReferanceTitle.Title));
        }
        public async Task<IDataResult<CustomerReferanceTitleUpdateDto>> GetCustomerReferanceTitleUpdateDtoAsync(int customerReferanceUnvanId)
        {
            var result = await UnitOfWork.CustomerReferanceTitles.AnyAsync(a => a.Id == customerReferanceUnvanId);
            if (result)
            {
                var customerReferanceUnvan = await UnitOfWork.CustomerReferanceTitles.GetAsync(a => a.Id == customerReferanceUnvanId);
                var customerReferanceUnvanUpdateDto = Mapper.Map<CustomerReferanceTitleUpdateDto>(customerReferanceUnvan);
                return new DataResult<CustomerReferanceTitleUpdateDto>(ResultStatus.Success, customerReferanceUnvanUpdateDto);
            }
            else
            {
                return new DataResult<CustomerReferanceTitleUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Hasta Referansı"));
            }
        }
        public async Task<IDataResult<CustomerReferanceTitleDto>> DeleteAsync(int CustomerReferanceTitleId, string modifiedByName)
        {
            var customerReferanceUnvan = await UnitOfWork.CustomerReferanceTitles.GetAsync(c => c.Id == CustomerReferanceTitleId);
            if (customerReferanceUnvan != null)
            {
                customerReferanceUnvan.IsDeleted = true;
                customerReferanceUnvan.IsActive = false;
                customerReferanceUnvan.ModifiedByName = modifiedByName;
                customerReferanceUnvan.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.CustomerReferanceTitles.UpdateAsync(customerReferanceUnvan);
                await UnitOfWork.SaveAsync();
                return new DataResult<CustomerReferanceTitleDto>(ResultStatus.Success, new CustomerReferanceTitleDto
                {
                    CustomerReferanceTitle = deletedEmployeeType,
                    Message = Messages.General.GiveMessage(customerReferanceUnvan.Title, "Hasta Referanslarıölk", MessagesConstants.UpdateSuccess)

                }, Messages.General.GiveMessage(customerReferanceUnvan.Title, "Hasta Referanslarıölk", MessagesConstants.UpdateSuccess));
            }
            return new DataResult<CustomerReferanceTitleDto>(ResultStatus.Error, new CustomerReferanceTitleDto
            {
                CustomerReferanceTitle = null,
            }, Messages.General.GiveMessage(customerReferanceUnvan.Title, "Hasta Referanslarıölk", "Güncellenemedi."));
        }
        public async Task<IDataResult<CustomerReferanceTitleListDto>> GetAllByDeletedAsync()
        {
            var customerReferanceUnvans = await UnitOfWork.CustomerReferanceTitles.GetAllAsync(c => c.IsDeleted);
            if (customerReferanceUnvans.Count > -1)
            {
                return new DataResult<CustomerReferanceTitleListDto>(ResultStatus.Success, new CustomerReferanceTitleListDto
                {
                    CustomerReferanceTitles = customerReferanceUnvans,
                });
            }
            return new DataResult<CustomerReferanceTitleListDto>(ResultStatus.Error, new CustomerReferanceTitleListDto
            {
                CustomerReferanceTitles = null,
            }, Messages.General.TableNotFound("Hasta Referansları"));
        }
        public async Task<IResult> HardDeleteAsync(int CustomerReferanceTitleId)
        {
            var customerReferanceUnvan = await UnitOfWork.CustomerReferanceTitles.GetAsync(c => c.Id == CustomerReferanceTitleId);
            if (customerReferanceUnvan != null)
            {
                await UnitOfWork.CustomerReferanceTitles.DeleteAsync(customerReferanceUnvan);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(customerReferanceUnvan.Title, "Hasta Referansı", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.GiveMessage(customerReferanceUnvan.Title, "Hasta Referansı", MessagesConstants.HardDeletedSuccess));
        }


        public async Task<IDataResult<CustomerReferanceTitleDto>> UndoDeleteAsync(int CustomerReferanceTitleId, string modifiedByName)
        {
            var customerReferanceUnvan = await UnitOfWork.CustomerReferanceTitles.GetAsync(c => c.Id == CustomerReferanceTitleId);
            if (customerReferanceUnvan != null)
            {
                customerReferanceUnvan.IsDeleted = false;
                customerReferanceUnvan.IsActive = true;
                customerReferanceUnvan.ModifiedByName = modifiedByName;
                customerReferanceUnvan.ModifiedDate = DateTime.Now;
                var deletedCustomerReferanceTitle = await UnitOfWork.CustomerReferanceTitles.UpdateAsync(customerReferanceUnvan);
                await UnitOfWork.SaveAsync();
                return new DataResult<CustomerReferanceTitleDto>(ResultStatus.Success, new CustomerReferanceTitleDto
                {
                    Message = Messages.General.GiveMessage(customerReferanceUnvan.Title, "Hasta Referansı", MessagesConstants.UndoDeletedSuccess),
                    CustomerReferanceTitle = deletedCustomerReferanceTitle,
                }, Messages.General.GiveMessage(customerReferanceUnvan.Title, "Hasta Referansı", MessagesConstants.UndoDeletedSuccess));
            }
            return new DataResult<CustomerReferanceTitleDto>(ResultStatus.Error, new CustomerReferanceTitleDto
            {
                CustomerReferanceTitle = null,
            }, Messages.General.GiveMessage(customerReferanceUnvan.Title, "Hasta Referansı", MessagesConstants.UndoDeletedError));
        }
        public async Task<IDataResult<int>> CountAsync()
        {
            var CustomerReferanceTitlesCount = await UnitOfWork.CustomerReferanceTitles.CountAsync();
            if (CustomerReferanceTitlesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, CustomerReferanceTitlesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var CustomerReferanceTitlesCount = await UnitOfWork.CustomerReferanceTitles.CountAsync(c => !c.IsDeleted);
            if (CustomerReferanceTitlesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, CustomerReferanceTitlesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }
    }
}
