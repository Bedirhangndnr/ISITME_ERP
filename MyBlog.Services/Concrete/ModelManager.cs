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
using MyBlog.Entities.Dtos.ModelDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using MyBlog.Data.Concrete.EntityFramework.Context;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;
using MyBlog.Entities.Dtos.ModelDtos;

namespace MyBlog.Services.Concrete
{
    public class ModelManager : ManagerBase, IModelService
    {
        private readonly MyBlogContext _dbContext;

        public ModelManager(MyBlogContext dbContext, IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<IDataResult<ModelDto>> GetAsync(int ModelId)
        {
            var Model = await UnitOfWork.Models.GetAsync(c => c.Id == ModelId);
            if (Model != null)
            {
                return new DataResult<ModelDto>(ResultStatus.Success, new ModelDto
                {
                    Model = Model,
                });
            }
            return new DataResult<ModelDto>(ResultStatus.Error, new ModelDto
            {
                Model = null,
            }, Messages.General.NotFound(isPlural: false, "Model"));
        }
        public async Task<IDataResult<ModelListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var models = await UnitOfWork.Models.GetAllAsync(x => !x.IsDeleted);
            var modelsWRelated = await UnitOfWork.Models.GetAllWithNamesAsync(x => !x.IsDeleted);
            if (models.Count > -1)
            {
                return new DataResult<ModelListDto>(ResultStatus.Success, new ModelListDto
                {
                    ModelListWithRelatedTables = modelsWRelated,
                    Models = models,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ModelListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Model"));

        }
        public async Task<IDataResult<ModelListDto>> GetAllByBrand(int brandId)
        {
            var models = await UnitOfWork.Models.GetAllAsync(c => !c.IsDeleted && c.IsActive && c.BrandId == brandId);
            var modelsWRelated = await UnitOfWork.Models.GetAllWithNamesAsync(c => !c.IsDeleted && c.IsActive && c.BrandId == brandId);
            if (models.Count > -1)
            {
                return new DataResult<ModelListDto>(ResultStatus.Success, new ModelListDto
                {
                    ModelListWithRelatedTables = modelsWRelated,
                    Models = models,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ModelListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Model"));

        }
     
        public async Task<IDataResult<ModelUpdateDto>> GetModelUpdateDtoAsync(int ModelId)
        {
            var result = await UnitOfWork.Models.AnyAsync(c => c.Id == ModelId);
            if (result)
            {
                var Model = await UnitOfWork.Models.GetAsync(c => c.Id == ModelId);
                var ModelUpdateDto = Mapper.Map<ModelUpdateDto>(Model);
                return new DataResult<ModelUpdateDto>(ResultStatus.Success, ModelUpdateDto);
            }
            else
            {
                return new DataResult<ModelUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Model"));
            }
        }

        public async Task<IDataResult<ModelListDto>> GetAllAsync()
        {
            var Models = await UnitOfWork.Models.GetAllAsync(null);
            if (Models.Count > -1)
            {
                return new DataResult<ModelListDto>(ResultStatus.Success, new ModelListDto
                {
                    Models = Models,
                });
            }
            return new DataResult<ModelListDto>(ResultStatus.Error, new ModelListDto
            {
                Models = null,
            }, Messages.General.NotFound(isPlural: true, "Model"));
        }
        public async Task<IDataResult<ModelDto>> AddAsync(ModelAddDto ModelAddDto, string createdByName)
        {
            var model = Mapper.Map<Model>(ModelAddDto);

            model.ModifiedByName = createdByName;
            model.CreatedByName = createdByName;
            var addedModel = await UnitOfWork.Models.AddAsync(model);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(model);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<ModelDto>(ResultStatus.Success, new ModelDto
            {
                Message = Messages.General.GiveMessage(addedModel.Title, "Model", MessagesConstants.AddSuccess),
                Model = addedModel,
            }, Messages.General.GiveMessage(addedModel.Title, "Model", MessagesConstants.AddSuccess));
        }

        public async Task<IDataResult<ModelDto>> UpdateAsync(ModelUpdateDto ModelUpdateDto, string modifiedByName)
        {
            var oldModel = await UnitOfWork.Models.GetAsync(c => c.Id == ModelUpdateDto.Id);
            var model = Mapper.Map<ModelUpdateDto, Model>(ModelUpdateDto, oldModel);
            model.ModifiedByName = modifiedByName;
            var updatedModel = await UnitOfWork.Models.UpdateAsync(model);
            model = await UnitOfWork.Models.GetAsync(a => a.Id == ModelUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<ModelDto>(ResultStatus.Success, new ModelDto
            {
                Message = Messages.General.GiveMessage(model.Title, "Model", MessagesConstants.UpdateSuccess),
                Model = updatedModel,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(model.Title, "Model", MessagesConstants.UpdateSuccess));
        }
        public async Task<IDataResult<ModelDto>> DeleteAsync(int ModelId, string modifiedByName)
        {
            var model = await UnitOfWork.Models.GetAsync(c => c.Id == ModelId);
            if (model != null)
            {
                model.IsDeleted = true;
                //model.IsActive = false;
                model.ModifiedByName = modifiedByName;
                model.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.Models.UpdateAsync(model);
                await UnitOfWork.SaveAsync();
                return new DataResult<ModelDto>(ResultStatus.Success, new ModelDto
                {
                    Message = Messages.General.GiveMessage(model.Title, "Model", MessagesConstants.AddSuccess),
                    Model = deletedEmployeeType

                }, Messages.General.GiveMessage(model.Title, "Model", MessagesConstants.UpdateSuccess));
            }
            return new DataResult<ModelDto>(ResultStatus.Error, new ModelDto
            {
                Model = null,
            }, Messages.General.GiveMessage(model.Title, "Model", MessagesConstants.UpdateError));
        }
        public async Task<IDataResult<ModelListDto>> GetAllByDeletedAsync()
        {
            var Models = await UnitOfWork.Models.GetAllAsync(c => c.IsDeleted);
            if (Models.Count > -1)
            {
                return new DataResult<ModelListDto>(ResultStatus.Success, new ModelListDto
                {
                    Models = Models,
                });
            }
            return new DataResult<ModelListDto>(ResultStatus.Error, new ModelListDto
            {
                Models = null,
            }, Messages.General.TableNotFound("Ürün Alt Grupları"));
        }
        public async Task<IResult> HardDeleteAsync(int ModelId)
        {
            var Model = await UnitOfWork.Models.GetAsync(c => c.Id == ModelId);
            if (Model != null)
            {
                await UnitOfWork.Models.DeleteAsync(Model);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(Model.Title, "Model", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.GiveMessage(Model.Title, "Model", MessagesConstants.HardDeletedSuccess));
        }


        public async Task<IDataResult<ModelDto>> UndoDeleteAsync(int ModelId, string modifiedByName)
        {
            var Model = await UnitOfWork.Models.GetAsync(c => c.Id == ModelId);
            if (Model != null)
            {
                Model.IsDeleted = false;
                Model.IsActive = true;
                Model.ModifiedByName = modifiedByName;
                Model.ModifiedDate = DateTime.Now;
                var deletedModel = await UnitOfWork.Models.UpdateAsync(Model);
                await UnitOfWork.SaveAsync();
                return new DataResult<ModelDto>(ResultStatus.Success, new ModelDto
                {
                    Message = Messages.General.GiveMessage(Model.Title, "Model", MessagesConstants.UndoDeletedSuccess),
                    Model = deletedModel,
                }, Messages.General.GiveMessage(Model.Title, "Model", MessagesConstants.UndoDeletedSuccess));
            }
            return new DataResult<ModelDto>(ResultStatus.Error, new ModelDto
            {
                Model = null,
            }, Messages.General.GiveMessage(Model.Title, "Model", MessagesConstants.UndoDeletedError));
        }
        public async Task<IDataResult<int>> CountAsync()
        {
            var ModelsCount = await UnitOfWork.Models.CountAsync();
            if (ModelsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, ModelsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var ModelsCount = await UnitOfWork.Models.CountAsync(c => !c.IsDeleted);
            if (ModelsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, ModelsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

       
    }
}
