using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentTypeDtos;
using MyBlog.Entities.Dtos.ExpenseDtos;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;
using MyBlog.Entities.Dtos.AppointmentTypeDtos;

namespace MyBlog.Services.Abstract
{
    public interface IExpenseService : IGenericService<Expense>
    {
        Task<IDataResult<ExpenseDto>> GetAsync(int ExpenseId);
        Task<IDataResult<ExpenseUpdateDto>> GetExpenseUpdateDtoAsync(int ExpenseId);
        Task<IDataResult<ExpenseListDto>> GetAllAsync();
        Task<IDataResult<ExpenseDto>> DeleteAsync(int ExpenseId, string modifiedByName);
        Task<IDataResult<ExpenseListDto>> GetAllByNonDeletedAndActiveAsync(int lastxDays=0);
        //Task<IDataResult<ExpenseListDto>> GetAllByNonDeletedAndActiveDailyAmountsAsync(int lastxDays=0);
        Task<IDataResult<ExpenseDto>> AddAsync(ExpenseAddDto ExpenseAddDto, string createdByName);
        Task<IDataResult<ExpenseDto>> UpdateAsync(ExpenseUpdateDto ExpenseUpdateDto, string modifiedByName);

        Task<IDataResult<ExpenseListDto>> GetAllByDeletedAsync();
        Task<IDataResult<ExpenseDto>> UndoDeleteAsync(int EmployeeTypeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync(int lastXDays, bool isIncome);
        Task<IDataResult<int>> CountByNonDeletedAsync(int lastXDays, bool isIncome);
        Task<IDataResult<List<int>>> GetDailyIncomeAsync(DateTime startDate, DateTime endDate);


    }
}