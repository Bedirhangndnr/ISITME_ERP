using MyBlog.Entities.Dtos;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ProgramsDtos;
using MyBlog.Entities.Dtos.SaleDtos;

namespace MyBlog.Services.Abstract
{
    public interface IProgramService : IGenericService<Program>
    {
        Task<IDataResult<ProgramDto>> GetAsync(int ProgramId);
        Task<IDataResult<ProgramListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<ProgramListDto>> GetAllByNonDeletedAndActiveByModuleIdAsync(int ModuleId);
        //Task<IDataResult<ProgramDto>> GetAllByDeletedAsync();
        //Task<IDataResult<ProgramDto>> GetAllByNonDeletedAsync();
        //Task<IResult> AddAsync(ProgramAddDto ProgramAddDto, string createdByName, int userId);
        //Task<IDataResult<ProgramDto>> ApproveAsync(int ProgramId, string modifiedByName);
        //Task<IResult> UpdateAsync(ProgramUpdateDto ProgramUpdateDto, string modifiedByName);
        //Task<IDataResult<ProgramDto>> DeleteAsync(int ProgramId, string modifiedByName);
        //Task<IDataResult<ProgramDto>> UndoDeleteAsync(int ProgramId, string modifiedByName);
        //Task<IResult> HardDeleteAsync(int ProgramId);
        //Task<IDataResult<int>> CountAsync();
        //Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}