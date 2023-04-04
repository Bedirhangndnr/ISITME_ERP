using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
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

        //public async Task<IDataResult<CustomerReferanceListDto>> GetAllByCategoryAsync(int categoryId)
        //{
        //    var ısAnyCategory = await UnitOfWork.Categories.AnyAsync(c=>c.Id==categoryId);
        //    if (ısAnyCategory)
        //    {
        //        var customerReferances = await UnitOfWork.CustomerReferances.GetAllAsync(a => a.CategoryId == categoryId && !a.IsDeleted && a.IsActive, a => a.User, a => a.Category);
        //        if (customerReferances.Count > -1)
        //        {
        //            return new DataResult<CustomerReferanceListDto>(ResultStatus.Success, new CustomerReferanceListDto
        //            {
        //                CustomerReferances = customerReferances,
        //                ResultStatus = ResultStatus.Success,
        //            });
        //        }
        //        return new DataResult<CustomerReferanceListDto>(ResultStatus.Error, null, Messages.CustomerReferance.NotFound(false));
        //    }
        //    return new DataResult<CustomerReferanceListDto>(ResultStatus.Error, null, Messages.CustomerReferance.NotFound(false));
        //}

        //public async Task<IDataResult<CustomerReferanceListDto>> GetAllByNonDeletedAsync()
        //{
        //    var customerReferances = await UnitOfWork.CustomerReferances.GetAllAsync(a => !a.IsDeleted, a => a.User, a => a.Category);
        //    if (customerReferances.Count > -1)
        //    {
        //        return new DataResult<CustomerReferanceListDto>(ResultStatus.Success, new CustomerReferanceListDto
        //        {
        //            CustomerReferances = customerReferances,
        //            ResultStatus = ResultStatus.Success,
        //        });
        //    }
        //    return new DataResult<CustomerReferanceListDto>(ResultStatus.Error, null, Messages.CustomerReferance.NotFound(false));
        //}

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

        //public Task<IDataResult<IList<CustomerReferance>>> GetAll_Generic(CustomerReferance t)
        //{
        //    throw new NotImplementedException();
        //}
        //public async Task<IResult> DeleteAsync(int customerReferanceId, string modifiedByName)
        //{
        //    var value=await UnitOfWork.CustomerReferances.AnyAsync(x=>x.Id==customerReferanceId);
        //    if (value)
        //    {
        //        var customerReferance = await UnitOfWork.CustomerReferances.GetAsync(a => a.Id == customerReferanceId);
        //        customerReferance.IsDeleted = true;
        //        customerReferance.ModifiedByName=modifiedByName;
        //        customerReferance.ModifiedDate=DateTime.Now;
        //        await UnitOfWork.CustomerReferances.UpdateAsync(customerReferance).ContinueWith(t => UnitOfWork.SaveAsync());
        //        return new Result(resultStatus: ResultStatus.Success, Messages.CustomerReferance.Update(customerReferance.Title));
        //    }
        //    return new Result(resultStatus: ResultStatus.Error, Messages.CustomerReferance.NotFound(false));
        //}
        //public async Task<IResult> HardDeleteAsync(int customerReferanceId)
        //{
        //    var value = await UnitOfWork.CustomerReferances.AnyAsync(x => x.Id == customerReferanceId);
        //    string customerReferanceName;
        //    if (value)
        //    {
        //        var customerReferance = await UnitOfWork.CustomerReferances.GetAsync(a => a.Id == customerReferanceId);
        //        customerReferanceName = customerReferance.Title;
        //        await UnitOfWork.CustomerReferances.DeleteAsync(customerReferance).ContinueWith(t => UnitOfWork.SaveAsync());
        //        return new Result(resultStatus: ResultStatus.Success, Messages.CustomerReferance.Delete(customerReferanceName));
        //    }
        //    return new Result(resultStatus: ResultStatus.Error, Messages.CustomerReferance.NotFound(false));
        //}

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

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var customerReferancesCount = await UnitOfWork.CustomerReferances.CountAsync();
        //    if (customerReferancesCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, customerReferancesCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, Messages.General.UnKnownError());
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var customerReferancesCount = await UnitOfWork.CustomerReferances.CountAsync(x=>!x.IsDeleted);
        //    if (customerReferancesCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, customerReferancesCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, Messages.General.UnKnownError());
        //    }
        //}



        //public async Task<IResult> UndoDeleteAsync(int customerReferanceId, string modifiedByName)
        //{
        //    var result = await UnitOfWork.CustomerReferances.AnyAsync(a => a.Id == customerReferanceId);
        //    if (result)
        //    {
        //        var customerReferance = await UnitOfWork.CustomerReferances.GetAsync(a => a.Id == customerReferanceId);
        //        customerReferance.IsDeleted = false;
        //        customerReferance.IsActive = true;
        //        customerReferance.ModifiedByName = modifiedByName;
        //        customerReferance.ModifiedDate = DateTime.Now;
        //        await UnitOfWork.CustomerReferances.UpdateAsync(customerReferance);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.CustomerReferance.UndoDelete(customerReferance.Title));
        //    }
        //    return new Result(ResultStatus.Error, Messages.CustomerReferance.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<CustomerReferanceListDto>> GetAllByDeletedAsync()
        //{
        //    var customerReferances =
        //        await UnitOfWork.CustomerReferances.GetAllAsync(a => a.IsDeleted, ar => ar.User,
        //            ar => ar.Category);
        //    if (customerReferances.Count > -1)
        //    {
        //        return new DataResult<CustomerReferanceListDto>(ResultStatus.Success, new CustomerReferanceListDto
        //        {
        //            CustomerReferances = customerReferances,
        //            ResultStatus = ResultStatus.Success
        //        });
        //    }
        //    return new DataResult<CustomerReferanceListDto>(ResultStatus.Error, null, Messages.CustomerReferance.NotFound(isPlural: true));
        //}

    }
}
