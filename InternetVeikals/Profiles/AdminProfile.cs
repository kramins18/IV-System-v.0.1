using AutoMapper;
using InternetVeikals.DTOs.Admin;
using InternetVeikals.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Profiles
{
    public class AdminProfile : Profile
    {
        public AdminProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Admin, AdminDTO>();
            //CreateMap<UserDto, User>();
        }
    }
}
