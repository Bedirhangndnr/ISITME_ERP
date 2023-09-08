﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;
using MyBlog.Entities.Dtos.MessageToDeveloperDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class MessageToDeveloperProfile : Profile
    {
        public MessageToDeveloperProfile()
        {
            CreateMap<MessageToDeveloperAddDto, MessageToDeveloper>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            //    .ForMember(dest => dest.ModifiedByName, opt => opt.MapFrom(x => x.CreatedByName))
            //    .ForMember(dest=>dest.IsActive,opt=>opt.MapFrom(x=>false)); // dto dan Customere aktarılırken ısactive değeri default olarak false atandı.
            CreateMap<MessageToDeveloperUpdateDto, MessageToDeveloper>() 
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<MessageToDeveloper, MessageToDeveloperUpdateDto>();

        }
    }
}