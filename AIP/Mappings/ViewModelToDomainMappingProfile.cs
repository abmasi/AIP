using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using AIP.Model;
using AIP.ViewModel;

namespace AIP.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile() : base("ViewModelToDomainMappings")
        {
            ConfigureProfile();
        }

        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappings";
            }
        }

        private void ConfigureProfile()
        {
            
        }
    }
}