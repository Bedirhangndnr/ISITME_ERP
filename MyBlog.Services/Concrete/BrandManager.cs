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
using MyBlog.Entities.Dtos.AppointmentTypeDtos;

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
            }, Messages.General.NotFound(isPlural: false, "Marka"));
        }
        public async Task<IDataResult<BrandListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var customers = await UnitOfWork.Brands.GetAllAsync(x => !x.IsDeleted && x.Note != "Accessory");
            if (customers.Count > -1)
            {
                return new DataResult<BrandListDto>(ResultStatus.Success, new BrandListDto
                {
                    Brands = customers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BrandListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Marka"));

        }
        public async Task<IDataResult<BrandListDto>> GetAllByNonDeletedAndActiveAccessoryAsync()
        {
            var customers = await UnitOfWork.Brands.GetAllAsync(x => !x.IsDeleted && x.Note=="Accessory");
            if (customers.Count > -1)
            {
                return new DataResult<BrandListDto>(ResultStatus.Success, new BrandListDto
                {
                    Brands = customers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BrandListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Marka"));

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
                return new DataResult<BrandUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Marka"));
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
            }, Messages.General.NotFound(isPlural: true, "Marka"));
        }
        public async Task<IDataResult<BrandDto>> AddAsync(BrandAddDto BrandAddDto, string createdByName)
        {
            var brand = Mapper.Map<Brand>(BrandAddDto);
            brand.ModifiedByName = createdByName;
            brand.CreatedByName = createdByName;
            var addedBrand = await UnitOfWork.Brands.AddAsync(brand);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(brand);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<BrandDto>(ResultStatus.Success, new BrandDto
            {
                Brand = addedBrand,
                Message= Messages.General.GiveMessage(addedBrand.CreatedByName, "Marka", MessagesConstants.AddSuccess)
            }, Messages.General.GiveMessage(addedBrand.CreatedByName, "Marka", MessagesConstants.AddSuccess));
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
                Message= Messages.General.GiveMessage(brand.Title, "Marka", MessagesConstants.UpdateSuccess),
                Brand = updatedBrand,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(brand.Title, "Marka", MessagesConstants.UpdateSuccess));
        }
        public async Task<IDataResult<BrandDto>> DeleteAsync(int BrandId, string modifiedByName)
        {
            var brand = await UnitOfWork.Brands.GetAsync(c => c.Id == BrandId);
            if (brand != null)
            {
                brand.IsDeleted = true;
                //brand.IsActive = false;
                brand.ModifiedByName = modifiedByName;
                brand.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.Brands.UpdateAsync(brand);
                await UnitOfWork.SaveAsync();
                return new DataResult<BrandDto>(ResultStatus.Success, new BrandDto
                {
                    Brand = deletedEmployeeType,
                    Message= Messages.General.GiveMessage(brand.Title, "Marka", MessagesConstants.UpdateSuccess)

                }, Messages.General.GiveMessage(brand.Title, "Marka", MessagesConstants.UpdateSuccess));
            }
            return new DataResult<BrandDto>(ResultStatus.Error, new BrandDto
            {
                Brand = null,
            }, Messages.General.GiveMessage(brand.Title, "Marka", "Güncellenemedi."));
        }
        public async Task<IDataResult<BrandListDto>> GetAllByDeletedAsync()
        {
            var brands = await UnitOfWork.Brands.GetAllAsync(c => c.IsDeleted);
            if (brands.Count > -1)
            {
                return new DataResult<BrandListDto>(ResultStatus.Success, new BrandListDto
                {
                    Brands = brands,
                });
            }
            return new DataResult<BrandListDto>(ResultStatus.Error, new BrandListDto
            {
                Brands = null,
            }, Messages.General.TableNotFound("Markalar"));
        }
        public async Task<IResult> HardDeleteAsync(int BrandId)
        {
            var brand = await UnitOfWork.Brands.GetAsync(c => c.Id == BrandId);
            if (brand != null)
            {
                await UnitOfWork.Brands.DeleteAsync(brand);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(brand.Title, "Marka", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.GiveMessage(brand.Title, "Marka", MessagesConstants.HardDeletedSuccess));
        }


        public async Task<IDataResult<BrandDto>> UndoDeleteAsync(int BrandId, string modifiedByName)
        {
            var brand = await UnitOfWork.Brands.GetAsync(c => c.Id == BrandId);
            if (brand != null)
            {
                brand.IsDeleted = false;
                brand.IsActive = true;
                brand.ModifiedByName = modifiedByName;
                brand.ModifiedDate = DateTime.Now;
                var deletedBrand = await UnitOfWork.Brands.UpdateAsync(brand);
                await UnitOfWork.SaveAsync();
                return new DataResult<BrandDto>(ResultStatus.Success, new BrandDto
                {
                    Message = Messages.General.GiveMessage(brand.Title, "Marka", MessagesConstants.UndoDeletedSuccess),
                    Brand = deletedBrand,
                }, Messages.General.GiveMessage(brand.Title, "Marka", MessagesConstants.UndoDeletedSuccess));
            }
            return new DataResult<BrandDto>(ResultStatus.Error, new BrandDto
            {
                Brand = null,
            }, Messages.General.GiveMessage(brand.Title, "Marka", MessagesConstants.UndoDeletedError));
        }
        public async Task<IDataResult<int>> CountAsync()
        {
            var BrandsCount = await UnitOfWork.Brands.CountAsync();
            if (BrandsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, BrandsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var BrandsCount = await UnitOfWork.Brands.CountAsync(c => !c.IsDeleted);
            if (BrandsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, BrandsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }
    }
}
