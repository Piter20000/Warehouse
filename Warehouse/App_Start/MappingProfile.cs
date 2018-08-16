using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;
using AutoMapper;
using Warehouse.Dtos;
using Warehouse.Models;

namespace Warehouse.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<SteelProfile, SteelProfileDto>();
            Mapper.CreateMap<ProfileDetails, ProfileDetailsDto>();
            Mapper.CreateMap<ProjectInformations, ProjectInformationsDto>();
            Mapper.CreateMap<Status, StatusDto>();

            // Dto to Domain:
            Mapper.CreateMap<SteelProfileDto, SteelProfile>()
                .ForMember(c => c.Id, op => op.Ignore());
            Mapper.CreateMap<ProfileDetailsDto, ProfileDetails>()
                .ForMember(c => c.Id, op => op.Ignore());
            Mapper.CreateMap<ProjectInformationsDto, ProjectInformations>()
                .ForMember(c => c.Id, op => op.Ignore());
            Mapper.CreateMap<StatusDto, Status>()
                .ForMember(c => c.Id, op => op.Ignore());
        }
    }
}