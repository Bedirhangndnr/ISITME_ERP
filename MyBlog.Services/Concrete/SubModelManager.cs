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
    public class SubModelManager : ManagerBase, ISubModelService
    {
        private readonly MyBlogContext _dbContext;

        public SubModelManager(MyBlogContext dbContext, IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<IDataResult<SubModelDto>> GetAsync(int SubModelId)
        {
            var SubModel = await UnitOfWork.SubModels.GetAsync(c => c.Id == SubModelId);
            if (SubModel != null)
            {
                return new DataResult<SubModelDto>(ResultStatus.Success, new SubModelDto
                {
                    SubModel = SubModel,
                });
            }
            return new DataResult<SubModelDto>(ResultStatus.Error, new SubModelDto
            {
                SubModel = null,
            }, Messages.General.NotFound(isPlural: false, "SubModel"));
        }
        public async Task<IDataResult<SubModelListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var subModels = await UnitOfWork.SubModels.GetAllAsync(x => !x.IsDeleted);
            var subModelsWRelated = await UnitOfWork.SubModels.GetAllWithNamesAsync(x => !x.IsDeleted);
            if (subModels.Count > -1)
            {
                return new DataResult<SubModelListDto>(ResultStatus.Success, new SubModelListDto
                {
                    SubModelListWithRelatedTables = subModelsWRelated,
                    SubModels = subModels,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SubModelListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "SubModel"));

        }

        public async Task<IDataResult<SubModelListDto>> GetAllByModel(int modelId)
        {
            var subModels = await UnitOfWork.SubModels.GetAllAsync(c => !c.IsDeleted && c.IsActive && c.ModelId == modelId);
            var subModelsWRelated = await UnitOfWork.SubModels.GetAllWithNamesAsync(c => !c.IsDeleted && c.IsActive && c.ModelId == modelId);
            if (subModels.Count > -1)
            {
                return new DataResult<SubModelListDto>(ResultStatus.Success, new SubModelListDto
                {
                    SubModelListWithRelatedTables = subModelsWRelated,
                    SubModels = subModels,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SubModelListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "SubModel"));

        }


        public async Task<IDataResult<SubModelListDto>> GetAllAsync()
        {
            var SubModels = await UnitOfWork.SubModels.GetAllAsync(null);
            if (SubModels.Count > -1)
            {
                return new DataResult<SubModelListDto>(ResultStatus.Success, new SubModelListDto
                {
                    SubModels = SubModels,
                });
            }
            return new DataResult<SubModelListDto>(ResultStatus.Error, new SubModelListDto
            {
                SubModels = null,
            }, Messages.General.NotFound(isPlural: true, "SubModel"));
        }
        public async Task<IDataResult<SubModelDto>> DeleteAsync(int SubModelId, string modifiedByName)
        {
            var subModel = await UnitOfWork.SubModels.GetAsync(c => c.Id == SubModelId);
            if (subModel != null)
            {
                subModel.IsDeleted = true;
                //subModel.IsActive = false;
                subModel.ModifiedByName = modifiedByName;
                subModel.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.SubModels.UpdateAsync(subModel);
                await UnitOfWork.SaveAsync();
                return new DataResult<SubModelDto>(ResultStatus.Success, new SubModelDto
                {
                    Message = Messages.General.GiveMessage(subModel.Title, "SubModel", MessagesConstants.AddSuccess),
                    SubModel = deletedEmployeeType

                }, Messages.General.GiveMessage(subModel.Title, "SubModel", MessagesConstants.UpdateSuccess));
            }
            return new DataResult<SubModelDto>(ResultStatus.Error, new SubModelDto
            {
                SubModel = null,
            }, Messages.General.GiveMessage(subModel.Title, "SubModel", MessagesConstants.UpdateError));
        }
        public async Task<IDataResult<SubModelListDto>> GetAllByDeletedAsync()
        {
            var SubModels = await UnitOfWork.SubModels.GetAllAsync(c => c.IsDeleted);
            if (SubModels.Count > -1)
            {
                return new DataResult<SubModelListDto>(ResultStatus.Success, new SubModelListDto
                {
                    SubModels = SubModels,
                });
            }
            return new DataResult<SubModelListDto>(ResultStatus.Error, new SubModelListDto
            {
                SubModels = null,
            }, Messages.General.TableNotFound("Ürün Alt Grupları"));
        }
        public async Task<IResult> HardDeleteAsync(int SubModelId)
        {
            var SubModel = await UnitOfWork.SubModels.GetAsync(c => c.Id == SubModelId);
            if (SubModel != null)
            {
                await UnitOfWork.SubModels.DeleteAsync(SubModel);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(SubModel.Title, "SubModel", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.GiveMessage(SubModel.Title, "SubModel", MessagesConstants.HardDeletedSuccess));
        }


        public async Task<IDataResult<SubModelDto>> UndoDeleteAsync(int SubModelId, string modifiedByName)
        {
            var SubModel = await UnitOfWork.SubModels.GetAsync(c => c.Id == SubModelId);
            if (SubModel != null)
            {
                SubModel.IsDeleted = false;
                SubModel.IsActive = true;
                SubModel.ModifiedByName = modifiedByName;
                SubModel.ModifiedDate = DateTime.Now;
                var deletedSubModel = await UnitOfWork.SubModels.UpdateAsync(SubModel);
                await UnitOfWork.SaveAsync();
                return new DataResult<SubModelDto>(ResultStatus.Success, new SubModelDto
                {
                    Message = Messages.General.GiveMessage(SubModel.Title, "SubModel", MessagesConstants.UndoDeletedSuccess),
                    SubModel = deletedSubModel,
                }, Messages.General.GiveMessage(SubModel.Title, "SubModel", MessagesConstants.UndoDeletedSuccess));
            }
            return new DataResult<SubModelDto>(ResultStatus.Error, new SubModelDto
            {
                SubModel = null,
            }, Messages.General.GiveMessage(SubModel.Title, "SubModel", MessagesConstants.UndoDeletedError));
        }
        public async Task<IDataResult<int>> CountAsync()
        {
            var SubModelsCount = await UnitOfWork.SubModels.CountAsync();
            if (SubModelsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, SubModelsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var SubModelsCount = await UnitOfWork.SubModels.CountAsync(c => !c.IsDeleted);
            if (SubModelsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, SubModelsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

     
    }
}
