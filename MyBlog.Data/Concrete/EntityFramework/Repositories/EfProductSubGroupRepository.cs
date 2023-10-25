using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Entities.Dtos.ProductSubGroupDtos;
using MyBlog.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfProductSubGroupRepository : EfEntityRepositoryBase<ProductSubGroup>, IProductSubGroupRepository
    {
        public EfProductSubGroupRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<ProductSubGroupListWithRelatedTable>> GetAllWithNamesAsync(Expression<Func<ProductSubGroup, bool>> predicate = null, params Expression<Func<ProductSubGroup, object>>[] includeProperties)
        {
            IQueryable<ProductSubGroup> query = _context.Set<ProductSubGroup>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            List<ProductSubGroupListWithRelatedTable> Appointments = await query
                .Include(s => s.ProductGroup)
                .Select(s => new ProductSubGroupListWithRelatedTable
                {
                    Id = s.Id,
                    GroupTitle = s.ProductGroup.Title != null ? s.ProductGroup.Title : "Belirtilmemiş Ya Da Silinmiş.",
                    GroupId = s.ProductGroupId != null ? s.ProductGroupId : 0,
                    Description = s.Description != null ? s.Description : "Belirtilmemiş Ya Da Silinmiş.",
                    Title = s.Title,
                }).ToListAsync();

            return Appointments;
        }
    }
}
