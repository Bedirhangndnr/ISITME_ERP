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
    public class ProgramManager : ManagerBase, IProgramService
    {
        public ProgramManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<ProgramDto>> GetAsync(int ProgramId)
        {
            var Program = await UnitOfWork.Programs.GetAsync(c => c.Id == ProgramId);
            if (Program != null)
            {
                return new DataResult<ProgramDto>(ResultStatus.Success, new ProgramDto
                {
                    Program = Program,
                });
            }
            return new DataResult<ProgramDto>(ResultStatus.Error, new ProgramDto
            {
                Program = null,
            }, Messages.General.NotFound(isPlural: false, "Müşteri"));
        }
        public async Task<IDataResult<ProgramListDto>> GetAllByNonDeletedAndActiveByModuleIdAsync(int ModuleId)
        {
            var programs = await UnitOfWork.Programs.GetAllAsync(x => !x.IsDeleted && x.IsActive && x.ModuleId==ModuleId);
            if (programs.Count > -1)
            {
                return new DataResult<ProgramListDto>(ResultStatus.Success, new ProgramListDto
                {
                    Programs = (List<Program>)programs,
                    ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<ProgramListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

        }
        public async Task<IDataResult<ProgramListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var programs = await UnitOfWork.Programs.GetAllAsync(x => !x.IsDeleted && x.IsActive);
            if (programs.Count > -1)
            {
                return new DataResult<ProgramListDto>(ResultStatus.Success, new ProgramListDto
                {
                    Programs = (List<Program>)programs,
                    ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<ProgramListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

        }
        //public async Task<IDataResult<ProgramListDto>> GetAllForRemainds()
        //{
        //    // çalışanlar arasında kayıt tarihinin ardından 1., 6. 12. aylarının dolmasına ve doğum günlerinin gelmesine 3 gün kalmış kullanıcıları listeleyecek.   
        //    var today = DateTime.Today;
        //    var programs = await UnitOfWork.Programs.GetAllForRemaindAsync();
        //    if (programs.Count > -1)
        //    {
        //        return new DataResult<ProgramListDto>(ResultStatus.Success, new ProgramListDto
        //        {
        //            Programs = programs,
        //            ResultStatus = ResultStatus.Success
        //        });
        //    }
        //    return new DataResult<ProgramListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));
        //}
        //public async Task<IDataResult<ProgramUpdateDto>> GetProgramUpdateDtoAsync(int ProgramId)
        //{
        //    var result = await UnitOfWork.Programs.AnyAsync(c => c.Id == ProgramId);
        //    if (result)
        //    {
        //        var Program = await UnitOfWork.Programs.GetAsync(c => c.Id == ProgramId);
        //        var ProgramUpdateDto = Mapper.Map<ProgramUpdateDto>(Program);
        //        return new DataResult<ProgramUpdateDto>(ResultStatus.Success, ProgramUpdateDto);
        //    }
        //    else
        //    {
        //        return new DataResult<ProgramUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Hasta"));
        //    }
        //}

        //public async Task<IDataResult<ProgramListDto>> GetAllAsync()
        //{
        //    var Programs = await UnitOfWork.Programs.GetAllAsync(null);
        //    if (Programs.Count > -1)
        //    {
        //        return new DataResult<ProgramListDto>(ResultStatus.Success, new ProgramListDto
        //        {
        //            Programs = Programs,
        //        });
        //    }
        //    return new DataResult<ProgramListDto>(ResultStatus.Error, new ProgramListDto
        //    {
        //        Programs = null,
        //    }, Messages.General.NotFound(isPlural: true, "Müşteri"));
        //}

        //public async Task<IDataResult<ProgramListDto>> GetAllByDeletedAsync()
        //{
        //    var Programs = await UnitOfWork.Programs.GetAllAsync(c=>c.IsDeleted, c => c.Program);
        //    if (Programs.Count > -1)
        //    {
        //        return new DataResult<ProgramListDto>(ResultStatus.Success, new ProgramListDto
        //        {
        //            Programs = Programs,
        //        });
        //    }
        //    return new DataResult<ProgramListDto>(ResultStatus.Error, new ProgramListDto
        //    {
        //        Programs = null,
        //    }, Messages.Program.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<ProgramListDto>> GetAllByNonDeletedAsync()
        //{
        //    var Programs = await UnitOfWork.Programs.GetAllAsync(c => !c.IsDeleted, c => c.Program);
        //    if (Programs.Count > -1)
        //    {
        //        return new DataResult<ProgramListDto>(ResultStatus.Success, new ProgramListDto
        //        {
        //            Programs = Programs,
        //        });
        //    }
        //    return new DataResult<ProgramListDto>(ResultStatus.Error, new ProgramListDto
        //    {
        //        Programs = null,
        //    }, Messages.Program.NotFound(isPlural: true));
        //}

        //public async Task<IDataResult<ProgramListDto>> GetAllByNonDeletedAndActiveAsync()
        //{
        //    var Programs = await UnitOfWork.Programs.GetAllAsync(c => !c.IsDeleted && c.IsActive);
        //    if (Programs.Count > -1)
        //    {
        //        return new DataResult<ProgramListDto>(ResultStatus.Success, new ProgramListDto
        //        {
        //            Programs = Programs,
        //        });
        //    }
        //    return new DataResult<ProgramListDto>(ResultStatus.Error, new ProgramListDto
        //    {
        //        Programs = null,
        //    }, Messages.General.NotFound(isPlural: true, "Hasta"));
        //}

        //public async Task<IResult> AddAsync(ProgramAddDto ProgramAddDto, string createdByName, int userId)
        //{
        //    var program = Mapper.Map<Program>(ProgramAddDto);
        //    program.CreatedByName = createdByName;
        //    program.ModifiedByName = createdByName;
        //    var addedProgram = await UnitOfWork.Programs.AddAsync(program);
        //    await UnitOfWork.SaveAsync();
        //    return new DataResult<ProgramDto>(ResultStatus.Success, new ProgramDto
        //    {
        //        Program = addedProgram,
        //    }, Messages.General.GiveMessage(ProgramAddDto.FirstName, "hasta", "eklendi."));
        //}

        //public async Task<IResult> UpdateAsync(ProgramUpdateDto ProgramUpdateDto, string modifiedByName)
        //{
        //    var oldProgram = await UnitOfWork.Programs.GetAsync(a => a.Id == ProgramUpdateDto.Id);
        //    var program = Mapper.Map<ProgramUpdateDto, Program>(ProgramUpdateDto, oldProgram);
        //    program.ModifiedByName = modifiedByName;
        //    await UnitOfWork.Programs.UpdateAsync(program);
        //    await UnitOfWork.SaveAsync();
        //    return new Result(ResultStatus.Success, Messages.General.GiveMessage(program.FirstName, "Hasta", "Güncellendi"));
        //}

  

        //public async Task<IDataResult<ProgramDto>> DeleteAsync(int ProgramId, string modifiedByName)
        //{
        //    var Program = await UnitOfWork.Programs.GetAsync(c => c.Id == ProgramId);
        //    if (Program != null)
        //    {
        //        Program.IsDeleted = true;
        //        Program.IsActive = false;
        //        Program.ModifiedByName = modifiedByName;
        //        Program.ModifiedDate = DateTime.Now;
        //        var deletedProgram = await UnitOfWork.Programs.UpdateAsync(Program);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<ProgramDto>(ResultStatus.Success, new ProgramDto
        //        {
        //            Program = deletedProgram,
        //        }, Messages.Program.Delete(deletedProgram.CreatedByName));
        //    }
        //    return new DataResult<ProgramDto>(ResultStatus.Error, new ProgramDto
        //    {
        //        Program = null,
        //    }, Messages.Program.NotFound(isPlural: false));
        //}

        //public async Task<IResult> HardDeleteAsync(int ProgramId)
        //{
        //    var Program = await UnitOfWork.Programs.GetAsync(c => c.Id == ProgramId);
        //    if (Program != null)
        //    {
        //        await UnitOfWork.Programs.DeleteAsync(Program);
        //        await UnitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, Messages.Program.HardDelete(Program.CreatedByName));
        //    }
        //    return new Result(ResultStatus.Error, Messages.Program.NotFound(isPlural: false));
        //}

        //public async Task<IDataResult<int>> CountAsync()
        //{
        //    var ProgramsCount = await UnitOfWork.Programs.CountAsync();
        //    if (ProgramsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, ProgramsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1,$"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<int>> CountByNonDeletedAsync()
        //{
        //    var ProgramsCount = await UnitOfWork.Programs.CountAsync(c=>!c.IsDeleted);
        //    if (ProgramsCount > -1)
        //    {
        //        return new DataResult<int>(ResultStatus.Success, ProgramsCount);
        //    }
        //    else
        //    {
        //        return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
        //    }
        //}

        //public async Task<IDataResult<ProgramDto>> ApproveAsync(int ProgramId, string modifiedByName)
        //{
        //    var Program = await UnitOfWork.Programs.GetAsync(c => c.Id == ProgramId, c => c.Program);
        //    if (Program != null)
        //    {
        //        Program.IsActive = true;
        //        Program.ModifiedByName = modifiedByName;
        //        Program.ModifiedDate = DateTime.Now;
        //        var updatedProgram = await UnitOfWork.Programs.UpdateAsync(Program);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<ProgramDto>(ResultStatus.Success, new ProgramDto
        //        {
        //            Program = updatedProgram
        //        }, Messages.Program.Approve(ProgramId));
        //    }

        //    return new DataResult<ProgramDto>(ResultStatus.Error, null, Messages.Program.NotFound(isPlural: false));
        //}
        //public async Task<IDataResult<ProgramDto>> UndoDeleteAsync(int ProgramId, string modifiedByName)
        //{
        //    var Program = await UnitOfWork.Programs.GetAsync(c => c.Id == ProgramId);
        //    if (Program != null)
        //    {
        //        Program.IsDeleted = false;
        //        Program.IsActive = true;
        //        Program.ModifiedByName = modifiedByName;
        //        Program.ModifiedDate = DateTime.Now;
        //        var deletedProgram = await UnitOfWork.Programs.UpdateAsync(Program);
        //        await UnitOfWork.SaveAsync();
        //        return new DataResult<ProgramDto>(ResultStatus.Success, new ProgramDto
        //        {
        //            Program = deletedProgram,
        //        }, Messages.Program.UndoDelete(deletedProgram.CreatedByName));
        //    }
        //    return new DataResult<ProgramDto>(ResultStatus.Error, new ProgramDto
        //    {
        //        Program = null,
        //    }, Messages.Program.NotFound(isPlural: false));
        //}
    }
}
