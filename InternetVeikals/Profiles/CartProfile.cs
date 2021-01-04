using AutoMapper;
using InternetVeikals.DTOs.Cart;
using InternetVeikals.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Profiles
{
    public class CartProfile : Profile
    {
        public CartProfile()
        {
            CreateMap<Cart, CartReadDTO>();
          
        }
    }
}
