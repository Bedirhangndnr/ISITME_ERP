using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CustomerReferanceDtos;
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Entities.Dtos.CustomerReferanceDtos;
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
using MyBlog.Entities.Dtos.CustomerReferanceDtos;

namespace MyBlog.Services.Concrete
{
    public class CustomerReferanceManager : ManagerBase, ICustomerReferanceService
    {
        public CustomerReferanceManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<CustomerReferanceDto>> AddAsync(CustomerReferanceAddDto customerReferanceAddDto, string createdByName)
        {
            var addedCustomerReferance = Mapper.Map<CustomerReferance>(customerReferanceAddDto);
            addedCustomerReferance.CreatedByName = createdByName;
            addedCustomerReferance.ModifiedByName = createdByName;
            addedCustomerReferance.Description = "";
            await UnitOfWork.CustomerReferances.AddAsync(addedCustomerReferance);
            await UnitOfWork.SaveAsync();
            return new DataResult<CustomerReferanceDto>(ResultStatus.Success,
                new CustomerReferanceDto
                {
                    CustomerReferance = addedCustomerReferance,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.Category.Add(addedCustomerReferance.FirstName)
                }, Messages.General.GiveMessage(customerReferanceAddDto.FirstName, "Hasta Referansı", "Eklenmiştir."));
        }

        public async Task<IDataResult<CustomerReferanceDto>> GetAsync(int referanceId)
        {
            var customerReferance = await UnitOfWork.CustomerReferances.GetAsync(a => a.Id == referanceId);
            if (customerReferance != null)
            {
                return new DataResult<CustomerReferanceDto>(ResultStatus.Success, new CustomerReferanceDto
                {
                    CustomerReferance = customerReferance
                });
            }
            return new DataResult<CustomerReferanceDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta Referansı"));

        }

