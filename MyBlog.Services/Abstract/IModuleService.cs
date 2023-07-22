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
    public interface IModuleService : IGenericService<Module>
    {
        Task<IDataResult<ModuleDto>> GetAsync(int ModuleId);
        Task<IDataResult<ModuleListDto>> GetAllByNonDeletedAndActiveAsync();
        //Task<IDataResult<ModuleDto>> GetAllByDeletedAsync();
        //Task<IDataResult<ModuleDto>> GetAllByNonDeletedAsync();
        //Task<IResult> AddAsync(ModuleAddDto ModuleAddDto, string createdByName, int userId);
        //Task<IDataResult<ModuleDto>> ApproveAsync(int ModuleId, string modifiedByName);
        //Task<IResult> UpdateAsync(ModuleUpdateDto ModuleUpdateDto, string modifiedByName);
        //Task<IDataResult<ModuleDto>> DeleteAsync(int ModuleId, string modifiedByName);
        //Task<IDataResult<ModuleDto>> UndoDeleteAsync(int ModuleId, string modifiedByName);
        //Task<IResult> HardDeleteAsync(int ModuleId);
        //Task<IDataResult<int>> CountAsync();
        //Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}