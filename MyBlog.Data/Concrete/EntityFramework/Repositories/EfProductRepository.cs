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
     .Include(s => s.SubModel)
     .Include(s => s.Model)
     .Include(s => s.Model.Brand)
     .Select(s => new ProductListWithRelatedTables
     {
         Id = s.Id,
         SubModelId = s.SubModel != null ? s.SubModel.Id : 0, // Örnek bir değer atama
         SubModelTitle = s.SubModel != null ? s.SubModel.Title : string.Empty, // Örnek bir değer atama
         ModelId = s.Model != null ? s.Model.Id : 0, // Örnek bir değer atama
         ModelTitle = s.Model != null ? s.Model.Title : string.Empty, // Örnek bir değer atama
         SerialNumber = s.SerialNumber,
         Quantity = s.Quantity.Value,
         IsActive = s.IsActive,
         Note = s.Note,
         Price = s.Price,
         ProductName = s.ProductName,
         BrandTitle = s.Model.Brand.Title,
         IsProduct = s.IsProduct,
         SubTitleAndSerial = s.IsProduct == false
             ? s.Model.Title ?? string.Empty  // Sadece ModelTitle
             : (s.SubModel.Title ?? string.Empty) + " | " + (s.SerialNumber ?? string.Empty) + 
             (s.Quantity.Value < 3 ? " | " + s.Quantity.Value.ToString() : ""),  // SubModelTitle, SerialNumber ve gerekirse Quantity
     }).OrderBy(s => s.BrandTitle).ToListAsync();



            return Products;
        }

    }
}
