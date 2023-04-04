using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Entities.Dtos.CustomerDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using static MyBlog.Services.Utilities.Messages;

namespace MyBlog.Services.Concrete
{
    public class CustomerManager : ManagerBase, ICustomerService
    {
        public CustomerManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<CustomerDto>> GetAsync(int CustomerId)
        {
            var Customer = await UnitOfWork.Customers.GetAsync(c => c.Id == CustomerId);
            if (Customer != null)
            {
                return new DataResult<CustomerDto>(ResultStatus.Success, new CustomerDto
                {
                    Customer = Customer,
                });
            }
            return new DataResult<CustomerDto>(ResultStatus.Error, new CustomerDto
            {
                Customer = null,
            }, Messages.General.NotFound(isPlural: false, "Müşteri"));
        }
        public async Task<IDataResult<CustomerListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var customers = await UnitOfWork.Customers.GetAllAsync(x => !x.IsDeleted);
            if (customers.Count > -1)
            {
                return new DataResult<CustomerListDto>(ResultStatus.Success, new CustomerListDto
                {
                    Customers = customers,
                    ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<CustomerListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

        }
        public async Task<IDataResult<CustomerListDto>> GetAllForRemainds()
        {
            // çalışanlar arasında kayıt tarihinin ardından 1., 6. 12. aylarının dolmasına ve doğum günlerinin gelmesine 3 gün kalmış kullanıcıları listeleyecek.   
            var today = DateTime.Today;
            var customers = await UnitOfWork.Customers.GetAllForRemaindAsync();
            if (customers.Count > -1)
            {
                return new DataResult<CustomerListDto>(ResultStatus.Success, new CustomerListDto
                {
                    Customers = customers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CustomerListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));
        }
        public async Task<IDataResult<CustomerUpdateDto>> GetCustomerUpdateDtoAsync(int CustomerId)
        {
            var result = await UnitOfWork.Customers.AnyAsync(c => c.Id == CustomerId);
            if (result)
            {
                var Customer = await UnitOfWork.Customers.GetAsync(c => c.Id == CustomerId);
                var CustomerUpdateDto = Mapper.Map<CustomerUpdateDto>(Customer);
                return new DataResult<CustomerUpdateDto>(ResultStatus.Success, CustomerUpdateDto);
            }
            else
            {
                return new DataResult<CustomerUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Hasta"));
            }
        }

        public async Task<IDataResult<CustomerListDto>> GetAllAsync()
        {
            var Customers = await UnitOfWork.Customers.GetAllAsync(null);
            if (Customers.Count > -1)
            {
                return new DataResult<CustomerListDto>(ResultStatus.Success, new CustomerListDto
                {
                    Customers = Customers,
                });
            }
            return new DataResult<CustomerListDto>(ResultStatus.Error, new CustomerListDto
            {
                Customers = null,
            }, Messages.General.NotFound(isPlural: true, "Müşteri"));
        }

        //public async Task<IDataResult<CustomerListDto>> GetAllByDeletedAsync()
        //{
        //    var Customers = await UnitOfWork.Customers.GetAllAsync(c=>c.IsDeleted, c => c.Customer);
        //    if (Customers.Count > -1)
        //    {
        //        return new DataResult<CustomerListDto>(ResultStatus.Success, new CustomerListDto
        //        {
        //            Customers = Customers,
        //        });
        //    }
        //    return new DataResult<CustomerListDto>(ResultStatus.Error, new CustomerListDto
        //    {
        //        Customers = null,
        //    }, Messages.Customer.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<CustomerListDto>> GetAllByNonDeletedAsync()
        //{
        //    var Customers = await UnitOfWork.Customers.GetAllAsync(c => !c.IsDeleted, c => c.Customer);
        //    if (Customers.Count > -1)
        //    {
        //        return new DataResult<CustomerListDto>(ResultStatus.Success, new CustomerListDto
        //        {
        //            Customers = Customers,
        //        });
        //    }
        //    return new DataResult<CustomerListDto>(ResultStatus.Error, new CustomerListDto
        //    {
        //        Customers = null,
        //    }, Messages.Customer.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<CustomerListDto>> GetAllByNonDeletedAndActiveAsync()
        //{
        //    var Customers = await UnitOfWork.Customers.GetAllAsync(c => !c.IsDeleted && c.IsActive);
        //    if (Customers.Count > -1)
        //    {
        //        return new DataResult<CustomerListDto>(ResultStatus.Success, new CustomerListDto
        //        {
        //            Customers = Customers,
        //        });
        //    }
        //    return new DataResult<CustomerListDto>(ResultStatus.Error, new CustomerListDto
        //    {
        //        Customers = null,
        //    }, Messages.General.NotFound(isPlural: true, "Hasta"));
        //}

        public async Task<IResult> AddAsync(CustomerAddDto CustomerAddDto, string createdByName, int userId)
        {
            var customer = Mapper.Map<Customer>(CustomerAddDto);
            customer.CreatedByName = createdByName;
            customer.ModifiedByName = createdByName;
            var addedCustomer = await UnitOfWork.Customers.AddAsync(customer);
            await UnitOfWork.SaveAsync();
            return new DataResult<CustomerDto>(ResultStatus.Success, new CustomerDto
            {
                Customer = addedCustomer,
            }, Messages.General.GiveMessage(CustomerAddDto.FirstName, "hasta", "eklendi."));
        }

        public async Task<IResult> UpdateAsync(CustomerUpdateDto CustomerUpdateDto, string modifiedByName)
        {
            var oldCustomer = await UnitOfWork.Customers.GetAsync(a => a.Id == CustomerUpdateDto.Id);
            var customer = Mapper.Map<CustomerUpdateDto, Customer>(CustomerUpdateDto, oldCustomer);
            customer.ModifiedByName = modifiedByName;
            await UnitOfWork.Customers.UpdateAsync(customer);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.General.GiveMessage(customer.FirstName, "Hasta", "Güncellendi"));
        }

  

        //public async Task<IDataResult<CustomerDto>> DeleteAsync(int CustomerId, string modifiedByName)
        //{
        //    var Customer = await UnitOfWork.Customers.GetAsync(c => c.Id == CustomerId);
        //    if (Customer != null)
        //    {
        //        Customer.IsDeleted = true;
        //        Customer.IsActive = false;
        //        Customer.ModifiedByName = modifiedByName;
        //        Customer.ModifiedDate = DateTime.Now;
        //        var deletedCustomer = await UnitOfWork.Customers.UpdateAsync(Customer);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<CustomerDto>(ResultStatus.Success, new CustomerDto
        //        {
        //            Customer = deletedCustomer,
        //        }, Messages.Customer.Delete(deletedCustomer.CreatedByName));
        //    }
        //    return new DataResult<CustomerDto>(ResultStatus.Error, new CustomerDto
        //    {
        //        Customer = null,
        //    }, Messages.Customer.NotFound(isPlural: false));
        //}

        //public async Task<IResult> HardDeleteAsync(int CustomerId)
        //{
        //    var Customer = await UnitOfWork.Customers.GetAsync(c => c.Id == CustomerId);
        //    if (Customer != null)
        //    {
        //        await UnitOfWork.Customers.DeleteAsync(Customer);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.Customer.HardDelete(Customer.CreatedByName));
        //    }
        //    return new Result(ResultStatus.Error, Messages.Customer.NotFound(isPlural: false));
        //}

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var CustomersCount = await UnitOfWork.Customers.CountAsync();
        //    if (CustomersCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, CustomersCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1,$"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var CustomersCount = await UnitOfWork.Customers.CountAsync(c=>!c.IsDeleted);
        //    if (CustomersCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, CustomersCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<CustomerDto>> ApproveAsync(int CustomerId, string modifiedByName)
        //{
        //    var Customer = await UnitOfWork.Customers.GetAsync(c => c.Id == CustomerId, c => c.Customer);
        //    if (Customer != null)
        //    {
        //        Customer.IsActive = true;
        //        Customer.ModifiedByName = modifiedByName;
        //        Customer.ModifiedDate = DateTime.Now;
        //        var updatedCustomer = await UnitOfWork.Customers.UpdateAsync(Customer);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<CustomerDto>(ResultStatus.Success, new CustomerDto
        //        {
        //            Customer = updatedCustomer
        //        }, Messages.Customer.Approve(CustomerId));
        //    }

        //    return new DataResult<CustomerDto>(ResultStatus.Error, null, Messages.Customer.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<CustomerDto>> UndoDeleteAsync(int CustomerId, string modifiedByName)
        //{
        //    var Customer = await UnitOfWork.Customers.GetAsync(c => c.Id == CustomerId);
        //    if (Customer != null)
        //    {
        //        Customer.IsDeleted = false;
        //        Customer.IsActive = true;
        //        Customer.ModifiedByName = modifiedByName;
        //        Customer.ModifiedDate = DateTime.Now;
        //        var deletedCustomer = await UnitOfWork.Customers.UpdateAsync(Customer);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<CustomerDto>(ResultStatus.Success, new CustomerDto
        //        {
        //            Customer = deletedCustomer,
        //        }, Messages.Customer.UndoDelete(deletedCustomer.CreatedByName));
        //    }
        //    return new DataResult<CustomerDto>(ResultStatus.Error, new CustomerDto
        //    {
        //        Customer = null,
        //    }, Messages.Customer.NotFound(isPlural: false));
        //}
    }
}
