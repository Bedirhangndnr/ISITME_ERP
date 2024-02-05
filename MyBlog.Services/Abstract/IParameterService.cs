using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ParameterDtos;
using MyBlog.Entities.Dtos;

namespace MyBlog.Services.Abstract
{
    public interface IParameterService : IGenericService<Parameter>
    {
        Task<IDataResult<ParameterDto>> GetAsync(int CustomerId);
        Task<IDataResult<ParameterListDto>> GetAllAsync();
        Task<IDataResult<ParameterListDto>> GetForSGK();
    }
}