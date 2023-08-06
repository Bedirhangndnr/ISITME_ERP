using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ProductDtos;
using MyBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Abstract
{
    public interface IProductRepository:IEntityRepository<Product>
    {
        public Task<IList<ProductListWithRelatedTables>> GetAllWithNamesAsync(Expression<Func<Product, bool>> predicate = null, params Expression<Func<Product, object>>[] includeProperties);


    }
}
