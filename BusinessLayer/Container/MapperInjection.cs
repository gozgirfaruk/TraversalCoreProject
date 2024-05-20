using AutoMapper;
using BusinessLayer.MapperProfile;
using BusinessLayer.ValidationRules;
using DTOLayer.DTOs.Announcement;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class MapperInjection
    {
        public static void MapperProfile(this IServiceCollection services)
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new AnnouncementProfile());
            });

            IMapper mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);

        }

        public static void CustomerValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDTO>,AnnouncementValidator>();
        }
    }
}
