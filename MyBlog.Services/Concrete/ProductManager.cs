using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ProductDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using static MyBlog.Services.Utilities.Messages;

namespace MyBlog.Services.Concrete
{
    public class ProductManager : ManagerBase, IProductService
    {
        public ProductManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<ProductDto>> GetAsync(int ProductId)
        {
            var product = await UnitOfWork.Products.GetAsync(c => c.Id == ProductId);
            if (product != null)
            {
                return new DataResult<ProductDto>(ResultStatus.Success, new ProductDto
                {
                    Product = product,
                });
            }
            return new DataResult<ProductDto>(ResultStatus.Error, new ProductDto
            {
                Product = null,
            }, Messages.General.NotFound(isPlural: false, "Çalışan"));
        }
        public async Task<IDataResult<ProductUpdateDto>> GetProductUpdateDtoAsync(int ProductId)
        {
            var result = await UnitOfWork.Products.AnyAsync(c => c.Id == ProductId);
            if (result)
            {
                var Product = await UnitOfWork.Products.GetAsync(c => c.Id == ProductId);
                var ProductUpdateDto = Mapper.Map<ProductUpdateDto>(Product);
                return new DataResult<ProductUpdateDto>(ResultStatus.Success, ProductUpdateDto);
            }
            else
            {
                return new DataResult<ProductUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Çalışan"));
            }
        }

        public async Task<IDataResult<ProductListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var products = await UnitOfWork.Products.GetAllWithNamesAsync(c => !c.IsDeleted && c.IsActive);
            if (products.Count > -1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    ProductListWithRelatedTables = products,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Çalışan"));

        }

        public async Task<IDataResult<ProductListDto>> GetAllAsync()
        {
            var products = await UnitOfWork.Products.GetAllWithNamesAsync();
            if (products.Count > -1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    ProductListWithRelatedTables = products,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Çalışan"));
        }
        public async Task<IResult> AddAsync(ProductAddDto ProductAddDto, string createdByName, int userId)
        {
            var product = Mapper.Map<Product>(ProductAddDto);
            product.CreatedByName = createdByName;
            product.ModifiedByName = createdByName;
            var addedProduct = await UnitOfWork.Products.AddAsync(product);
            await UnitOfWork.SaveAsync();
            return new DataResult<ProductDto>(ResultStatus.Success, new ProductDto
            {
                Product = addedProduct,
            }, Messages.General.GiveMessage("xxKx", "Çalışan", "eklendi."));
        }
        public async Task<IResult> UpdateAsync(ProductUpdateDto ProductUpdateDto, string modifiedByName)
        {
            var oldProduct = await UnitOfWork.Products.GetAsync(c => c.Id == ProductUpdateDto.Id);
            var product = Mapper.Map<ProductUpdateDto, Product>(ProductUpdateDto, oldProduct);
            product.ModifiedByName = modifiedByName;
            var updatedProduct = await UnitOfWork.Products.UpdateAsync(product);
            await UnitOfWork.SaveAsync();
            return new DataResult<ProductDto>(ResultStatus.Success, new ProductDto
            {
                Product = updatedProduct,
            }, Messages.General.GiveMessage("xxKx", "Çalışan", "Güncellendi."));
        }
        public async Task<IDataResult<ProductListDto>> GetAllByDeletedAsync()
        {
            var products = await UnitOfWork.Products.GetAllWithNamesAsync(x => x.IsDeleted);
            if (products.Count > -1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    ProductListWithRelatedTables = products,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Çalışan"));
        }

        public async Task<IDataResult<ProductListDto>> GetAllByNonDeletedAsync()
        {
            var products = await UnitOfWork.Products.GetAllWithNamesAsync(x => !x.IsDeleted);
            if (products.Count > -1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    ProductListWithRelatedTables = products,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Çalışan"));
        }

        //public async Task<IDataResult<ProductListDto>> GetAllByNonDeletedAndActiveAsync()
        //{
        //    var products = await UnitOfWork.Products.GetAllAsync(c => !c.IsDeleted && c.IsActive);
        //    if (products.Count > -1)
        //    {
        //        return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
        //        {
        //            Products = products,
        //        });
        //    }
        //    return new DataResult<ProductListDto>(ResultStatus.Error, new ProductListDto
        //    {
        //        Products = null,
        //    }, Messages.General.NotFound(isPlural: true, "Çalışan"));
        //}





        //public async Task<IDataResult<ProductDto>> DeleteAsync(int ProductId, string modifiedByName)
        //{
        //    var product = await UnitOfWork.Products.GetAsync(c => c.Id == ProductId);
        //    if (product != null)
        //    {
        //        Product.IsDeleted = true;
        //        Product.IsActive = false;
        //        Product.ModifiedByName = modifiedByName;
        //        Product.ModifiedDate = DateTime.Now;
        //        var deletedProduct = await UnitOfWork.Products.UpdateAsync(Product);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<ProductDto>(ResultStatus.Success, new ProductDto
        //        {
        //            Product = deletedProduct,
        //        }, Messages.Product.Delete(deletedProduct.CreatedByName));
        //    }
        //    return new DataResult<ProductDto>(ResultStatus.Error, new ProductDto
        //    {
        //        Product = null,
        //    }, Messages.Product.NotFound(isPlural: false));
        //}

        //public async Task<IResult> HardDeleteAsync(int ProductId)
        //{
        //    var product = await UnitOfWork.Products.GetAsync(c => c.Id == ProductId);
        //    if (product != null)
        //    {
        //        await UnitOfWork.Products.DeleteAsync(Product);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.Product.HardDelete(Product.CreatedByName));
        //    }
        //    return new Result(ResultStatus.Error, Messages.Product.NotFound(isPlural: false));
        //}

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var productsCount = await UnitOfWork.Products.CountAsync();
        //    if (productsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, ProductsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1,$"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var productsCount = await UnitOfWork.Products.CountAsync(c=>!c.IsDeleted);
        //    if (productsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, ProductsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<ProductDto>> ApproveAsync(int ProductId, string modifiedByName)
        //{
        //    var product = await UnitOfWork.Products.GetAsync(c => c.Id == ProductId, c => c.Product);
        //    if (product != null)
        //    {
        //        product.IsActive = true;
        //        product.ModifiedByName = modifiedByName;
        //        product.ModifiedDate = DateTime.Now;
        //        var updatedProduct = await UnitOfWork.Products.UpdateAsync(Product);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<ProductDto>(ResultStatus.Success, new ProductDto
        //        {
        //            Product = updatedProduct
        //        }, Messages.Product.Approve(ProductId));
        //    }

        //    return new DataResult<ProductDto>(ResultStatus.Error, null, Messages.Product.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<ProductDto>> UndoDeleteAsync(int ProductId, string modifiedByName)
        //{
        //    var product = await UnitOfWork.Products.GetAsync(c => c.Id == ProductId);
        //    if (product != null)
        //    {
        //        product.IsDeleted = false;
        //        product.IsActive = true;
        //        product.ModifiedByName = modifiedByName;
        //        product.ModifiedDate = DateTime.Now;
        //        var deletedProduct = await UnitOfWork.Products.UpdateAsync(Product);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<ProductDto>(ResultStatus.Success, new ProductDto
        //        {
        //            Product = deletedProduct,
        //        }, Messages.Product.UndoDelete(deletedProduct.CreatedByName));
        //    }
        //    return new DataResult<ProductDto>(ResultStatus.Error, new ProductDto
        //    {
        //        Product = null,
        //    }, Messages.Product.NotFound(isPlural: false));
        //}
    }
}
