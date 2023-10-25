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
    public interface IModelService : IGenericService<Model>
    {
        Task<IDataResult<ModelDto>> GetAsync(int ModelId);
        Task<IDataResult<ModelUpdateDto>> GetModelUpdateDtoAsync(int ModelId);
        Task<IDataResult<ModelListDto>> GetAllAsync();
        Task<IDataResult<ModelDto>> DeleteAsync(int ModelId, string modifiedByName);
        Task<IDataResult<ModelListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<ModelDto>> AddAsync(ModelAddDto ModelAddDto, string createdByName);
        Task<IDataResult<ModelDto>> UpdateAsync(ModelUpdateDto ModelUpdateDto, string modifiedByName);

        Task<IDataResult<ModelListDto>> GetAllByDeletedAsync();
        Task<IDataResult<ModelDto>> UndoDeleteAsync(int EmployeeTypeId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int EmployeeTypeId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();

    }
}