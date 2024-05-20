using AutoMapper;
using DTOLayer.DTOs.Announcement;
using EntityLayer.Concrete;

namespace TraversalCoreProject.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDTO,Announcement>();
            CreateMap<Announcement, AnnouncementAddDTO>();

            CreateMap<AnnouncementListDto, Announcement>();
            CreateMap<Announcement,AnnouncementListDto>();
        }
    }
}
