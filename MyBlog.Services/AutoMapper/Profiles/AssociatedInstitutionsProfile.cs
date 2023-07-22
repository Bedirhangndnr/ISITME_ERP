using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AssociatedInstitutionDtos;
using MyBlog.Entities.Dtos.ProgramsDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class AssociatedInstitutionsProfile:Profile
    {
        public AssociatedInstitutionsProfile()
        {
            CreateMap<AssociatedInstitutionListDto, AssociatedInstitution>().ReverseMap();
        }
    }
}
