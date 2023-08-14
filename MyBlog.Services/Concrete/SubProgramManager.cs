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
    public class SubProgramManager : ManagerBase, ISubProgramService
    {
        public SubProgramManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<SubProgramDto>> GetAsync(int SubProgramId)
        {
            var SubProgram = await UnitOfWork.SubPrograms.GetAsync(c => c.Id == SubProgramId);
            if (SubProgram != null)
            {
                return new DataResult<SubProgramDto>(ResultStatus.Success, new SubProgramDto
                {
                    SubProgram = SubProgram,
                });
            }
            return new DataResult<SubProgramDto>(ResultStatus.Error, new SubProgramDto
            {
                SubProgram = null,
            }, Messages.General.NotFound(isPlural: false, "Müşteri"));
        } 
        public async Task<IDataResult<SubProgramListDto>> GetAllByNonDeletedAndActiveByProgramIdAsync(int ProgramId)
        {
            var programs = await UnitOfWork.SubPrograms.GetAllAsync(x => !x.IsDeleted && x.IsActive && x.ProgramId == ProgramId);
            if (programs.Count > -1)
            {
                return new DataResult<SubProgramListDto>(ResultStatus.Success, new SubProgramListDto
                {
                    SubPrograms = (List<SubProgram>)programs,
                    ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<SubProgramListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

        }
        public async Task<IDataResult<SubProgramListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var programs = await UnitOfWork.SubPrograms.GetAllAsync(x => !x.IsDeleted && x.IsActive);
            if (programs.Count > -1)
            {
                return new DataResult<SubProgramListDto>(ResultStatus.Success, new SubProgramListDto
                {
                    SubPrograms = (List<SubProgram>)programs,
                    ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<SubProgramListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

        }
        //public async Task<IDataResult<SubProgramListDto>> GetAllForRemainds()
        //{
        //    // Personellar arasında kayıt tarihinin ardından 1., 6. 12. aylarının dolmasına ve doğum günlerinin gelmesine 3 gün kalmış kullanıcıları listeleyecek.   
        //    var today = DateTime.Today;
        //    var programs = await UnitOfWork.SubPrograms.GetAllForRemaindAsync();
        //    if (programs.Count > -1)
        //    {
        //        return new DataResult<SubProgramListDto>(ResultStatus.Success, new SubProgramListDto
        //        {
        //            SubPrograms = programs,
        //            ResultStatus = ResultStatus.Success
        //        });
        //    }
        //    return new DataResult<SubProgramListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));
        //}
        //public async Task<IDataResult<SubProgramUpdateDto>> GetSubProgramUpdateDtoAsync(int SubProgramId)
        //{
        //    var result = await UnitOfWork.SubPrograms.AnyAsync(c => c.Id == SubProgramId);
        //    if (result)
        //    {
        //        var SubProgram = await UnitOfWork.SubPrograms.GetAsync(c => c.Id == SubProgramId);
        //        var SubProgramUpdateDto = Mapper.Map<SubProgramUpdateDto>(SubProgram);
        //        return new DataResult<SubProgramUpdateDto>(ResultStatus.Success, SubProgramUpdateDto);
        //    }
        //    else
        //    {
        //        return new DataResult<SubProgramUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Hasta"));
        //    }
        //}

        //public async Task<IDataResult<SubProgramListDto>> GetAllAsync()
        //{
        //    var SubPrograms = await UnitOfWork.SubPrograms.GetAllAsync(null);
        //    if (SubPrograms.Count > -1)
        //    {
        //        return new DataResult<SubProgramListDto>(ResultStatus.Success, new SubProgramListDto
        //        {
        //            SubPrograms = SubPrograms,
        //        });
        //    }
        //    return new DataResult<SubProgramListDto>(ResultStatus.Error, new SubProgramListDto
        //    {
        //        SubPrograms = null,
        //    }, Messages.General.NotFound(isPlural: true, "Müşteri"));
        //}

        //public async Task<IDataResult<SubProgramListDto>> GetAllByDeletedAsync()
        //{
        //    var SubPrograms = await UnitOfWork.SubPrograms.GetAllAsync(c=>c.IsDeleted, c => c.SubProgram);
        //    if (SubPrograms.Count > -1)
        //    {
        //        return new DataResult<SubProgramListDto>(ResultStatus.Success, new SubProgramListDto
        //        {
        //            SubPrograms = SubPrograms,
        //        });
        //    }
        //    return new DataResult<SubProgramListDto>(ResultStatus.Error, new SubProgramListDto
        //    {
        //        SubPrograms = null,
        //    }, Messages.SubProgram.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<SubProgramListDto>> GetAllByNonDeletedAsync()
        //{
        //    var SubPrograms = await UnitOfWork.SubPrograms.GetAllAsync(c => !c.IsDeleted, c => c.SubProgram);
        //    if (SubPrograms.Count > -1)
        //    {
        //        return new DataResult<SubProgramListDto>(ResultStatus.Success, new SubProgramListDto
        //        {
        //            SubPrograms = SubPrograms,
        //        });
        //    }
        //    return new DataResult<SubProgramListDto>(ResultStatus.Error, new SubProgramListDto
        //    {
        //        SubPrograms = null,
        //    }, Messages.SubProgram.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<SubProgramListDto>> GetAllByNonDeletedAndActiveAsync()
        //{
        //    var SubPrograms = await UnitOfWork.SubPrograms.GetAllAsync(c => !c.IsDeleted && c.IsActive);
        //    if (SubPrograms.Count > -1)
        //    {
        //        return new DataResult<SubProgramListDto>(ResultStatus.Success, new SubProgramListDto
        //        {
        //            SubPrograms = SubPrograms,
        //        });
        //    }
        //    return new DataResult<SubProgramListDto>(ResultStatus.Error, new SubProgramListDto
        //    {
        //        SubPrograms = null,
        //    }, Messages.General.NotFound(isPlural: true, "Hasta"));
        //}

        //public async Task<IResult> AddAsync(SubProgramAddDto SubProgramAddDto, string createdByName, int userId)
        //{
        //    var program = Mapper.Map<SubProgram>(SubProgramAddDto);
        //    program.CreatedByName = createdByName;
        //    program.ModifiedByName = createdByName;
        //    var addedSubProgram = await UnitOfWork.SubPrograms.AddAsync(program);
        //    await UnitOfWork.SaveAsync();
        //    return new DataResult<SubProgramDto>(ResultStatus.Success, new SubProgramDto
        //    {
        //        SubProgram = addedSubProgram,
        //    }, Messages.General.GiveMessage(SubProgramAddDto.FirstName, "hasta", "eklendi."));
        //}

        //public async Task<IResult> UpdateAsync(SubProgramUpdateDto SubProgramUpdateDto, string modifiedByName)
        //{
        //    var oldSubProgram = await UnitOfWork.SubPrograms.GetAsync(a => a.Id == SubProgramUpdateDto.Id);
        //    var program = Mapper.Map<SubProgramUpdateDto, SubProgram>(SubProgramUpdateDto, oldSubProgram);
        //    program.ModifiedByName = modifiedByName;
        //    await UnitOfWork.SubPrograms.UpdateAsync(program);
        //    await UnitOfWork.SaveAsync();
        //    return new Result(ResultStatus.Success, Messages.General.GiveMessage(program.FirstName, "Hasta", "Güncellendi"));
        //}

  

        //public async Task<IDataResult<SubProgramDto>> DeleteAsync(int SubProgramId, string modifiedByName)
        //{
        //    var SubProgram = await UnitOfWork.SubPrograms.GetAsync(c => c.Id == SubProgramId);
        //    if (SubProgram != null)
        //    {
        //        SubProgram.IsDeleted = true;
        //        SubProgram.IsActive = false;
        //        SubProgram.ModifiedByName = modifiedByName;
        //        SubProgram.ModifiedDate = DateTime.Now;
        //        var deletedSubProgram = await UnitOfWork.SubPrograms.UpdateAsync(SubProgram);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<SubProgramDto>(ResultStatus.Success, new SubProgramDto
        //        {
        //            SubProgram = deletedSubProgram,
        //        }, Messages.SubProgram.Delete(deletedSubProgram.CreatedByName));
        //    }
        //    return new DataResult<SubProgramDto>(ResultStatus.Error, new SubProgramDto
        //    {
        //        SubProgram = null,
        //    }, Messages.SubProgram.NotFound(isPlural: false));
        //}

        //public async Task<IResult> HardDeleteAsync(int SubProgramId)
        //{
        //    var SubProgram = await UnitOfWork.SubPrograms.GetAsync(c => c.Id == SubProgramId);
        //    if (SubProgram != null)
        //    {
        //        await UnitOfWork.SubPrograms.DeleteAsync(SubProgram);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.SubProgram.HardDelete(SubProgram.CreatedByName));
        //    }
        //    return new Result(ResultStatus.Error, Messages.SubProgram.NotFound(isPlural: false));
        //}

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var SubProgramsCount = await UnitOfWork.SubPrograms.CountAsync();
        //    if (SubProgramsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, SubProgramsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1,$"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var SubProgramsCount = await UnitOfWork.SubPrograms.CountAsync(c=>!c.IsDeleted);
        //    if (SubProgramsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, SubProgramsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<SubProgramDto>> ApproveAsync(int SubProgramId, string modifiedByName)
        //{
        //    var SubProgram = await UnitOfWork.SubPrograms.GetAsync(c => c.Id == SubProgramId, c => c.SubProgram);
        //    if (SubProgram != null)
        //    {
        //        SubProgram.IsActive = true;
        //        SubProgram.ModifiedByName = modifiedByName;
        //        SubProgram.ModifiedDate = DateTime.Now;
        //        var updatedSubProgram = await UnitOfWork.SubPrograms.UpdateAsync(SubProgram);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<SubProgramDto>(ResultStatus.Success, new SubProgramDto
        //        {
        //            SubProgram = updatedSubProgram
        //        }, Messages.SubProgram.Approve(SubProgramId));
        //    }

        //    return new DataResult<SubProgramDto>(ResultStatus.Error, null, Messages.SubProgram.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<SubProgramDto>> UndoDeleteAsync(int SubProgramId, string modifiedByName)
        //{
        //    var SubProgram = await UnitOfWork.SubPrograms.GetAsync(c => c.Id == SubProgramId);
        //    if (SubProgram != null)
        //    {
        //        SubProgram.IsDeleted = false;
        //        SubProgram.IsActive = true;
        //        SubProgram.ModifiedByName = modifiedByName;
        //        SubProgram.ModifiedDate = DateTime.Now;
        //        var deletedSubProgram = await UnitOfWork.SubPrograms.UpdateAsync(SubProgram);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<SubProgramDto>(ResultStatus.Success, new SubProgramDto
        //        {
        //            SubProgram = deletedSubProgram,
        //        }, Messages.SubProgram.UndoDelete(deletedSubProgram.CreatedByName));
        //    }
        //    return new DataResult<SubProgramDto>(ResultStatus.Error, new SubProgramDto
        //    {
        //        SubProgram = null,
        //    }, Messages.SubProgram.NotFound(isPlural: false));
        //}
    }
}
