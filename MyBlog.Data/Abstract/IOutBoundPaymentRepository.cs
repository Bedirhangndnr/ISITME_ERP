using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentDtos;
using MyBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Abstract
{
    public interface IPaymentRepository:IEntityRepository<Payment>
    {
        public Task<IList<PaymentListWithRelatedTables>> GetAllWithNamesAsync(Expression<Func<Payment, bool>> predicate = null, params Expression<Func<Payment, object>>[] includeProperties);

    }
}