        public async Task<IDataResult<CustomerReferanceListDto>> GetAllAsync()
        {
            var customerReferances = await UnitOfWork.CustomerReferances.GetAllAsync(null);
            if (customerReferances.Count > -1)
            {
                return new DataResult<CustomerReferanceListDto>(ResultStatus.Success, new CustomerReferanceListDto
                {
                    CustomerReferances = customerReferances,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CustomerReferanceListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta Referansı"));
        }

       

        public async Task<IDataResult<CustomerReferanceListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var customerReferances = await UnitOfWork.CustomerReferances.GetAllAsync(a => !a.IsDeleted && a.IsActive);
            if (customerReferances.Count > -1)
            {
                return new DataResult<CustomerReferanceListDto>(ResultStatus.Success, new CustomerReferanceListDto
                {
                    CustomerReferances = customerReferances,
                    ResultStatus = ResultStatus.Success,
                });
            }
            return new DataResult<CustomerReferanceListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta Referansı"));
        }

     

        public async Task<IDataResult<CustomerReferanceDto>> UpdateAsync(CustomerReferanceUpdateDto CustomerReferanceUpdateDto, string modifiedByName)
        {
            var oldCustomerReferance = await UnitOfWork.CustomerReferances.GetAsync(a => a.Id == CustomerReferanceUpdateDto.Id);
            var customerReferance = Mapper.Map<CustomerReferanceUpdateDto, CustomerReferance>(CustomerReferanceUpdateDto, oldCustomerReferance);
            customerReferance.ModifiedByName = modifiedByName;
            var updatedReferance = await UnitOfWork.CustomerReferances.UpdateAsync(customerReferance);
            await UnitOfWork.SaveAsync();
            return new DataResult<CustomerReferanceDto>(ResultStatus.Success, new CustomerReferanceDto
            {
                CustomerReferance= updatedReferance,
                ResultStatus = ResultStatus.Success,
                Message = Messages.Category.Update(updatedReferance.FirstName)
            }, Messages.Category.Update(updatedReferance.FirstName));
        }
        public async Task<IDataResult<CustomerReferanceUpdateDto>> GetCustomerReferanceUpdateDtoAsync(int customerReferanceId)
        {
            var result = await UnitOfWork.CustomerReferances.AnyAsync(a => a.Id == customerReferanceId);
            if (result)
            {
                var customerReferance = await UnitOfWork.CustomerReferances.GetAsync(a => a.Id == customerReferanceId);
                var customerReferanceUpdateDto = Mapper.Map<CustomerReferanceUpdateDto>(customerReferance);
                return new DataResult<CustomerReferanceUpdateDto>(ResultStatus.Success, customerReferanceUpdateDto);
            }
            else
            {
                return new DataResult<CustomerReferanceUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Hasta Referansı"));
            }
        }
        public async Task<IDataResult<CustomerReferanceDto>> DeleteAsync(int CustomerReferanceId, string modifiedByName)
        {
            var customerReferance = await UnitOfWork.CustomerReferances.GetAsync(c => c.Id == CustomerReferanceId);
            if (customerReferance != null)
            {
                customerReferance.IsDeleted = true;
                customerReferance.IsActive = false;
                customerReferance.ModifiedByName = modifiedByName;
                customerReferance.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.CustomerReferances.UpdateAsync(customerReferance);
                await UnitOfWork.SaveAsync();
                return new DataResult<CustomerReferanceDto>(ResultStatus.Success, new CustomerReferanceDto
                {
                    CustomerReferance = deletedEmployeeType,
                    Message = Messages.General.GiveMessage(customerReferance.FirstName, "Hasta Referanslarıölk", MessagesConstants.UpdateSuccess)

                }, Messages.General.GiveMessage(customerReferance.FirstName, "Hasta Referanslarıölk", MessagesConstants.UpdateSuccess));
            }
            return new DataResult<CustomerReferanceDto>(ResultStatus.Error, new CustomerReferanceDto
            {
                CustomerReferance = null,
            }, Messages.General.GiveMessage(customerReferance.FirstName, "Hasta Referanslarıölk", "Güncellenemedi."));
        }
        public async Task<IDataResult<CustomerReferanceListDto>> GetAllByDeletedAsync()
        {
            var customerReferances = await UnitOfWork.CustomerReferances.GetAllAsync(c => c.IsDeleted);
            if (customerReferances.Count > -1)
            {
                return new DataResult<CustomerReferanceListDto>(ResultStatus.Success, new CustomerReferanceListDto
                {
                    CustomerReferances = customerReferances,
                });
            }
            return new DataResult<CustomerReferanceListDto>(ResultStatus.Error, new CustomerReferanceListDto
            {
                CustomerReferances = null,
            }, Messages.General.TableNotFound("Hasta Referansları"));
        }
        public async Task<IResult> HardDeleteAsync(int CustomerReferanceId)
        {
            var customerReferance = await UnitOfWork.CustomerReferances.GetAsync(c => c.Id == CustomerReferanceId);
            if (customerReferance != null)
            {
                await UnitOfWork.CustomerReferances.DeleteAsync(customerReferance);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(customerReferance.FirstName, "Hasta Referansı", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.GiveMessage(customerReferance.FirstName, "Hasta Referansı", MessagesConstants.HardDeletedSuccess));
        }


        public async Task<IDataResult<CustomerReferanceDto>> UndoDeleteAsync(int CustomerReferanceId, string modifiedByName)
        {
            var customerReferance = await UnitOfWork.CustomerReferances.GetAsync(c => c.Id == CustomerReferanceId);
            if (customerReferance != null)
            {
                customerReferance.IsDeleted = false;
                customerReferance.IsActive = true;
                customerReferance.ModifiedByName = modifiedByName;
                customerReferance.ModifiedDate = DateTime.Now;
                var deletedCustomerReferance = await UnitOfWork.CustomerReferances.UpdateAsync(customerReferance);
                await UnitOfWork.SaveAsync();
                return new DataResult<CustomerReferanceDto>(ResultStatus.Success, new CustomerReferanceDto
                {
                    Message = Messages.General.GiveMessage(customerReferance.FirstName, "Hasta Referansı", MessagesConstants.UndoDeletedSuccess),
                    CustomerReferance = deletedCustomerReferance,
                }, Messages.General.GiveMessage(customerReferance.FirstName, "Hasta Referansı", MessagesConstants.UndoDeletedSuccess));
            }
            return new DataResult<CustomerReferanceDto>(ResultStatus.Error, new CustomerReferanceDto
            {
                CustomerReferance = null,
            }, Messages.General.GiveMessage(customerReferance.FirstName, "Hasta Referansı", MessagesConstants.UndoDeletedError));
        }
        public async Task<IDataResult<int>> CountAsync()
        {
            var CustomerReferancesCount = await UnitOfWork.CustomerReferances.CountAsync();
            if (CustomerReferancesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, CustomerReferancesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var CustomerReferancesCount = await UnitOfWork.CustomerReferances.CountAsync(c => !c.IsDeleted);
            if (CustomerReferancesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, CustomerReferancesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }
    }
}
