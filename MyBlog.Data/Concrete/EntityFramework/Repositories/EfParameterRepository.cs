using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ParameterDtos;
using MyBlog.Entities.Dtos.EmployeeDtos;
using MyBlog.Shared.Data.Concrete.EntityFramework;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfParameterRepository : EfEntityRepositoryBase<Parameter>, IParameterRepository
    {
        public EfParameterRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public Task<IList<Parameter>> GetAllForRemaindAsync()
        {
            throw new NotImplementedException();
        }
    }
}
