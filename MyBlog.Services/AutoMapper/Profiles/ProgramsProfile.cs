using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ProgramsDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class ProgramsProfile:Profile
    {
        public ProgramsProfile()
        {
            CreateMap<ProgramDto, Program>().ReverseMap();
            CreateMap<SubProgramDto, SubProgram>().ReverseMap();
            CreateMap<ModuleDto, Module>().ReverseMap();
            CreateMap<ProgramListDto, Program>().ReverseMap();
            CreateMap<SubProgramListDto, SubProgram>().ReverseMap();
            CreateMap<ModuleListDto, Module>().ReverseMap();
        }
    }
}
