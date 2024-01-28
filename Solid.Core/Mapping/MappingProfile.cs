using Amazon.OpsWorks.Model;
using AutoMapper;
using project_Riki_Mittelman.Entities;
using Solid.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid.Core.Mapping
{
    internal class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<DTORecepies, Recipes>().ReverseMap();
            CreateMap<DTOProduct,Products>().ReverseMap();
        }
    }
}
