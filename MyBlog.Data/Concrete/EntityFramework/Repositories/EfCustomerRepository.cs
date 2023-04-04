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
    public class EfCustomerRepository : EfEntityRepositoryBase<Customer>, ICustomerRepository
    {
        public EfCustomerRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<Customer>> GetAllForRemaindAsync()
        {
            var today = DateTime.Today;
            var query = _context.Set<Customer>()
                .Where(x =>
                    (x.BirthDate != null && (x.BirthDate.DayOfYear - today.DayOfYear < 3)) ||
                    (x.CreatedDate.AddDays(25) <= today && x.CreatedDate.AddDays(30) >= today) ||
                    (x.CreatedDate.AddDays(360) <= today && x.CreatedDate.AddDays(365) > today)||
                    (x.CreatedDate.AddDays(175) <= today && x.CreatedDate.AddDays(180) > today)
                    )
                .Select(x => new Customer
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    BirthDate = x.BirthDate,
                    CreatedDate = x.CreatedDate
                });

            return await query.ToListAsync();
        }
    }
}
