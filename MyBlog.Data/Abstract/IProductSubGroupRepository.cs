using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ProductSubGroupDtos;
using MyBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Abstract
{
    public interface IProductSubGroupRepository:IEntityRepository<ProductSubGroup>
    {
        Task<IList<ProductSubGroupListWithRelatedTable>> GetAllWithNamesAsync(Expression<Func<ProductSubGroup, bool>> predicate = null, params Expression<Func<ProductSubGroup, object>>[] includeProperties);
    }
}
