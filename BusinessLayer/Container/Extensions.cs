using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
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
        }
    }
}
