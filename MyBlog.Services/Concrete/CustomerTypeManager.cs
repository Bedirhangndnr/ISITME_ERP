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
using MyBlog.Entities.Dtos.CustomerTypeDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using MyBlog.Data.Concrete.EntityFramework.Context;

namespace MyBlog.Services.Concrete
{
    public class CustomerTypeManager:ManagerBase,ICustomerTypeService
    {
        private readonly MyBlogContext _dbContext;

        public CustomerTypeManager(MyBlogContext dbContext, IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<IDataResult<CustomerTypeDto>> GetAsync(int CustomerTypeId)
        {
            var CustomerType = await UnitOfWork.CustomerTypes.GetAsync(c => c.Id == CustomerTypeId);
            if (CustomerType != null)
            {
                return new DataResult<CustomerTypeDto>(ResultStatus.Success, new CustomerTypeDto
                {
                    CustomerType = CustomerType,
                });
            }
            return new DataResult<CustomerTypeDto>(ResultStatus.Error, new CustomerTypeDto
            {
                CustomerType = null,
            }, Messages.General.NotFound(isPlural: false, "Hasta"));
        }
        public async Task<IDataResult<CustomerTypeListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var customers = await UnitOfWork.CustomerTypes.GetAllAsync(x => !x.IsDeleted);
            if (customers.Count > -1)
            {
                return new DataResult<CustomerTypeListDto>(ResultStatus.Success, new CustomerTypeListDto
                {
                    CustomerTypes = customers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CustomerTypeListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

        }
        public async Task<IDataResult<CustomerTypeUpdateDto>> GetCustomerTypeUpdateDtoAsync(int CustomerTypeId)
        {
            var result = await UnitOfWork.CustomerTypes.AnyAsync(c => c.Id == CustomerTypeId);
            if (result)
            {
                var CustomerType = await UnitOfWork.CustomerTypes.GetAsync(c => c.Id == CustomerTypeId);
                var CustomerTypeUpdateDto = Mapper.Map<CustomerTypeUpdateDto>(CustomerType);
                return new DataResult<CustomerTypeUpdateDto>(ResultStatus.Success, CustomerTypeUpdateDto);
            }
            else
            {
                return new DataResult<CustomerTypeUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Hasta Tipi"));
            }
        }

        public async Task<IDataResult<CustomerTypeListDto>> GetAllAsync()
        {
            var CustomerTypes = await UnitOfWork.CustomerTypes.GetAllAsync(null);
            if (CustomerTypes.Count > -1)
            {
                return new DataResult<CustomerTypeListDto>(ResultStatus.Success, new CustomerTypeListDto
                {
                    CustomerTypes = CustomerTypes,
                });
            }
            return new DataResult<CustomerTypeListDto>(ResultStatus.Error, new CustomerTypeListDto
            {
                CustomerTypes = null,
            }, Messages.General.NotFound(isPlural: true, "Hasta"));
        }
        public async Task<IDataResult<CustomerTypeDto>> AddAsync(CustomerTypeAddDto CustomerTypeAddDto, string createdByName)
        {
            var customerType = Mapper.Map<CustomerType>(CustomerTypeAddDto);

            customerType.CreatedByName = createdByName;
            var addedCustomerType = await UnitOfWork.CustomerTypes.AddAsync(customerType);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(customerType);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<CustomerTypeDto>(ResultStatus.Success, new CustomerTypeDto
            {
                CustomerType = addedCustomerType,
            }, Messages.General.GiveMessage(addedCustomerType.CreatedByName, "Hasta Tipi", "Eklendi"));
        }

        public async Task<IDataResult<CustomerTypeDto>> UpdateAsync(CustomerTypeUpdateDto CustomerTypeUpdateDto, string modifiedByName)
        {
            var oldCustomerType = await UnitOfWork.CustomerTypes.GetAsync(c => c.Id == CustomerTypeUpdateDto.Id);
            var customerType = Mapper.Map<CustomerTypeUpdateDto, CustomerType>(CustomerTypeUpdateDto, oldCustomerType);
            customerType.ModifiedByName = modifiedByName;
            var updatedCustomerType = await UnitOfWork.CustomerTypes.UpdateAsync(customerType);
            customerType = await UnitOfWork.CustomerTypes.GetAsync(a => a.Id == CustomerTypeUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<CustomerTypeDto>(ResultStatus.Success, new CustomerTypeDto
            {
                Message= Messages.General.GiveMessage(customerType.Title, "Hasta Tipi", "Güncellendi."),
                CustomerType = updatedCustomerType,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(customerType.Title, "Hasta Tipi", "Güncellendi."));
        }

        //public async Task<IDataResult<CustomerTypeListDto>> GetAllByDeletedAsync()
        //{
        //    var CustomerTypes = await UnitOfWork.CustomerTypes.GetAllAsync(c=>c.IsDeleted, c => c.CustomerType);
        //    if (CustomerTypes.Count > -1)
        //    {
        //        return new DataResult<CustomerTypeListDto>(ResultStatus.Success, new CustomerTypeListDto
        //        {
        //            CustomerTypes = CustomerTypes,
        //        });
        //    }
        //    return new DataResult<CustomerTypeListDto>(ResultStatus.Error, new CustomerTypeListDto
        //    {
        //        CustomerTypes = null,
        //    }, Messages.CustomerType.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<CustomerTypeListDto>> GetAllByNonDeletedAsync()
        //{
        //    var CustomerTypes = await UnitOfWork.CustomerTypes.GetAllAsync(c => !c.IsDeleted, c => c.CustomerType);
        //    if (CustomerTypes.Count > -1)
        //    {
        //        return new DataResult<CustomerTypeListDto>(ResultStatus.Success, new CustomerTypeListDto
        //        {
        //            CustomerTypes = CustomerTypes,
        //        });
        //    }
        //    return new DataResult<CustomerTypeListDto>(ResultStatus.Error, new CustomerTypeListDto
        //    {
        //        CustomerTypes = null,
        //    }, Messages.CustomerType.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<CustomerTypeListDto>> GetAllByNonDeletedAndActiveAsync()
        //{
        //    var CustomerTypes = await UnitOfWork.CustomerTypes.GetAllAsync(c => !c.IsDeleted && c.IsActive);
        //    if (CustomerTypes.Count > -1)
        //    {
        //        return new DataResult<CustomerTypeListDto>(ResultStatus.Success, new CustomerTypeListDto
        //        {
        //            CustomerTypes = CustomerTypes,
        //        });
        //    }
        //    return new DataResult<CustomerTypeListDto>(ResultStatus.Error, new CustomerTypeListDto
        //    {
        //        CustomerTypes = null,
        //    }, Messages.General.NotFound(isPlural: true, "Hasta"));
        //}



        //public async Task<IDataResult<CustomerTypeDto>> DeleteAsync(int CustomerTypeId, string modifiedByName)
        //{
        //    var CustomerType = await UnitOfWork.CustomerTypes.GetAsync(c => c.Id == CustomerTypeId);
        //    if (CustomerType != null)
        //    {
        //        CustomerType.IsDeleted = true;
        //        CustomerType.IsActive = false;
        //        CustomerType.ModifiedByName = modifiedByName;
        //        CustomerType.ModifiedDate = DateTime.Now;
        //        var deletedCustomerType = await UnitOfWork.CustomerTypes.UpdateAsync(CustomerType);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<CustomerTypeDto>(ResultStatus.Success, new CustomerTypeDto
        //        {
        //            CustomerType = deletedCustomerType,
        //        }, Messages.CustomerType.Delete(deletedCustomerType.CreatedByName));
        //    }
        //    return new DataResult<CustomerTypeDto>(ResultStatus.Error, new CustomerTypeDto
        //    {
        //        CustomerType = null,
        //    }, Messages.CustomerType.NotFound(isPlural: false));
        //}

        //public async Task<IResult> HardDeleteAsync(int CustomerTypeId)
        //{
        //    var CustomerType = await UnitOfWork.CustomerTypes.GetAsync(c => c.Id == CustomerTypeId);
        //    if (CustomerType != null)
        //    {
        //        await UnitOfWork.CustomerTypes.DeleteAsync(CustomerType);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.CustomerType.HardDelete(CustomerType.CreatedByName));
        //    }
        //    return new Result(ResultStatus.Error, Messages.CustomerType.NotFound(isPlural: false));
        //}

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var CustomerTypesCount = await UnitOfWork.CustomerTypes.CountAsync();
        //    if (CustomerTypesCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, CustomerTypesCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1,$"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var CustomerTypesCount = await UnitOfWork.CustomerTypes.CountAsync(c=>!c.IsDeleted);
        //    if (CustomerTypesCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, CustomerTypesCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<CustomerTypeDto>> ApproveAsync(int CustomerTypeId, string modifiedByName)
        //{
        //    var CustomerType = await UnitOfWork.CustomerTypes.GetAsync(c => c.Id == CustomerTypeId, c => c.CustomerType);
        //    if (CustomerType != null)
        //    {
        //        CustomerType.IsActive = true;
        //        CustomerType.ModifiedByName = modifiedByName;
        //        CustomerType.ModifiedDate = DateTime.Now;
        //        var updatedCustomerType = await UnitOfWork.CustomerTypes.UpdateAsync(CustomerType);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<CustomerTypeDto>(ResultStatus.Success, new CustomerTypeDto
        //        {
        //            CustomerType = updatedCustomerType
        //        }, Messages.CustomerType.Approve(CustomerTypeId));
        //    }

        //    return new DataResult<CustomerTypeDto>(ResultStatus.Error, null, Messages.CustomerType.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<CustomerTypeDto>> UndoDeleteAsync(int CustomerTypeId, string modifiedByName)
        //{
        //    var CustomerType = await UnitOfWork.CustomerTypes.GetAsync(c => c.Id == CustomerTypeId);
        //    if (CustomerType != null)
        //    {
        //        CustomerType.IsDeleted = false;
        //        CustomerType.IsActive = true;
        //        CustomerType.ModifiedByName = modifiedByName;
        //        CustomerType.ModifiedDate = DateTime.Now;
        //        var deletedCustomerType = await UnitOfWork.CustomerTypes.UpdateAsync(CustomerType);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<CustomerTypeDto>(ResultStatus.Success, new CustomerTypeDto
        //        {
        //            CustomerType = deletedCustomerType,
        //        }, Messages.CustomerType.UndoDelete(deletedCustomerType.CreatedByName));
        //    }
        //    return new DataResult<CustomerTypeDto>(ResultStatus.Error, new CustomerTypeDto
        //    {
        //        CustomerType = null,
        //    }, Messages.CustomerType.NotFound(isPlural: false));
        //}
    }
}
