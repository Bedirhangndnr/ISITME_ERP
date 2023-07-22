﻿using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfCustomerTypeRepository : EfEntityRepositoryBase<CustomerType>, ICustomerTypeRepository
    {
        public EfCustomerTypeRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
