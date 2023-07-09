using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.Data.Concrete.EntityFramework;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfExpenseRepository : EfEntityRepositoryBase<Expense>, IExpenseRepository
    {
        private readonly DbContext _dbContext;

        public EfExpenseRepository(DbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<int>> GetDailyIncomeAsync(DateTime startDate, DateTime endDate)
        {
            IQueryable<Expense> query = _dbContext.Set<Expense>();

            return await query
                .Where(e => e.CreatedDate >= startDate && e.CreatedDate <= endDate && e.IsIncome)
                .Select(e => e.Amount)
                .ToListAsync();
        }


    }
}
