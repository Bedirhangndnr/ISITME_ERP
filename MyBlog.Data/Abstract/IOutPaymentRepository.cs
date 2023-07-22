using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.OutPaymentDtos;
using MyBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Abstract
{
    public interface IOutPaymentRepository:IEntityRepository<OutPayment>
    {

    }
}
