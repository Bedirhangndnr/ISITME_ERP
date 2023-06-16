using MyBlog.Entities.Dtos;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AssociatedInstitutionDtos;
using MyBlog.Entities.Dtos.SaleDtos;

namespace MyBlog.Services.Abstract
{
    public interface IAssociatedInstitutionService : IGenericService<AssociatedInstitution>
    {
        //Task<IDataResult<AssociatedInstitutionDto>> GetAsync(int AssociatedInstitutionId);
        Task<IDataResult<AssociatedInstitutionListDto>> GetAllByNonDeletedAndActiveAsync(int id,int paymentTypeId);
    }
}