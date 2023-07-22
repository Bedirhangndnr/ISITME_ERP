using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.EmployeeDtos;
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
    public interface IEmployeeRepository:IEntityRepository<Employee>
    {
        public Task<IList<EmployeeListWithRelatedTable>> GetAllWithRelatedTablesAsync(Expression<Func<Employee, bool>> predicate = null, params Expression<Func<Employee, object>>[] includeProperties);

    }
}
