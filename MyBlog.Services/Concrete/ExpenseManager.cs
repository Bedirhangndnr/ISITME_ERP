using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ExpenseDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using MyBlog.Data.Concrete.EntityFramework.Context;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;
using MyBlog.Entities.Dtos.AppointmentTypeDtos;

namespace MyBlog.Services.Concrete
{
    public class ExpenseManager : ManagerBase, IExpenseService
    {
        private readonly MyBlogContext _dbContext;

        public ExpenseManager(MyBlogContext dbContext, IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<IDataResult<ExpenseDto>> GetAsync(int ExpenseId)
        {
            var Expense = await UnitOfWork.Expenses.GetAsync(c => c.Id == ExpenseId);
            if (Expense != null)
            {
                return new DataResult<ExpenseDto>(ResultStatus.Success, new ExpenseDto
                {
                    Expense = Expense,
                });
            }
            return new DataResult<ExpenseDto>(ResultStatus.Error, new ExpenseDto
            {
                Expense = null,
            }, Messages.General.NotFound(isPlural: false, "Tutar"));
        }
        public async Task<IDataResult<ExpenseListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var customers = await UnitOfWork.Expenses.GetAllAsync(x => !x.IsDeleted);
            if (customers.Count > -1)
            {
                return new DataResult<ExpenseListDto>(ResultStatus.Success, new ExpenseListDto
                {
                    Expenses = customers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ExpenseListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Tutar"));

        }
        public async Task<IDataResult<ExpenseUpdateDto>> GetExpenseUpdateDtoAsync(int ExpenseId)
        {
            var result = await UnitOfWork.Expenses.AnyAsync(c => c.Id == ExpenseId);
            if (result)
            {
                var Expense = await UnitOfWork.Expenses.GetAsync(c => c.Id == ExpenseId);
                var ExpenseUpdateDto = Mapper.Map<ExpenseUpdateDto>(Expense);
                return new DataResult<ExpenseUpdateDto>(ResultStatus.Success, ExpenseUpdateDto);
            }
            else
            {
                return new DataResult<ExpenseUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Tutar"));
            }
        }

        public async Task<IDataResult<ExpenseListDto>> GetAllAsync()
        {
            var Expenses = await UnitOfWork.Expenses.GetAllAsync(null);
            if (Expenses.Count > -1)
            {
                return new DataResult<ExpenseListDto>(ResultStatus.Success, new ExpenseListDto
                {
                    Expenses = Expenses,
                });
            }
            return new DataResult<ExpenseListDto>(ResultStatus.Error, new ExpenseListDto
            {
                Expenses = null,
            }, Messages.General.NotFound(isPlural: true, "Tutar"));
        }
        public async Task<IDataResult<ExpenseDto>> AddAsync(ExpenseAddDto ExpenseAddDto, string createdByName)
        {
            var expense = Mapper.Map<Expense>(ExpenseAddDto);
            expense.ModifiedByName = createdByName;
            expense.CreatedByName = createdByName;
            var addedExpense = await UnitOfWork.Expenses.AddAsync(expense);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(expense);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<ExpenseDto>(ResultStatus.Success, new ExpenseDto
            {
                Expense = addedExpense,
                Message = Messages.General.GiveMessage(addedExpense.CreatedByName, "Tutar", MessagesConstants.AddSuccess)
            }, Messages.General.GiveMessage(addedExpense.CreatedByName, "Tutar", MessagesConstants.AddSuccess));
        }

        public async Task<IDataResult<ExpenseDto>> UpdateAsync(ExpenseUpdateDto ExpenseUpdateDto, string modifiedByName)
        {
            var oldExpense = await UnitOfWork.Expenses.GetAsync(c => c.Id == ExpenseUpdateDto.Id);
            var expense = Mapper.Map<ExpenseUpdateDto, Expense>(ExpenseUpdateDto, oldExpense);
            expense.ModifiedByName = modifiedByName;
            var updatedExpense = await UnitOfWork.Expenses.UpdateAsync(expense);
            expense = await UnitOfWork.Expenses.GetAsync(a => a.Id == ExpenseUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<ExpenseDto>(ResultStatus.Success, new ExpenseDto
            {
                Message = Messages.General.GiveMessage(expense.Amount.ToString(), "Tutar", MessagesConstants.UpdateSuccess),
                Expense = updatedExpense,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(expense.Amount.ToString(), "Tutar", MessagesConstants.UpdateSuccess));
        }
        public async Task<IDataResult<ExpenseDto>> DeleteAsync(int ExpenseId, string modifiedByName)
        {
            var expense = await UnitOfWork.Expenses.GetAsync(c => c.Id == ExpenseId);
            if (expense != null)
            {
                expense.IsDeleted = true;
                expense.IsActive = false;
                expense.ModifiedByName = modifiedByName;
                expense.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.Expenses.UpdateAsync(expense);
                await UnitOfWork.SaveAsync();
                return new DataResult<ExpenseDto>(ResultStatus.Success, new ExpenseDto
                {
                    Expense = deletedEmployeeType,
                    Message = Messages.General.GiveMessage(expense.Amount.ToString(), "Tutar", MessagesConstants.UpdateSuccess)

                }, Messages.General.GiveMessage(expense.Amount.ToString(), "Tutar", MessagesConstants.UpdateSuccess));
            }
            return new DataResult<ExpenseDto>(ResultStatus.Error, new ExpenseDto
            {
                Expense = null,
            }, Messages.General.GiveMessage(expense.Amount.ToString(), "Tutar", "Güncellenemedi."));
        }
        public async Task<IDataResult<ExpenseListDto>> GetAllByDeletedAsync()
        {
            var expenses = await UnitOfWork.Expenses.GetAllAsync(c => c.IsDeleted);
            if (expenses.Count > -1)
            {
                return new DataResult<ExpenseListDto>(ResultStatus.Success, new ExpenseListDto
                {
                    Expenses = expenses,
                });
            }
            return new DataResult<ExpenseListDto>(ResultStatus.Error, new ExpenseListDto
            {
                Expenses = null,
            }, Messages.General.TableNotFound("Tutarlar"));
        }
        public async Task<IResult> HardDeleteAsync(int ExpenseId)
        {
            var expense = await UnitOfWork.Expenses.GetAsync(c => c.Id == ExpenseId);
            if (expense != null)
            {
                await UnitOfWork.Expenses.DeleteAsync(expense);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(expense.Amount.ToString(), "Tutar", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.GiveMessage(expense.Amount.ToString(), "Tutar", MessagesConstants.HardDeletedSuccess));
        }


        public async Task<IDataResult<ExpenseDto>> UndoDeleteAsync(int ExpenseId, string modifiedByName)
        {
            var expense = await UnitOfWork.Expenses.GetAsync(c => c.Id == ExpenseId);
            if (expense != null)
            {
                expense.IsDeleted = false;
                expense.IsActive = true;
                expense.ModifiedByName = modifiedByName;
                expense.ModifiedDate = DateTime.Now;
                var deletedExpense = await UnitOfWork.Expenses.UpdateAsync(expense);
                await UnitOfWork.SaveAsync();
                return new DataResult<ExpenseDto>(ResultStatus.Success, new ExpenseDto
                {
                    Message = Messages.General.GiveMessage(expense.Amount.ToString(), "Tutar", MessagesConstants.UndoDeletedSuccess),
                    Expense = deletedExpense,
                }, Messages.General.GiveMessage(expense.Amount.ToString(), "Tutar", MessagesConstants.UndoDeletedSuccess));
            }
            return new DataResult<ExpenseDto>(ResultStatus.Error, new ExpenseDto
            {
                Expense = null,
            }, Messages.General.GiveMessage(expense.Amount.ToString(), "Tutar", MessagesConstants.UndoDeletedError));
        }
        public async Task<IDataResult<int>> CountAsync()
        {
            var ExpensesCount = await UnitOfWork.Expenses.CountAsync();
            if (ExpensesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, ExpensesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var ExpensesCount = await UnitOfWork.Expenses.CountAsync(c => !c.IsDeleted);
            if (ExpensesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, ExpensesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }
    }
}
