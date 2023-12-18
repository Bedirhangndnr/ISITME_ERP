using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CustomerDtos;
using MyBlog.Entities.Dtos.EmployeeDtos;
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
            var endDate = today.AddDays(3); // Önümüzdeki 3 gün

            var query = _context.Set<Customer>()
                .Where(x =>
                    x.BirthDate.HasValue &&
                    (
                        (x.BirthDate.Value.Month > today.Month) ||
                        (x.BirthDate.Value.Month == today.Month && x.BirthDate.Value.Day >= today.Day) &&
                        (x.BirthDate.Value.Month < endDate.Month) ||
                        (x.BirthDate.Value.Month == endDate.Month && x.BirthDate.Value.Day <= endDate.Day)
                    )
                )
                .Select(x => new Customer
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    BirthDate = x.BirthDate,
                    CreatedDate = x.CreatedDate
                }).OrderBy(x => x.CreatedDate);

            return await query.ToListAsync();
        }

        public async Task<IList<CustomerListWithRelatedTable>> GetAllWithRelatedTablesAsync(Expression<Func<Customer, bool>> predicate = null, params Expression<Func<Customer, object>>[] includeProperties)
        {
            IQueryable<Customer> query = _context.Set<Customer>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            List<CustomerListWithRelatedTable> Customers = await query
                .Include(s => s.CustomerType)
                .Include(s => s.Sales)
                .Select(s => new CustomerListWithRelatedTable
                {
                    Picture = s.Picture,
                    CustomerTypeId = s.CustomerTypeId ?? 0,
                    Address = s.Address,
                    Email = s.Email,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    CustomerTypeTitle = s.CustomerType != null ? s.CustomerType.Title : "Hasta tipi bulunamadı, silinmiş olabilir.",
                    Phone = s.Phone,
                    TC = s.TC,
                    Id = s.Id,
                    Note = s.Note != null ? s.Note : "Not bulunamadı.",
                    Sales= s.Sales
                }).ToListAsync();

            return Customers;
        }
    }
}
