using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ModelDtos;
using MyBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Abstract
{
    public interface IModelRepository:IEntityRepository<Model>
    {
        Task<IList<ModelListWithRelatedTable>> GetAllWithNamesAsync(Expression<Func<Model, bool>> predicate = null, params Expression<Func<Model, object>>[] includeProperties);

    }
}
