using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AssociatedInstitutionDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using static MyBlog.Services.Utilities.Messages;

namespace MyBlog.Services.Concrete
{
    public class AssociatedInstitutionManager : ManagerBase, IAssociatedInstitutionService
    {
        public AssociatedInstitutionManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }


        public async Task<IDataResult<AssociatedInstitutionListDto>> GetAllByNonDeletedAndActiveAsync(int id, int paymentTId = 0)
        {
            if (paymentTId == 0)
            {
                var associatedInstitution = await UnitOfWork.AssociatedInstitutions.GetAsync(c => !c.IsDeleted && c.IsActive && c.Id == id);
                if (associatedInstitution == null)
                {
                    paymentTId = -1;
                }
                else
                {
                    paymentTId = associatedInstitution.PaymentTypeId;
                }
            }
            var associatedInstitutions = await UnitOfWork.AssociatedInstitutions.GetAllAsync(c => !c.IsDeleted && c.IsActive && c.PaymentTypeId == paymentTId);
            if (associatedInstitutions.Count > -1)
            {
                return new DataResult<AssociatedInstitutionListDto>(ResultStatus.Success, new AssociatedInstitutionListDto
                {
                    AssociatedInstitutions = associatedInstitutions,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<AssociatedInstitutionListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Randevu"));

        }
    }
}
