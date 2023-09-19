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
            var query = _context.Set<Customer>()
                .Where(x =>
                    (x.BirthDate != null && (x.BirthDate.DayOfYear - today.DayOfYear < 3)) ||
                    (x.CreatedDate.AddDays(25) <= today && x.CreatedDate.AddDays(30) >= today) ||
                    (x.CreatedDate.AddDays(360) <= today && x.CreatedDate.AddDays(365) > today) ||
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
        public async Task<IList<CustomerListWithRelatedTable>> GetAllWithRelatedTablesAsync(Expression<Func<Customer, bool>> predicate = null, params Expression<Func<Customer, object>>[] includeProperties)
        {
            IQueryable<Customer> query = _context.Set<Customer>();
            var salesQuery = _context.Set<Sale>();
            var productQuery = _context.Set<Product>();
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
                    // Satış tablosundan ilgili verileri ekliyoruz
                    Sales = salesQuery
                        .Where(sa => sa.CustomerId == s.Id)
                        .Select(sa => new Sale
                        {
                            Amount = sa.Amount,
                            // Diğer satış tablosu sütunlarını da ekleyebilirsiniz
                            Product=sa.Product,
                        })
            .ToList()
                }).ToListAsync();

            return Customers;
        }
    }
}
