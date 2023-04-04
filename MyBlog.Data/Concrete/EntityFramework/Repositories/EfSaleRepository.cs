using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
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
