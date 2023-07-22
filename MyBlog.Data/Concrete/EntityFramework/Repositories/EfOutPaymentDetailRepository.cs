using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.OutPaymentDetailDtos;
using MyBlog.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfOutPaymentDetailRepository : EfEntityRepositoryBase<OutPaymentDetail>, IOutPaymentDetailRepository
    {
        public EfOutPaymentDetailRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
