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
using MyBlog.Entities.Dtos.ProductSubGroupDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using MyBlog.Data.Concrete.EntityFramework.Context;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;
using MyBlog.Entities.Dtos.ProductSubGroupDtos;

namespace MyBlog.Services.Concrete
{
    public class ProductSubGroupManager:ManagerBase,IProductSubGroupService
    {
        private readonly MyBlogContext _dbContext;

        public ProductSubGroupManager(MyBlogContext dbContext, IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<IDataResult<ProductSubGroupDto>> GetAsync(int ProductSubGroupId)
        {
            var ProductSubGroup = await UnitOfWork.ProductSubGroups.GetAsync(c => c.Id == ProductSubGroupId);
            if (ProductSubGroup != null)
            {
                return new DataResult<ProductSubGroupDto>(ResultStatus.Success, new ProductSubGroupDto
                {
                    ProductSubGroup = ProductSubGroup,
                });
            }
            return new DataResult<ProductSubGroupDto>(ResultStatus.Error, new ProductSubGroupDto
            {
                ProductSubGroup = null,
            }, Messages.General.NotFound(isPlural: false, "Hasta"));
        }
        public async Task<IDataResult<ProductSubGroupListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var customers = await UnitOfWork.ProductSubGroups.GetAllAsync(x => !x.IsDeleted);
            if (customers.Count > -1)
            {
                return new DataResult<ProductSubGroupListDto>(ResultStatus.Success, new ProductSubGroupListDto
                {
                    ProductSubGroups = customers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductSubGroupListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

        }
        public async Task<IDataResult<ProductSubGroupUpdateDto>> GetProductSubGroupUpdateDtoAsync(int ProductSubGroupId)
        {
            var result = await UnitOfWork.ProductSubGroups.AnyAsync(c => c.Id == ProductSubGroupId);
            if (result)
            {
                var ProductSubGroup = await UnitOfWork.ProductSubGroups.GetAsync(c => c.Id == ProductSubGroupId);
                var ProductSubGroupUpdateDto = Mapper.Map<ProductSubGroupUpdateDto>(ProductSubGroup);
                return new DataResult<ProductSubGroupUpdateDto>(ResultStatus.Success, ProductSubGroupUpdateDto);
            }
            else
            {
                return new DataResult<ProductSubGroupUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Ürün Alt Grubu"));
            }
        }

        public async Task<IDataResult<ProductSubGroupListDto>> GetAllAsync()
        {
            var ProductSubGroups = await UnitOfWork.ProductSubGroups.GetAllAsync(null);
            if (ProductSubGroups.Count > -1)
            {
                return new DataResult<ProductSubGroupListDto>(ResultStatus.Success, new ProductSubGroupListDto
                {
                    ProductSubGroups = ProductSubGroups,
                });
            }
            return new DataResult<ProductSubGroupListDto>(ResultStatus.Error, new ProductSubGroupListDto
            {
                ProductSubGroups = null,
            }, Messages.General.NotFound(isPlural: true, "Hasta"));
        }
        public async Task<IDataResult<ProductSubGroupDto>> AddAsync(ProductSubGroupAddDto ProductSubGroupAddDto, string createdByName)
        {
            var productSubGroup = Mapper.Map<ProductSubGroup>(ProductSubGroupAddDto);

            productSubGroup.ModifiedByName = createdByName;
            productSubGroup.CreatedByName = createdByName;
            var addedProductSubGroup = await UnitOfWork.ProductSubGroups.AddAsync(productSubGroup);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(productSubGroup);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<ProductSubGroupDto>(ResultStatus.Success, new ProductSubGroupDto
            {
                Message=Messages.General.GiveMessage(addedProductSubGroup.CreatedByName, "Ürün Alt Grubu", MessagesConstants.AddSuccess),
                ProductSubGroup = addedProductSubGroup,
            }, Messages.General.GiveMessage(addedProductSubGroup.CreatedByName, "Ürün Alt Grubu", MessagesConstants.AddSuccess));
        }

        public async Task<IDataResult<ProductSubGroupDto>> UpdateAsync(ProductSubGroupUpdateDto ProductSubGroupUpdateDto, string modifiedByName)
        {
            var oldProductSubGroup = await UnitOfWork.ProductSubGroups.GetAsync(c => c.Id == ProductSubGroupUpdateDto.Id);
            var productSubGroup = Mapper.Map<ProductSubGroupUpdateDto, ProductSubGroup>(ProductSubGroupUpdateDto, oldProductSubGroup);
            productSubGroup.ModifiedByName = modifiedByName;
            var updatedProductSubGroup = await UnitOfWork.ProductSubGroups.UpdateAsync(productSubGroup);
            productSubGroup = await UnitOfWork.ProductSubGroups.GetAsync(a => a.Id == ProductSubGroupUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<ProductSubGroupDto>(ResultStatus.Success, new ProductSubGroupDto
            {
                Message= Messages.General.GiveMessage(productSubGroup.Title, "Ürün Alt Grubu", MessagesConstants.UpdateSuccess),
                ProductSubGroup = updatedProductSubGroup,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(productSubGroup.Title, "Ürün Alt Grubu", MessagesConstants.UpdateSuccess));
        }
        public async Task<IDataResult<ProductSubGroupDto>> DeleteAsync(int ProductSubGroupId, string modifiedByName)
        {
            var productSubGroup = await UnitOfWork.ProductSubGroups.GetAsync(c => c.Id == ProductSubGroupId);
            if (productSubGroup != null)
            {
                productSubGroup.IsDeleted = true;
                //productSubGroup.IsActive = false;
                productSubGroup.ModifiedByName = modifiedByName;
                productSubGroup.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.ProductSubGroups.UpdateAsync(productSubGroup);
                await UnitOfWork.SaveAsync();
                return new DataResult<ProductSubGroupDto>(ResultStatus.Success, new ProductSubGroupDto
                {
                Message=Messages.General.GiveMessage(productSubGroup.Title, "Ürün Alt Grubu", MessagesConstants.AddSuccess),
                    ProductSubGroup = deletedEmployeeType

                }, Messages.General.GiveMessage(productSubGroup.Title, "Ürün Alt Grubu", MessagesConstants.UpdateSuccess));
            }
            return new DataResult<ProductSubGroupDto>(ResultStatus.Error, new ProductSubGroupDto
            {
                ProductSubGroup = null,
            }, Messages.General.GiveMessage(productSubGroup.Title, "Ürün Alt Grubu", MessagesConstants.UpdateError));
        }
        public async Task<IDataResult<ProductSubGroupListDto>> GetAllByDeletedAsync()
        {
            var ProductSubGroups = await UnitOfWork.ProductSubGroups.GetAllAsync(c => c.IsDeleted);
            if (ProductSubGroups.Count > -1)
            {
                return new DataResult<ProductSubGroupListDto>(ResultStatus.Success, new ProductSubGroupListDto
                {
                    ProductSubGroups = ProductSubGroups,
                });
            }
            return new DataResult<ProductSubGroupListDto>(ResultStatus.Error, new ProductSubGroupListDto
            {
                ProductSubGroups = null,
            }, Messages.General.TableNotFound("Ürün Alt Grupları"));
        }
        public async Task<IResult> HardDeleteAsync(int ProductSubGroupId)
        {
            var ProductSubGroup = await UnitOfWork.ProductSubGroups.GetAsync(c => c.Id == ProductSubGroupId);
            if (ProductSubGroup != null)
            {
                await UnitOfWork.ProductSubGroups.DeleteAsync(ProductSubGroup);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(ProductSubGroup.Title, "Ürün Alt Grubu", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.GiveMessage(ProductSubGroup.Title, "Ürün Alt Grubu", MessagesConstants.HardDeletedSuccess));
        }


        public async Task<IDataResult<ProductSubGroupDto>> UndoDeleteAsync(int ProductSubGroupId, string modifiedByName)
        {
            var ProductSubGroup = await UnitOfWork.ProductSubGroups.GetAsync(c => c.Id == ProductSubGroupId);
            if (ProductSubGroup != null)
            {
                ProductSubGroup.IsDeleted = false;
                ProductSubGroup.IsActive = true;
                ProductSubGroup.ModifiedByName = modifiedByName;
                ProductSubGroup.ModifiedDate = DateTime.Now;
                var deletedProductSubGroup = await UnitOfWork.ProductSubGroups.UpdateAsync(ProductSubGroup);
                await UnitOfWork.SaveAsync();
                return new DataResult<ProductSubGroupDto>(ResultStatus.Success, new ProductSubGroupDto
                {
                    Message = Messages.General.GiveMessage(ProductSubGroup.Title, "Ürün Alt Grubu", MessagesConstants.UndoDeletedSuccess),
                    ProductSubGroup = deletedProductSubGroup,
                }, Messages.General.GiveMessage(ProductSubGroup.Title, "Ürün Alt Grubu", MessagesConstants.UndoDeletedSuccess));
            }
            return new DataResult<ProductSubGroupDto>(ResultStatus.Error, new ProductSubGroupDto
            {
                ProductSubGroup = null,
            }, Messages.General.GiveMessage(ProductSubGroup.Title, "Ürün Alt Grubu", MessagesConstants.UndoDeletedError));
        }
        public async Task<IDataResult<int>> CountAsync()
        {
            var ProductSubGroupsCount = await UnitOfWork.ProductSubGroups.CountAsync();
            if (ProductSubGroupsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, ProductSubGroupsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var ProductSubGroupsCount = await UnitOfWork.ProductSubGroups.CountAsync(c => !c.IsDeleted);
            if (ProductSubGroupsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, ProductSubGroupsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }
    }
}
