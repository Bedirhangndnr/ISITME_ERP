using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ModelDtos;
using MyBlog.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfModelRepository : EfEntityRepositoryBase<Model>, IModelRepository
    {
        public EfModelRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IList<ModelListWithRelatedTable>> GetAllWithNamesAsync(Expression<Func<Model, bool>> predicate = null, params Expression<Func<Model, object>>[] includeProperties)
        {
            IQueryable<Model> query = _context.Set<Model>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            List<ModelListWithRelatedTable> Appointments = await query
                .Include(s => s.Brand)
                .Select(s => new ModelListWithRelatedTable
                {
                    Id = s.Id,
                    BrandTitle = s.Brand.Title != null ? s.Brand.Title : "Belirtilmemiş Ya Da Silinmiş.",
                    BrandId = s.BrandId != null ? s.BrandId : 0,
                    Description = s.Description != null ? s.Description : "Belirtilmemiş Ya Da Silinmiş.",
                    Title = s.Title,
                }).ToListAsync();

            return Appointments;
        }
    }
}
