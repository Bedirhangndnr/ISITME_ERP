using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;
using MyBlog.Entities.Dtos.NotificationDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class NotificationProfile:Profile
    {
        public NotificationProfile()
        {
            CreateMap<NotificationAddDto, Notification>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now))
                .ReverseMap();
        }
    }
}
