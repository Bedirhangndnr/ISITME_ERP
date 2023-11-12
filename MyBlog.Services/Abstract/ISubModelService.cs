using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentTypeDtos;
using MyBlog.Entities.Dtos.ModelDtos;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;
using MyBlog.Entities.Dtos.AppointmentTypeDtos;

namespace MyBlog.Services.Abstract
{
    public interface ISubModelService : IGenericService<SubModel>
    {
        Task<IDataResult<SubModelDto>> GetAsync(int SubModelId);
        Task<IDataResult<SubModelListDto>> GetAllAsync();
        Task<IDataResult<SubModelDto>> DeleteAsync(int SubModelId, string modifiedByName);
        Task<IDataResult<SubModelListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<SubModelListDto>> GetAllByModel(int modelId);
        Task<IDataResult<SubModelListDto>> GetAllByDeletedAsync();
        Task<IDataResult<SubModelDto>> UndoDeleteAsync(int EmployeeTypeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();

    }
}