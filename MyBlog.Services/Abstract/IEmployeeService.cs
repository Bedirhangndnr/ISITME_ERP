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

namespace MyBlog.Services.Abstract
{
    public interface IEmployeeService : IGenericService<Employee>
    {
        Task<IDataResult<EmployeeDto>> GetAsync(int EmployeeId);
        Task<IDataResult<EmployeeUpdateDto>> GetEmployeeUpdateDtoAsync(int EmployeeId);
        Task<IDataResult<EmployeeListDto>> GetAllAsync();

        Task<IDataResult<EmployeeListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IResult> AddAsync(EmployeeAddDto EmployeeAddDto, string createdByName, int userId);
        Task<IResult> UpdateAsync(EmployeeUpdateDto EmployeeUpdateDto, string modifiedByName);
        Task<IDataResult<EmployeeListDto>> GetAllByDeletedAsync();


        Task<IDataResult<EmployeeDto>> DeleteAsync(int EmployeeId, string modifiedByName);
        Task<IDataResult<EmployeeDto>> UndoDeleteAsync(int EmployeeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}