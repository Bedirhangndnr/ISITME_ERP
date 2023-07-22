using MyBlog.Entities.Dtos;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.EmployeeDtos;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;
using MyBlog.Entities.Dtos.CategoryDtos;

namespace MyBlog.Services.Abstract
{
    public interface IEmployeeTypeService : IGenericService<EmployeeType>
    {
        Task<IDataResult<EmployeeTypeDto>> GetAsync(int EmployeeTypeId);
        Task<IDataResult<EmployeeTypeUpdateDto>> GetEmployeeTypeUpdateDtoAsync(int EmployeeTypeId);
        Task<IDataResult<EmployeeTypeListDto>> GetAllAsync();

        Task<IDataResult<EmployeeTypeListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<EmployeeTypeDto>> AddAsync(EmployeeTypeAddDto EmployeeTypeAddDto, string createdByName);
        Task<IDataResult<EmployeeTypeDto>> UpdateAsync(EmployeeTypeUpdateDto EmployeeTypeUpdateDto, string modifiedByName);
        Task<IDataResult<EmployeeTypeDto>> DeleteAsync(int EmployeeTypeId, string modifiedByName);

        Task<IDataResult<EmployeeTypeListDto>> GetAllByDeletedAsync();
        Task<IDataResult<EmployeeTypeDto>> UndoDeleteAsync(int EmployeeTypeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}