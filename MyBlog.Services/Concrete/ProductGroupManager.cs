﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ProductGroupDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using MyBlog.Data.Concrete.EntityFramework.Context;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;

namespace MyBlog.Services.Concrete
{
    public class ProductGroupManager:ManagerBase,IProductGroupService
    {
        private readonly MyBlogContext _dbContext;

        public ProductGroupManager(MyBlogContext dbContext, IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<IDataResult<ProductGroupDto>> GetAsync(int ProductGroupId)
        {
            var ProductGroup = await UnitOfWork.ProductGroups.GetAsync(c => c.Id == ProductGroupId);
            if (ProductGroup != null)
            {
                return new DataResult<ProductGroupDto>(ResultStatus.Success, new ProductGroupDto
                {
                    ProductGroup = ProductGroup,
                });
            }
            return new DataResult<ProductGroupDto>(ResultStatus.Error, new ProductGroupDto
            {
                ProductGroup = null,
            }, Messages.General.NotFound(isPlural: false, "Hasta"));
        }
        public async Task<IDataResult<ProductGroupListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var customers = await UnitOfWork.ProductGroups.GetAllAsync(x => !x.IsDeleted);
            if (customers.Count > -1)
            {
                return new DataResult<ProductGroupListDto>(ResultStatus.Success, new ProductGroupListDto
                {
                    ProductGroups = customers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductGroupListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

        }
        public async Task<IDataResult<ProductGroupUpdateDto>> GetProductGroupUpdateDtoAsync(int ProductGroupId)
        {
            var result = await UnitOfWork.ProductGroups.AnyAsync(c => c.Id == ProductGroupId);
            if (result)
            {
                var ProductGroup = await UnitOfWork.ProductGroups.GetAsync(c => c.Id == ProductGroupId);
                var ProductGroupUpdateDto = Mapper.Map<ProductGroupUpdateDto>(ProductGroup);
                return new DataResult<ProductGroupUpdateDto>(ResultStatus.Success, ProductGroupUpdateDto);
            }
            else
            {
                return new DataResult<ProductGroupUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Hasta Tipi"));
            }
        }

        public async Task<IDataResult<ProductGroupListDto>> GetAllAsync()
        {
            var ProductGroups = await UnitOfWork.ProductGroups.GetAllAsync(null);
            if (ProductGroups.Count > -1)
            {
                return new DataResult<ProductGroupListDto>(ResultStatus.Success, new ProductGroupListDto
                {
                    ProductGroups = ProductGroups,
                });
            }
            return new DataResult<ProductGroupListDto>(ResultStatus.Error, new ProductGroupListDto
            {
                ProductGroups = null,
            }, Messages.General.NotFound(isPlural: true, "Hasta"));
        }
        public async Task<IDataResult<ProductGroupDto>> AddAsync(ProductGroupAddDto ProductGroupAddDto, string createdByName)
        {
            var productGroup = Mapper.Map<ProductGroup>(ProductGroupAddDto);

            productGroup.CreatedByName = createdByName;
            var addedProductGroup = await UnitOfWork.ProductGroups.AddAsync(productGroup);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(productGroup);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<ProductGroupDto>(ResultStatus.Success, new ProductGroupDto
            {
                ProductGroup = addedProductGroup,
            }, Messages.General.GiveMessage(addedProductGroup.CreatedByName, "Hasta Tipi", "Eklendi"));
        }

        public async Task<IDataResult<ProductGroupDto>> UpdateAsync(ProductGroupUpdateDto ProductGroupUpdateDto, string modifiedByName)
        {
            var oldProductGroup = await UnitOfWork.ProductGroups.GetAsync(c => c.Id == ProductGroupUpdateDto.Id);
            var productGroup = Mapper.Map<ProductGroupUpdateDto, ProductGroup>(ProductGroupUpdateDto, oldProductGroup);
            productGroup.ModifiedByName = modifiedByName;
            var updatedProductGroup = await UnitOfWork.ProductGroups.UpdateAsync(productGroup);
            productGroup = await UnitOfWork.ProductGroups.GetAsync(a => a.Id == ProductGroupUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<ProductGroupDto>(ResultStatus.Success, new ProductGroupDto
            {
                Message= Messages.General.GiveMessage(productGroup.Title, "Hasta Tipi", "Güncellendi."),
                ProductGroup = updatedProductGroup,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(productGroup.Title, "Hasta Tipi", "Güncellendi."));
        }
        public async Task<IDataResult<ProductGroupDto>> DeleteAsync(int ProductGroupId, string modifiedByName)
        {
            var productGroup = await UnitOfWork.ProductGroups.GetAsync(c => c.Id == ProductGroupId);
            if (productGroup != null)
            {
                productGroup.IsDeleted = true;
                productGroup.IsActive = false;
                productGroup.ModifiedByName = modifiedByName;
                productGroup.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.ProductGroups.UpdateAsync(productGroup);
                await UnitOfWork.SaveAsync();
                return new DataResult<ProductGroupDto>(ResultStatus.Success, new ProductGroupDto
                {
                    ProductGroup = deletedEmployeeType
                    
                }, Messages.General.GiveMessage(productGroup.Title, "Hasta Tipi", "Güncellendi."));
            }
            return new DataResult<ProductGroupDto>(ResultStatus.Error, new ProductGroupDto
            {
                ProductGroup = null,
            }, Messages.General.GiveMessage(productGroup.Title, "Hasta Tipi", "Güncellenemedi."));
        }
        //public async Task<IDataResult<ProductGroupListDto>> GetAllByDeletedAsync()
        //{
        //    var ProductGroups = await UnitOfWork.ProductGroups.GetAllAsync(c=>c.IsDeleted, c => c.ProductGroup);
        //    if (ProductGroups.Count > -1)
        //    {
        //        return new DataResult<ProductGroupListDto>(ResultStatus.Success, new ProductGroupListDto
        //        {
        //            ProductGroups = ProductGroups,
        //        });
        //    }
        //    return new DataResult<ProductGroupListDto>(ResultStatus.Error, new ProductGroupListDto
        //    {
        //        ProductGroups = null,
        //    }, Messages.ProductGroup.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<ProductGroupListDto>> GetAllByNonDeletedAsync()
        //{
        //    var ProductGroups = await UnitOfWork.ProductGroups.GetAllAsync(c => !c.IsDeleted, c => c.ProductGroup);
        //    if (ProductGroups.Count > -1)
        //    {
        //        return new DataResult<ProductGroupListDto>(ResultStatus.Success, new ProductGroupListDto
        //        {
        //            ProductGroups = ProductGroups,
        //        });
        //    }
        //    return new DataResult<ProductGroupListDto>(ResultStatus.Error, new ProductGroupListDto
        //    {
        //        ProductGroups = null,
        //    }, Messages.ProductGroup.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<ProductGroupListDto>> GetAllByNonDeletedAndActiveAsync()
        //{
        //    var ProductGroups = await UnitOfWork.ProductGroups.GetAllAsync(c => !c.IsDeleted && c.IsActive);
        //    if (ProductGroups.Count > -1)
        //    {
        //        return new DataResult<ProductGroupListDto>(ResultStatus.Success, new ProductGroupListDto
        //        {
        //            ProductGroups = ProductGroups,
        //        });
        //    }
        //    return new DataResult<ProductGroupListDto>(ResultStatus.Error, new ProductGroupListDto
        //    {
        //        ProductGroups = null,
        //    }, Messages.General.NotFound(isPlural: true, "Hasta"));
        //}



        //public async Task<IDataResult<ProductGroupDto>> DeleteAsync(int ProductGroupId, string modifiedByName)
        //{
        //    var ProductGroup = await UnitOfWork.ProductGroups.GetAsync(c => c.Id == ProductGroupId);
        //    if (ProductGroup != null)
        //    {
        //        ProductGroup.IsDeleted = true;
        //        ProductGroup.IsActive = false;
        //        ProductGroup.ModifiedByName = modifiedByName;
        //        ProductGroup.ModifiedDate = DateTime.Now;
        //        var deletedProductGroup = await UnitOfWork.ProductGroups.UpdateAsync(ProductGroup);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<ProductGroupDto>(ResultStatus.Success, new ProductGroupDto
        //        {
        //            ProductGroup = deletedProductGroup,
        //        }, Messages.ProductGroup.Delete(deletedProductGroup.CreatedByName));
        //    }
        //    return new DataResult<ProductGroupDto>(ResultStatus.Error, new ProductGroupDto
        //    {
        //        ProductGroup = null,
        //    }, Messages.ProductGroup.NotFound(isPlural: false));
        //}

        //public async Task<IResult> HardDeleteAsync(int ProductGroupId)
        //{
        //    var ProductGroup = await UnitOfWork.ProductGroups.GetAsync(c => c.Id == ProductGroupId);
        //    if (ProductGroup != null)
        //    {
        //        await UnitOfWork.ProductGroups.DeleteAsync(ProductGroup);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.ProductGroup.HardDelete(ProductGroup.CreatedByName));
        //    }
        //    return new Result(ResultStatus.Error, Messages.ProductGroup.NotFound(isPlural: false));
        //}

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var ProductGroupsCount = await UnitOfWork.ProductGroups.CountAsync();
        //    if (ProductGroupsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, ProductGroupsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1,$"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var ProductGroupsCount = await UnitOfWork.ProductGroups.CountAsync(c=>!c.IsDeleted);
        //    if (ProductGroupsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, ProductGroupsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<ProductGroupDto>> ApproveAsync(int ProductGroupId, string modifiedByName)
        //{
        //    var ProductGroup = await UnitOfWork.ProductGroups.GetAsync(c => c.Id == ProductGroupId, c => c.ProductGroup);
        //    if (ProductGroup != null)
        //    {
        //        ProductGroup.IsActive = true;
        //        ProductGroup.ModifiedByName = modifiedByName;CustomerType
        //        ProductGroup.ModifiedDate = DateTime.Now;
        //        var updatedProductGroup = await UnitOfWork.ProductGroups.UpdateAsync(ProductGroup);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<ProductGroupDto>(ResultStatus.Success, new ProductGroupDto
        //        {
        //            ProductGroup = updatedProductGroup
        //        }, Messages.ProductGroup.Approve(ProductGroupId));
        //    }

        //    return new DataResult<ProductGroupDto>(ResultStatus.Error, null, Messages.ProductGroup.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<ProductGroupDto>> UndoDeleteAsync(int ProductGroupId, string modifiedByName)
        //{
        //    var ProductGroup = await UnitOfWork.ProductGroups.GetAsync(c => c.Id == ProductGroupId);
        //    if (ProductGroup != null)
        //    {
        //        ProductGroup.IsDeleted = false;
        //        ProductGroup.IsActive = true;
        //        ProductGroup.ModifiedByName = modifiedByName;
        //        ProductGroup.ModifiedDate = DateTime.Now;
        //        var deletedProductGroup = await UnitOfWork.ProductGroups.UpdateAsync(ProductGroup);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<ProductGroupDto>(ResultStatus.Success, new ProductGroupDto
        //        {
        //            ProductGroup = deletedProductGroup,
        //        }, Messages.ProductGroup.UndoDelete(deletedProductGroup.CreatedByName));
        //    }
        //    return new DataResult<ProductGroupDto>(ResultStatus.Error, new ProductGroupDto
        //    {
        //        ProductGroup = null,
        //    }, Messages.ProductGroup.NotFound(isPlural: false));
        //}
    }
}
