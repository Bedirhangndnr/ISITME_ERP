using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CustomerDtos;
using MyBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Abstract
{
    public interface ICustomerRepository:IEntityRepository<Customer>
    {
        public Task<IList<CustomerListWithRelatedTable>> GetAllWithRelatedTablesAsync(Expression<Func<Customer, bool>> predicate = null, params Expression<Func<Customer, object>>[] includeProperties);
        Task<IList<Customer>> GetAllForRemaindAsync();
    }
}
