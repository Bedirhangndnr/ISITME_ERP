using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;
using MyBlog.Entities.Dtos.ModelDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class ModelProfile:Profile
    {
        public ModelProfile()
        {
            CreateMap<ModelAddDto, Model>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            //    .ForMember(dest => dest.ModifiedByName, opt => opt.MapFrom(x => x.CreatedByName))
            //    .ForMember(dest=>dest.IsActive,opt=>opt.MapFrom(x=>false)); // dto dan Customere aktarılırken ısactive değeri default olarak false atandı.
            CreateMap<ModelUpdateDto, Model>() 
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Model, ModelUpdateDto>();

        }
    }
}
