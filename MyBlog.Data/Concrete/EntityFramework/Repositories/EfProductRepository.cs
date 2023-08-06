using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ProductDtos;
using MyBlog.Entities.Dtos.SaleDtos;
using MyBlog.Shared.Data.Concrete.EntityFramework;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfProductRepository : EfEntityRepositoryBase<Product>, IProductRepository
    {
        public EfProductRepository(DbContext dbContext) : base(dbContext)
        {

        }
        public async Task<IList<ProductListWithRelatedTables>> GetAllWithNamesAsync(Expression<Func<Product, bool>> predicate = null, params Expression<Func<Product, object>>[] includeProperties)
        {
            IQueryable<Product> query = _context.Set<Product>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            List<ProductListWithRelatedTables> Products = await query
                .Include(s => s.ProductSubGroup)
                .Include(s => s.Brand)
                .Select(s => new ProductListWithRelatedTables
                {
                    Id = s.Id,
                    ProductSubGroupId = s.ProductSubGroup != null ? s.ProductSubGroup.Id : 0, // Örnek bir değer atama
                    ProductSubGroupTitle = s.ProductSubGroup != null ? s.ProductSubGroup.Title : string.Empty, // Örnek bir değer atama
                    BrandId = s.Brand != null ? s.Brand.Id : 0, // Örnek bir değer atama
                    BrandTitle = s.Brand != null ? s.Brand.Title : string.Empty, // Örnek bir değer atama
                    SerialNumber = s.SerialNumber,
                    IsActive = s.IsActive,
                    Note = s.Note,
                    Price = s.Price,
                    ProductName = s.ProductName,
                }).ToListAsync();


            return Products;
        }

    }
}
