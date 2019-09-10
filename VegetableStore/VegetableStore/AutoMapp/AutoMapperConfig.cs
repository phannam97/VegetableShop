using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegetableStore.AutoMapp
{
    public class AutoMapperConfig
    {
        public  MapperConfiguration Configure()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ViewModelToDomainMappingProfile>();
                cfg.AddProfile<DomainToViewModelMappingProfile>();
                cfg.AllowNullCollections = true;
            });
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ViewModelToDomainMappingProfile>();
                cfg.AddProfile<DomainToViewModelMappingProfile>();
                cfg.AllowNullCollections = true;
            });
            return config;
        }
    }
}
