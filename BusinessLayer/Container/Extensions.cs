﻿using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.Announcement;
using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDestinationService,DestinationMenager>();
            services.AddScoped<IDestinationDal,EfDestinationDal>();
         
            services.AddScoped<IGuideService,GuideMenager>();
            services.AddScoped<IGuideDal,EfGuideDal>();

            services.AddScoped<IReCommentService,ReCommentMenager>();
            services.AddScoped<IReCommentDal,EfReCommentDal>();

            services.AddScoped<IAppUserService,AppUserMenager>();
            services.AddScoped<IAppUserDal,EfAppUserDal>();

            services.AddScoped<IAnnouncementService,AnnouncementMenager>();
            services.AddScoped<IAnnouncementDal,EfAnnouncementDal>();

            services.AddScoped<IAddressService,AddressMenager>();
            services.AddScoped<IAddressDal,EfAddressDal>();

            services.AddScoped<IContactDal,EfContactDal>();
            services.AddScoped<IContactService,ContactMenager>();

            services.AddScoped<INewsLetterService,NewsLetterMenager>();
            services.AddScoped<INewsLetterDal,EfNewsLetterDal>();

            services.AddScoped<IReservationService,ReservationMenager>();
            services.AddScoped<IReservationDal,EfReservationDal>();

            services.AddScoped<ITestimonialService,TestimonialMenager>();
            services.AddScoped<ITestimonialDal,EfTestimonialDal>(); 
        }
       
    }
}
