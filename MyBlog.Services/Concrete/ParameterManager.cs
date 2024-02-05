using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ParameterDtos;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using static MyBlog.Services.Utilities.Messages;
using MyBlog.Entities.Dtos;

namespace MyBlog.Services.Concrete
{
    public class ParameterManager : ManagerBase, IParameterService
    {
        public ParameterManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<ParameterDto>> GetAsync(int ParameterId)
        {
            var Parameter = await UnitOfWork.Parameters.GetAsync(c => c.Id == ParameterId);
            if (Parameter != null)
            {
                return new DataResult<ParameterDto>(ResultStatus.Success, new ParameterDto
                {
                    Parameter = Parameter,
                });
            }
            return new DataResult<ParameterDto>(ResultStatus.Error, new ParameterDto
            {
                Parameter = null,
            }, Messages.General.NotFound(isPlural: false, "Müşteri"));
        }
        public async Task<IDataResult<ParameterListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var parameters = await UnitOfWork.Parameters.GetAllAsync(x => !x.IsDeleted);
            if (parameters.Count > -1)
            {
                return new DataResult<ParameterListDto>(ResultStatus.Success, new ParameterListDto
                {
                    Parameters = parameters,
                    ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<ParameterListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));

        }

        public Task<IDataResult<ParameterListDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<IDataResult<ParameterListDto>> GetForSGK()
        {
            //ParamCode = "SGKTutari",
            //      ParamType = "Tutar Tipi 1",
            //      ParamValue = "1000"  // TUTAR
            var parameters = await UnitOfWork.Parameters.GetAllAsync(x => !x.IsDeleted && x.ParamCode == "SGKTutari");
            if (parameters.Count > -1)
            {
                return new DataResult<ParameterListDto>(ResultStatus.Success, new ParameterListDto
                {
                    Parameters = parameters,
                    ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<ParameterListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Hasta"));
        }
    }
}
