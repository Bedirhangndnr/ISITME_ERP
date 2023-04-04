using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.EmployeeDtos;
using MyBlog.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfEmployeeRepository : EfEntityRepositoryBase<Employee>, IEmployeeRepository
    {
        public EfEmployeeRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IList<EmployeeListWithRelatedTable>> GetAllWithRelatedTablesAsync(Expression<Func<Employee, bool>> predicate = null, params Expression<Func<Employee, object>>[] includeProperties)
        {
            IQueryable<Employee> query = _context.Set<Employee>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            List<EmployeeListWithRelatedTable> Employees = await query
                .Include(s => s.EmployeeType)
                .Select(s => new EmployeeListWithRelatedTable
                {
                    Picture=s.Picture,
                    EmployeeTypeId = s.EmployeeTypeId ?? 0,
                    Address = s.Address,
                    Email = s.Email,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    EmployeeTypeTitle = s.EmployeeType != null ? s.EmployeeType.Title : "Personel tipi bulunamadı, silinmiş olabilir.",
                    Phone = s.Phone,
                    TC = s.TC,
                    Id = s.Id,
                    About = s.About,
                }).ToListAsync();

            return Employees;
        }
    }
}
