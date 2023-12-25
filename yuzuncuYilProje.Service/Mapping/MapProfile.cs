using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yuzuncuYilProje.Core.DTOs;
using yuzuncuYilProje.Core.Models;

namespace yuzuncuYilProje.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Team, TeamDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserProfile, UserProfileDto>().ReverseMap();

            //dto'dan entity'e çevirmek istersem;
            CreateMap<TeamDto, Team>();
        }
    }
}
