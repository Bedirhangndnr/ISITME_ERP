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
            }, Messages.General.NotFound(isPlural: false, "Ürün"));
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
                return new DataResult<ProductUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Ürün"));
            }
        }

        public async Task<IDataResult<ProductListDto>> GetAllByNonDeletedAndActiveAsync(bool getSolds=false)
        {
            IList < ProductListWithRelatedTables> productsWithRelated;
            IList<Product> products;
            if (getSolds==true)
            {
                productsWithRelated = await UnitOfWork.Products.GetAllWithNamesAsync(c => !c.IsDeleted && c.IsActive);
                products = await UnitOfWork.Products.GetAllAsync(c => !c.IsDeleted && c.IsActive);
            }
            else
            {
                productsWithRelated = await UnitOfWork.Products.GetAllWithNamesAsync(c => !c.IsDeleted && c.IsActive && !c.IsSold);
                products = await UnitOfWork.Products.GetAllAsync(c => !c.IsDeleted && c.IsActive && !c.IsSold);
            }

            if (products.Count > -1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products=products,
                    ProductListWithRelatedTables = productsWithRelated,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Ürün"));

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
            return new DataResult<ProductListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Ürün"));
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
            }, Messages.General.GiveMessage("xxKx", "Ürün", "eklendi."));
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
            }, Messages.General.GiveMessage("xxKx", "Ürün", "Güncellendi."));
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
            return new DataResult<ProductListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Ürün"));
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
            return new DataResult<ProductListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Ürün"));
        }

        public async Task<IDataResult<ProductDto>> DeleteAsync(int ProductId, string modifiedByName)
        {
            var product = await UnitOfWork.Products.GetAsync(c => c.Id == ProductId);
            if (product != null)
            {
                product.IsDeleted = true;
                product.IsActive = false;
                product.ModifiedByName = modifiedByName;
                product.ModifiedDate = DateTime.Now;
                var deletedProduct = await UnitOfWork.Products.UpdateAsync(product);
                await UnitOfWork.SaveAsync();
                return new DataResult<ProductDto>(ResultStatus.Success, new ProductDto
                {
                    Product = deletedProduct,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.General.GiveMessage(product.ProductName, "Ürün", MessagesConstants.DeletedSuccess)

                }, Messages.General.GiveMessage(product.ProductName, "Ürün", MessagesConstants.DeletedSuccess));
            }
            return new DataResult<ProductDto>(ResultStatus.Error, new ProductDto
            {
                Product = null,
            }, Messages.General.GiveMessage(product.ProductName, "Ürün", MessagesConstants.DeletedError));
        }

        public async Task<IResult> HardDeleteAsync(int ProductId)
        {
            var product = await UnitOfWork.Products.GetAsync(c => c.Id == ProductId);
            if (product != null)
            {
                await UnitOfWork.Products.DeleteAsync(product);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(product.ProductName, "Ürün", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.NotFound(isPlural: false, "Ürün"));
        }

        public async Task<IDataResult<int>> CountAsync()
        {
            var ProductsCount = await UnitOfWork.Products.CountAsync();
            if (ProductsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, ProductsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var ProductsCount = await UnitOfWork.Products.CountAsync(c => !c.IsDeleted);
            if (ProductsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, ProductsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<ProductDto>> UndoDeleteAsync(int productId, string modifiedByName)
        {
            var product = await UnitOfWork.Products.GetAsync(c => c.Id == productId);
            if (product != null)
            {
                product.IsDeleted = false;
                product.IsActive = true;
                product.ModifiedByName = modifiedByName;
                product.ModifiedDate = DateTime.Now;
                var deletedProduct = await UnitOfWork.Products.UpdateAsync(product);
                await UnitOfWork.SaveAsync();
                return new DataResult<ProductDto>(ResultStatus.Success, new ProductDto
                {
                    Product = deletedProduct,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.General.GiveMessage(product.ProductName, "Ürün", MessagesConstants.UpdateSuccess)
                }, Messages.General.GiveMessage(product.ProductName, "Ürün", MessagesConstants.UpdateError));
            }
            return new DataResult<ProductDto>(ResultStatus.Error, new ProductDto
            {
                Product = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.General.NotFound(isPlural: false, "Ürün")
            }, Messages.General.NotFound(isPlural: false, "Ürün"));
        }
    }
}
