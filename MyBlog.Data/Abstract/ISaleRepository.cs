using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.SaleDtos;
using MyBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Abstract
{
    public interface ISaleRepository : IEntityRepository<Sale>
    {
        public Task<IList<SaleListWithRelatedTables>> GetAllForProductCareAsync(Expression<Func<Sale, bool>> predicate = null, params Expression<Func<Sale, object>>[] includeProperties);
        public Task<IList<SaleListWithRelatedTables>> GetAllWithNamesAsync(Expression<Func<Sale, bool>> predicate = null, params Expression<Func<Sale, object>>[] includeProperties);
    }
}
