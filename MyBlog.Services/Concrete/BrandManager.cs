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
using MyBlog.Entities.Dtos.BrandDtos;
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
    public class BrandManager:ManagerBase,IBrandService
    {
        private readonly MyBlogContext _dbContext;

        public BrandManager(MyBlogContext dbContext, IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<IDataResult<BrandDto>> GetAsync(int BrandId)
        {
            var Brand = await UnitOfWork.Brands.GetAsync(c => c.Id == BrandId);
            if (Brand != null)
            {
                return new DataResult<BrandDto>(ResultStatus.Success, new BrandDto
                {
                    Brand = Brand,
                });
            }
            return new DataResult<BrandDto>(ResultStatus.Error, new BrandDto
            {
                Brand = null,
            }, Messages.General.NotFound(isPlural: false, "Hasta"));
        }
        public async Task<IDataResult<BrandListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var customers = await UnitOfWork.Brands.GetAllAsync(x => !x.IsDeleted);
            if (customers.Count > -1)
            {
                return new DataResult<BrandListDto>(ResultStatus.Success, new BrandListDto
                {
                    Brands = customers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BrandListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

        }
        public async Task<IDataResult<BrandUpdateDto>> GetBrandUpdateDtoAsync(int BrandId)
        {
            var result = await UnitOfWork.Brands.AnyAsync(c => c.Id == BrandId);
            if (result)
            {
                var Brand = await UnitOfWork.Brands.GetAsync(c => c.Id == BrandId);
                var BrandUpdateDto = Mapper.Map<BrandUpdateDto>(Brand);
                return new DataResult<BrandUpdateDto>(ResultStatus.Success, BrandUpdateDto);
            }
            else
            {
                return new DataResult<BrandUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Hasta Tipi"));
            }
        }

        public async Task<IDataResult<BrandListDto>> GetAllAsync()
        {
            var Brands = await UnitOfWork.Brands.GetAllAsync(null);
            if (Brands.Count > -1)
            {
                return new DataResult<BrandListDto>(ResultStatus.Success, new BrandListDto
                {
                    Brands = Brands,
                });
            }
            return new DataResult<BrandListDto>(ResultStatus.Error, new BrandListDto
            {
                Brands = null,
            }, Messages.General.NotFound(isPlural: true, "Hasta"));
        }
        public async Task<IDataResult<BrandDto>> AddAsync(BrandAddDto BrandAddDto, string createdByName)
        {
            var brand = Mapper.Map<Brand>(BrandAddDto);

            brand.CreatedByName = createdByName;
            var addedBrand = await UnitOfWork.Brands.AddAsync(brand);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(brand);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<BrandDto>(ResultStatus.Success, new BrandDto
            {
                Brand = addedBrand,
            }, Messages.General.GiveMessage(addedBrand.CreatedByName, "Hasta Tipi", "Eklendi"));
        }

        public async Task<IDataResult<BrandDto>> UpdateAsync(BrandUpdateDto BrandUpdateDto, string modifiedByName)
        {
            var oldBrand = await UnitOfWork.Brands.GetAsync(c => c.Id == BrandUpdateDto.Id);
            var brand = Mapper.Map<BrandUpdateDto, Brand>(BrandUpdateDto, oldBrand);
            brand.ModifiedByName = modifiedByName;
            var updatedBrand = await UnitOfWork.Brands.UpdateAsync(brand);
            brand = await UnitOfWork.Brands.GetAsync(a => a.Id == BrandUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<BrandDto>(ResultStatus.Success, new BrandDto
            {
                Message= Messages.General.GiveMessage(brand.Title, "Hasta Tipi", "Güncellendi."),
                Brand = updatedBrand,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(brand.Title, "Hasta Tipi", "Güncellendi."));
        }
        public async Task<IDataResult<BrandDto>> DeleteAsync(int BrandId, string modifiedByName)
        {
            var brand = await UnitOfWork.Brands.GetAsync(c => c.Id == BrandId);
            if (brand != null)
            {
                brand.IsDeleted = true;
                brand.IsActive = false;
                brand.ModifiedByName = modifiedByName;
                brand.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.Brands.UpdateAsync(brand);
                await UnitOfWork.SaveAsync();
                return new DataResult<BrandDto>(ResultStatus.Success, new BrandDto
                {
                    Brand = deletedEmployeeType
                    
                }, Messages.General.GiveMessage(brand.Title, "Marka", "Güncellendi."));
            }
            return new DataResult<BrandDto>(ResultStatus.Error, new BrandDto
            {
                Brand = null,
            }, Messages.General.GiveMessage(brand.Title, "Marka", "Güncellenemedi."));
        }
        //public async Task<IDataResult<BrandListDto>> GetAllByDeletedAsync()
        //{
        //    var Brands = await UnitOfWork.Brands.GetAllAsync(c=>c.IsDeleted, c => c.Brand);
        //    if (Brands.Count > -1)
        //    {
        //        return new DataResult<BrandListDto>(ResultStatus.Success, new BrandListDto
        //        {
        //            Brands = Brands,
        //        });
        //    }
        //    return new DataResult<BrandListDto>(ResultStatus.Error, new BrandListDto
        //    {
        //        Brands = null,
        //    }, Messages.Brand.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<BrandListDto>> GetAllByNonDeletedAsync()
        //{
        //    var Brands = await UnitOfWork.Brands.GetAllAsync(c => !c.IsDeleted, c => c.Brand);
        //    if (Brands.Count > -1)
        //    {
        //        return new DataResult<BrandListDto>(ResultStatus.Success, new BrandListDto
        //        {
        //            Brands = Brands,
        //        });
        //    }
        //    return new DataResult<BrandListDto>(ResultStatus.Error, new BrandListDto
        //    {
        //        Brands = null,
        //    }, Messages.Brand.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<BrandListDto>> GetAllByNonDeletedAndActiveAsync()
        //{
        //    var Brands = await UnitOfWork.Brands.GetAllAsync(c => !c.IsDeleted && c.IsActive);
        //    if (Brands.Count > -1)
        //    {
        //        return new DataResult<BrandListDto>(ResultStatus.Success, new BrandListDto
        //        {
        //            Brands = Brands,
        //        });
        //    }
        //    return new DataResult<BrandListDto>(ResultStatus.Error, new BrandListDto
        //    {
        //        Brands = null,
        //    }, Messages.General.NotFound(isPlural: true, "Hasta"));
        //}



        //public async Task<IDataResult<BrandDto>> DeleteAsync(int BrandId, string modifiedByName)
        //{
        //    var Brand = await UnitOfWork.Brands.GetAsync(c => c.Id == BrandId);
        //    if (Brand != null)
        //    {
        //        Brand.IsDeleted = true;
        //        Brand.IsActive = false;
        //        Brand.ModifiedByName = modifiedByName;
        //        Brand.ModifiedDate = DateTime.Now;
        //        var deletedBrand = await UnitOfWork.Brands.UpdateAsync(Brand);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<BrandDto>(ResultStatus.Success, new BrandDto
        //        {
        //            Brand = deletedBrand,
        //        }, Messages.Brand.Delete(deletedBrand.CreatedByName));
        //    }
        //    return new DataResult<BrandDto>(ResultStatus.Error, new BrandDto
        //    {
        //        Brand = null,
        //    }, Messages.Brand.NotFound(isPlural: false));
        //}

        //public async Task<IResult> HardDeleteAsync(int BrandId)
        //{
        //    var Brand = await UnitOfWork.Brands.GetAsync(c => c.Id == BrandId);
        //    if (Brand != null)
        //    {
        //        await UnitOfWork.Brands.DeleteAsync(Brand);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.Brand.HardDelete(Brand.CreatedByName));
        //    }
        //    return new Result(ResultStatus.Error, Messages.Brand.NotFound(isPlural: false));
        //}

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var BrandsCount = await UnitOfWork.Brands.CountAsync();
        //    if (BrandsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, BrandsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1,$"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var BrandsCount = await UnitOfWork.Brands.CountAsync(c=>!c.IsDeleted);
        //    if (BrandsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, BrandsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<BrandDto>> ApproveAsync(int BrandId, string modifiedByName)
        //{
        //    var Brand = await UnitOfWork.Brands.GetAsync(c => c.Id == BrandId, c => c.Brand);
        //    if (Brand != null)
        //    {
        //        Brand.IsActive = true;
        //        Brand.ModifiedByName = modifiedByName;CustomerType
        //        Brand.ModifiedDate = DateTime.Now;
        //        var updatedBrand = await UnitOfWork.Brands.UpdateAsync(Brand);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<BrandDto>(ResultStatus.Success, new BrandDto
        //        {
        //            Brand = updatedBrand
        //        }, Messages.Brand.Approve(BrandId));
        //    }

        //    return new DataResult<BrandDto>(ResultStatus.Error, null, Messages.Brand.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<BrandDto>> UndoDeleteAsync(int BrandId, string modifiedByName)
        //{
        //    var Brand = await UnitOfWork.Brands.GetAsync(c => c.Id == BrandId);
        //    if (Brand != null)
        //    {
        //        Brand.IsDeleted = false;
        //        Brand.IsActive = true;
        //        Brand.ModifiedByName = modifiedByName;
        //        Brand.ModifiedDate = DateTime.Now;
        //        var deletedBrand = await UnitOfWork.Brands.UpdateAsync(Brand);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<BrandDto>(ResultStatus.Success, new BrandDto
        //        {
        //            Brand = deletedBrand,
        //        }, Messages.Brand.UndoDelete(deletedBrand.CreatedByName));
        //    }
        //    return new DataResult<BrandDto>(ResultStatus.Error, new BrandDto
        //    {
        //        Brand = null,
        //    }, Messages.Brand.NotFound(isPlural: false));
        //}
    }
}
