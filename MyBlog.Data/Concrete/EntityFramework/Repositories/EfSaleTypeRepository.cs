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
    public class EfSaleTypeRepository : EfEntityRepositoryBase<SaleType>, ISaleTypeRepository
    {
        public EfSaleTypeRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}