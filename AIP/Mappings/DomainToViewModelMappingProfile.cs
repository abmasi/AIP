using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using AIP.DATA;
using AIP.Model;
using AIP.Service;
using AIP.ViewModel;


namespace AIP.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() : base("DomainToViewModelMappings")
        {
            Mapper.Initialize(cfg => cfg.CreateMap<News, NewsViewModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<News, NewsDetailViewModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<Person, PersonViewModel>());
        }

        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }
    }
}