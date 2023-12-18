using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Entities.Dtos.SaleDtos;
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
    public class EfSaleRepository : EfEntityRepositoryBase<Sale>, ISaleRepository
    {
        public EfSaleRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IList<SaleListWithRelatedTables>> GetAllForProductCareAsync(Expression<Func<Sale, bool>> predicate = null, params Expression<Func<Sale, object>>[] includeProperties)
        {
            IQueryable<Sale> query = _context.Set<Sale>();
            DateTime today = DateTime.Now;
            var Appointments = query
                .Include(x => x.Customer)
                .Where(x =>
                    (x.IsProduct  == 1)  ||
                    (x.CreatedDate.AddDays(25) == today)  ||
                    (x.CreatedDate.AddDays(360) == today) ||
                    (x.CreatedDate.AddDays(175) == today) ||
                    (x.CreatedDate.AddDays(85) == today)
                )
                .Select(x => new SaleListWithRelatedTables
                {
                    Id = x.Id,
                    CustomerFirstName = x.Customer.FirstName + " " + x.Customer.LastName,
                    CreatedDate = x.CreatedDate
                }).OrderBy(x => x.CreatedDate);

            return await Appointments.ToListAsync();
        }

        public async Task<IList<SaleListWithRelatedTables>> GetAllWithNamesAsync(Expression<Func<Sale, bool>> predicate = null, params Expression<Func<Sale, object>>[] includeProperties)
        {
            IQueryable<Sale> query = _context.Set<Sale>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            List<SaleListWithRelatedTables> sales = await query
                .Include(s => s.Customer)
                .Include(s => s.Employee)
                .Include(s => s.SaleType)
                .Include(s => s.SaleStatus)
                .Include(s => s.Product)
                .Select(s => new SaleListWithRelatedTables
                {
                    Id = s.Id,
                    AmountOfSgk = s.AmountOfSgk,
                    IsInvoiceDue = s.IsInvoiceDue,
                    CreatedDate = s.CreatedDate,
                    ModifiedDate = s.ModifiedDate,
                    Amount = s.Amount,
                    CustomerId = s.Customer.Id,
                    CustomerFirstName = s.Customer.FirstName,
                    EmployeeId = s.Employee.Id,
                    EmployeeFirstName = s.Employee.FirstName,
                    SaleTypeId = s.SaleType.Id,
                    SaleTypeName = s.SaleType.Title,
                    SaleStatusId = s.SaleStatus.Id,
                    SaleStatusName = s.SaleStatus.Title,
                    ProductId = s.Product.Id,
                    ProductName = s.Product.ProductName
                }).ToListAsync();

            return sales;
        }
    }
}
