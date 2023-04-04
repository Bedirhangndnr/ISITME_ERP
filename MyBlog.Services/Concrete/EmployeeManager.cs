using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Entities.Dtos.EmployeeDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using static MyBlog.Services.Utilities.Messages;

namespace MyBlog.Services.Concrete
{
    public class EmployeeManager:ManagerBase,IEmployeeService
    {
        public EmployeeManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<EmployeeDto>> GetAsync(int EmployeeId)
        {
            var Employee = await UnitOfWork.Employees.GetAsync(c => c.Id == EmployeeId);
            if (Employee != null)
            {
                return new DataResult<EmployeeDto>(ResultStatus.Success, new EmployeeDto
                {
                    Employee = Employee,
                });
            }
            return new DataResult<EmployeeDto>(ResultStatus.Error, new EmployeeDto
            {
                Employee = null,
            }, Messages.General.NotFound(isPlural: false, "Personel"));
        }
        public async Task<IDataResult<EmployeeUpdateDto>> GetEmployeeUpdateDtoAsync(int EmployeeId)
        {
            var result = await UnitOfWork.Employees.AnyAsync(c => c.Id == EmployeeId);
            if (result)
            {
                var Employee = await UnitOfWork.Employees.GetAsync(c => c.Id == EmployeeId);
                var EmployeeUpdateDto = Mapper.Map<EmployeeUpdateDto>(Employee);
                return new DataResult<EmployeeUpdateDto>(ResultStatus.Success, EmployeeUpdateDto);
            }
            else
            {
                return new DataResult<EmployeeUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Personel"));
            }
        }

