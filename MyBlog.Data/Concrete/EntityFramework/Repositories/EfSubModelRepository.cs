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
    public class EfSubModelRepository : EfEntityRepositoryBase<SubModel>, ISubModelRepository
    {
        public EfSubModelRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IList<SubModelListWithRelatedTable>> GetAllWithNamesAsync(Expression<Func<SubModel, bool>> predicate = null, params Expression<Func<SubModel, object>>[] includeProperties)
        {
            IQueryable<SubModel> query = _context.Set<SubModel>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            List<SubModelListWithRelatedTable> Appointments = await query
                .Include(s => s.Model)
                .Select(s => new SubModelListWithRelatedTable
                {
                    Id = s.Id,
                    BrandTitle = s.Model.Title != null ? s.Model.Title : "Belirtilmemiş Ya Da Silinmiş.",
                    BrandId = s.ModelId != null ? s.ModelId : 0,
                    Description = s.Description != null ? s.Description : "Belirtilmemiş Ya Da Silinmiş.",
                    Title = s.Title,
                }).ToListAsync();

            return Appointments;
        }
    }
}
