using AutoMapper;
using DTOLayer.DTOs.Announcement;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.MapperProfile
{
    public class AnnouncementProfile : Profile
    {
        public AnnouncementProfile()
        {
            CreateMap<Announcement,AnnouncementListDto>().ForMember(target => target.Title,org=>org.MapFrom(x=>x.Title)).ReverseMap();
        }
    }
}