        public async Task<IDataResult<EmployeeListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var Employees = await UnitOfWork.Employees.GetAllWithRelatedTablesAsync(x => !x.IsDeleted);
            if (Employees.Count > -1)
            {
                return new DataResult<EmployeeListDto>(ResultStatus.Success, new EmployeeListDto
                {
                    EmployeeListWithRelatedTables = Employees,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EmployeeListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Personel"));

        }

        public async Task<IDataResult<EmployeeListDto>> GetAllAsync()
        {
            var Employees = await UnitOfWork.Employees.GetAllWithRelatedTablesAsync(null);
            if (Employees.Count > -1)
            {
                return new DataResult<EmployeeListDto>(ResultStatus.Success, new EmployeeListDto
                {
                    EmployeeListWithRelatedTables = Employees,
                });
            }
            return new DataResult<EmployeeListDto>(ResultStatus.Error, new EmployeeListDto
            {
                Employees = null,
            }, Messages.General.NotFound(isPlural: true, "Personel"));
        }
        public async Task<IResult> AddAsync(EmployeeAddDto EmployeeAddDto, string createdByName, int userId)
        {
            var Employee = Mapper.Map<Employee>(EmployeeAddDto);
            Employee.CreatedByName = createdByName;
            Employee.ModifiedByName = createdByName;
            var addedEmployee = await UnitOfWork.Employees.AddAsync(Employee);
            await UnitOfWork.SaveAsync();
            return new DataResult<EmployeeDto>(ResultStatus.Success, new EmployeeDto
            {
                Employee = addedEmployee,
            }, Messages.General.GiveMessage(EmployeeAddDto.FirstName, "Personel", MessagesConstants.AddSuccess));
        }
        public async Task<IResult> UpdateAsync(EmployeeUpdateDto EmployeeUpdateDto, string modifiedByName)
        {
            var oldEmployee = await UnitOfWork.Employees.GetAsync(c => c.Id == EmployeeUpdateDto.Id);
            var Employee = Mapper.Map<EmployeeUpdateDto, Employee>(EmployeeUpdateDto, oldEmployee);
            Employee.ModifiedByName = modifiedByName;
            var updatedEmployee = await UnitOfWork.Employees.UpdateAsync(Employee);
            updatedEmployee.EmployeeType = await UnitOfWork.EmployeeTypes.GetAsync(a => a.Id == EmployeeUpdateDto.EmployeeTypeId);
            await UnitOfWork.SaveAsync();
            return new DataResult<EmployeeDto>(ResultStatus.Success, new EmployeeDto
            {
                Employee = updatedEmployee,
            }, Messages.General.GiveMessage(updatedEmployee.FirstName, "Personel", MessagesConstants.UpdateSuccess));
        }
        public async Task<IDataResult<EmployeeListDto>> GetAllByDeletedAsync()
        {
            var employees = await UnitOfWork.Employees.GetAllWithRelatedTablesAsync(c => c.IsDeleted);
            if (employees.Count > -1)
            {
                return new DataResult<EmployeeListDto>(ResultStatus.Success, new EmployeeListDto
                {
                    EmployeeListWithRelatedTables = employees,
                });
            }
            return new DataResult<EmployeeListDto>(ResultStatus.Error, new EmployeeListDto
            {
                Employees = null,
            });
        }

        public async Task<IDataResult<EmployeeListDto>> GetAllByNonDeletedAsync()
        {
            var Employees = await UnitOfWork.Employees.GetAllWithRelatedTablesAsync(c => !c.IsDeleted);
            if (Employees.Count > -1)
            {
                return new DataResult<EmployeeListDto>(ResultStatus.Success, new EmployeeListDto
                {
                    EmployeeListWithRelatedTables = Employees,
                });
            }
            return new DataResult<EmployeeListDto>(ResultStatus.Error, new EmployeeListDto
            {
                Employees = null,
            });
        }


        public async Task<IDataResult<EmployeeDto>> DeleteAsync(int EmployeeId, string modifiedByName)
        {
            var employee = await UnitOfWork.Employees.GetAsync(c => c.Id == EmployeeId);
            if (employee != null)
            {
                employee.IsDeleted = true;
                employee.IsActive = false;
                employee.ModifiedByName = modifiedByName;
                employee.ModifiedDate = DateTime.Now;
                var deletedEmployee = await UnitOfWork.Employees.UpdateAsync(employee);
                await UnitOfWork.SaveAsync();
                return new DataResult<EmployeeDto>(ResultStatus.Success, new EmployeeDto
                {
                    Employee = deletedEmployee,
                    ResultStatus= ResultStatus.Success,
                    Message = Messages.General.GiveMessage(employee.FirstName, "Personel", MessagesConstants.DeletedSuccess)

                },Messages.General.GiveMessage(employee.FirstName, "Personel", MessagesConstants.DeletedSuccess));
            }
            return new DataResult<EmployeeDto>(ResultStatus.Error, new EmployeeDto
            {
                Employee = null,
            }, Messages.General.GiveMessage(employee.FirstName, "Personel", MessagesConstants.DeletedError));
        }

        public async Task<IResult> HardDeleteAsync(int EmployeeId)
        {
            var employee = await UnitOfWork.Employees.GetAsync(c => c.Id == EmployeeId);
            if (employee != null)
            {
                await UnitOfWork.Employees.DeleteAsync(employee);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(employee.FirstName, "Personel", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.NotFound(isPlural: false, "Personel"));
        }

        public async Task<IDataResult<int>> CountAsync()
        {
            var EmployeesCount = await UnitOfWork.Employees.CountAsync();
            if (EmployeesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, EmployeesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var EmployeesCount = await UnitOfWork.Employees.CountAsync(c => !c.IsDeleted);
            if (EmployeesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, EmployeesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<EmployeeDto>> UndoDeleteAsync(int employeeId, string modifiedByName)
        {
            var employee = await UnitOfWork.Employees.GetAsync(c => c.Id == employeeId);
            if (employee != null)
            {
                employee.IsDeleted = false;
                employee.IsActive = true;
                employee.ModifiedByName = modifiedByName;
                employee.ModifiedDate = DateTime.Now;
                var deletedEmployee = await UnitOfWork.Employees.UpdateAsync(employee);
                await UnitOfWork.SaveAsync();
                return new DataResult<EmployeeDto>(ResultStatus.Success, new EmployeeDto
                {
                    Employee = deletedEmployee,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.General.GiveMessage(employee.FirstName, "Personel", MessagesConstants.UpdateSuccess)
                }, Messages.General.GiveMessage(employee.FirstName, "Personel", MessagesConstants.UpdateError));
            }
            return new DataResult<EmployeeDto>(ResultStatus.Error, new EmployeeDto
            {
                Employee = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.General.NotFound(isPlural: false, "Personel")
            }, Messages.General.NotFound(isPlural: false, "Personel"));
        }
    }
}
