using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toro.API.Dtos;
using Toro.API.Models;

namespace Toro.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserRegisterDto, User>();
            CreateMap<UserGeneralDto, User>().ReverseMap();
            CreateMap<UserLoginDto, User>();
        }
    }
}
