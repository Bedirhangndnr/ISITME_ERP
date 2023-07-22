using MyBlog.Entities.Dtos;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.SaleDtos;
using MyBlog.Entities.Dtos.ProgramsDtos;

namespace MyBlog.Services.Abstract
{
    public interface ISubProgramService : IGenericService<SubProgram>
    {
        Task<IDataResult<SubProgramDto>> GetAsync(int SubProgramId);
        Task<IDataResult<SubProgramListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<SubProgramListDto>> GetAllByNonDeletedAndActiveByProgramIdAsync(int ProgramId);
        //Task<IDataResult<SubProgramDto>> GetAllByDeletedAsync();
        //Task<IDataResult<SubProgramDto>> GetAllByNonDeletedAsync();
        //Task<IResult> AddAsync(SubProgramAddDto SubProgramAddDto, string createdByName, int userId);
        //Task<IDataResult<SubProgramDto>> ApproveAsync(int SubProgramId, string modifiedByName);
        //Task<IResult> UpdateAsync(SubProgramUpdateDto SubProgramUpdateDto, string modifiedByName);
        //Task<IDataResult<SubProgramDto>> DeleteAsync(int SubProgramId, string modifiedByName);
        //Task<IDataResult<SubProgramDto>> UndoDeleteAsync(int SubProgramId, string modifiedByName);
        //Task<IResult> HardDeleteAsync(int SubProgramId);
        //Task<IDataResult<int>> CountAsync();
        //Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}