using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegetableStore.AutoMapp
{
    public static class CustomMvcServiceCollectionExtensions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            var config = new AutoMapperConfig().Configure();
            services.AddSingleton<IMapper>(sp => config.CreateMapper());
        }
    }
}
