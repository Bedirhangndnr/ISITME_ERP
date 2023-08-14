using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Entities.Dtos.ProgramsDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using static MyBlog.Services.Utilities.Messages;

namespace MyBlog.Services.Concrete
{
    public class ModuleManager : ManagerBase, IModuleService
    {
        public ModuleManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<ModuleDto>> GetAsync(int ModuleId)
        {
            var Module = await UnitOfWork.Modules.GetAsync(c => c.Id == ModuleId);
            if (Module != null)
            {
                return new DataResult<ModuleDto>(ResultStatus.Success, new ModuleDto
                {
                    Module = Module,
                });
            }
            return new DataResult<ModuleDto>(ResultStatus.Error, new ModuleDto
            {
                Module = null,
            }, Messages.General.NotFound(isPlural: false, "Müşteri"));
        }
        
        public async Task<IDataResult<ModuleListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var programs = await UnitOfWork.Modules.GetAllAsync(x => !x.IsDeleted && x.IsActive);
            if (programs.Count > -1)
            {
                return new DataResult<ModuleListDto>(ResultStatus.Success, new ModuleListDto
                {
                    Modules = (List<Module>)programs,
                    ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<ModuleListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

        }
        //public async Task<IDataResult<ModuleListDto>> GetAllForRemainds()
        //{
        //    // Personellar arasında kayıt tarihinin ardından 1., 6. 12. aylarının dolmasına ve doğum günlerinin gelmesine 3 gün kalmış kullanıcıları listeleyecek.   
        //    var today = DateTime.Today;
        //    var programs = await UnitOfWork.Modules.GetAllForRemaindAsync();
        //    if (programs.Count > -1)
        //    {
        //        return new DataResult<ModuleListDto>(ResultStatus.Success, new ModuleListDto
        //        {
        //            Modules = programs,
        //            ResultStatus = ResultStatus.Success
        //        });
        //    }
        //    return new DataResult<ModuleListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));
        //}
        //public async Task<IDataResult<ModuleUpdateDto>> GetModuleUpdateDtoAsync(int ModuleId)
        //{
        //    var result = await UnitOfWork.Modules.AnyAsync(c => c.Id == ModuleId);
        //    if (result)
        //    {
        //        var Module = await UnitOfWork.Modules.GetAsync(c => c.Id == ModuleId);
        //        var ModuleUpdateDto = Mapper.Map<ModuleUpdateDto>(Module);
        //        return new DataResult<ModuleUpdateDto>(ResultStatus.Success, ModuleUpdateDto);
        //    }
        //    else
        //    {
        //        return new DataResult<ModuleUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Hasta"));
        //    }
        //}

        //public async Task<IDataResult<ModuleListDto>> GetAllAsync()
        //{
        //    var Modules = await UnitOfWork.Modules.GetAllAsync(null);
        //    if (Modules.Count > -1)
        //    {
        //        return new DataResult<ModuleListDto>(ResultStatus.Success, new ModuleListDto
        //        {
        //            Modules = Modules,
        //        });
        //    }
        //    return new DataResult<ModuleListDto>(ResultStatus.Error, new ModuleListDto
        //    {
        //        Modules = null,
        //    }, Messages.General.NotFound(isPlural: true, "Müşteri"));
        //}

        //public async Task<IDataResult<ModuleListDto>> GetAllByDeletedAsync()
        //{
        //    var Modules = await UnitOfWork.Modules.GetAllAsync(c=>c.IsDeleted, c => c.Module);
        //    if (Modules.Count > -1)
        //    {
        //        return new DataResult<ModuleListDto>(ResultStatus.Success, new ModuleListDto
        //        {
        //            Modules = Modules,
        //        });
        //    }
        //    return new DataResult<ModuleListDto>(ResultStatus.Error, new ModuleListDto
        //    {
        //        Modules = null,
        //    }, Messages.Module.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<ModuleListDto>> GetAllByNonDeletedAsync()
        //{
        //    var Modules = await UnitOfWork.Modules.GetAllAsync(c => !c.IsDeleted, c => c.Module);
        //    if (Modules.Count > -1)
        //    {
        //        return new DataResult<ModuleListDto>(ResultStatus.Success, new ModuleListDto
        //        {
        //            Modules = Modules,
        //        });
        //    }
        //    return new DataResult<ModuleListDto>(ResultStatus.Error, new ModuleListDto
        //    {
        //        Modules = null,
        //    }, Messages.Module.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<ModuleListDto>> GetAllByNonDeletedAndActiveAsync()
        //{
        //    var Modules = await UnitOfWork.Modules.GetAllAsync(c => !c.IsDeleted && c.IsActive);
        //    if (Modules.Count > -1)
        //    {
        //        return new DataResult<ModuleListDto>(ResultStatus.Success, new ModuleListDto
        //        {
        //            Modules = Modules,
        //        });
        //    }
        //    return new DataResult<ModuleListDto>(ResultStatus.Error, new ModuleListDto
        //    {
        //        Modules = null,
        //    }, Messages.General.NotFound(isPlural: true, "Hasta"));
        //}

        //public async Task<IResult> AddAsync(ModuleAddDto ModuleAddDto, string createdByName, int userId)
        //{
        //    var program = Mapper.Map<Module>(ModuleAddDto);
        //    program.CreatedByName = createdByName;
        //    program.ModifiedByName = createdByName;
        //    var addedModule = await UnitOfWork.Modules.AddAsync(program);
        //    await UnitOfWork.SaveAsync();
        //    return new DataResult<ModuleDto>(ResultStatus.Success, new ModuleDto
        //    {
        //        Module = addedModule,
        //    }, Messages.General.GiveMessage(ModuleAddDto.FirstName, "hasta", "eklendi."));
        //}

        //public async Task<IResult> UpdateAsync(ModuleUpdateDto ModuleUpdateDto, string modifiedByName)
        //{
        //    var oldModule = await UnitOfWork.Modules.GetAsync(a => a.Id == ModuleUpdateDto.Id);
        //    var program = Mapper.Map<ModuleUpdateDto, Module>(ModuleUpdateDto, oldModule);
        //    program.ModifiedByName = modifiedByName;
        //    await UnitOfWork.Modules.UpdateAsync(program);
        //    await UnitOfWork.SaveAsync();
        //    return new Result(ResultStatus.Success, Messages.General.GiveMessage(program.FirstName, "Hasta", "Güncellendi"));
        //}

  

        //public async Task<IDataResult<ModuleDto>> DeleteAsync(int ModuleId, string modifiedByName)
        //{
        //    var Module = await UnitOfWork.Modules.GetAsync(c => c.Id == ModuleId);
        //    if (Module != null)
        //    {
        //        Module.IsDeleted = true;
        //        Module.IsActive = false;
        //        Module.ModifiedByName = modifiedByName;
        //        Module.ModifiedDate = DateTime.Now;
        //        var deletedModule = await UnitOfWork.Modules.UpdateAsync(Module);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<ModuleDto>(ResultStatus.Success, new ModuleDto
        //        {
        //            Module = deletedModule,
        //        }, Messages.Module.Delete(deletedModule.CreatedByName));
        //    }
        //    return new DataResult<ModuleDto>(ResultStatus.Error, new ModuleDto
        //    {
        //        Module = null,
        //    }, Messages.Module.NotFound(isPlural: false));
        //}

        //public async Task<IResult> HardDeleteAsync(int ModuleId)
        //{
        //    var Module = await UnitOfWork.Modules.GetAsync(c => c.Id == ModuleId);
        //    if (Module != null)
        //    {
        //        await UnitOfWork.Modules.DeleteAsync(Module);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.Module.HardDelete(Module.CreatedByName));
        //    }
        //    return new Result(ResultStatus.Error, Messages.Module.NotFound(isPlural: false));
        //}

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var ModulesCount = await UnitOfWork.Modules.CountAsync();
        //    if (ModulesCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, ModulesCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1,$"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var ModulesCount = await UnitOfWork.Modules.CountAsync(c=>!c.IsDeleted);
        //    if (ModulesCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, ModulesCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<ModuleDto>> ApproveAsync(int ModuleId, string modifiedByName)
        //{
        //    var Module = await UnitOfWork.Modules.GetAsync(c => c.Id == ModuleId, c => c.Module);
        //    if (Module != null)
        //    {
        //        Module.IsActive = true;
        //        Module.ModifiedByName = modifiedByName;
        //        Module.ModifiedDate = DateTime.Now;
        //        var updatedModule = await UnitOfWork.Modules.UpdateAsync(Module);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<ModuleDto>(ResultStatus.Success, new ModuleDto
        //        {
        //            Module = updatedModule
        //        }, Messages.Module.Approve(ModuleId));
        //    }

        //    return new DataResult<ModuleDto>(ResultStatus.Error, null, Messages.Module.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<ModuleDto>> UndoDeleteAsync(int ModuleId, string modifiedByName)
        //{
        //    var Module = await UnitOfWork.Modules.GetAsync(c => c.Id == ModuleId);
        //    if (Module != null)
        //    {
        //        Module.IsDeleted = false;
        //        Module.IsActive = true;
        //        Module.ModifiedByName = modifiedByName;
        //        Module.ModifiedDate = DateTime.Now;
        //        var deletedModule = await UnitOfWork.Modules.UpdateAsync(Module);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<ModuleDto>(ResultStatus.Success, new ModuleDto
        //        {
        //            Module = deletedModule,
        //        }, Messages.Module.UndoDelete(deletedModule.CreatedByName));
        //    }
        //    return new DataResult<ModuleDto>(ResultStatus.Error, new ModuleDto
        //    {
        //        Module = null,
        //    }, Messages.Module.NotFound(isPlural: false));
        //}
    }
}
