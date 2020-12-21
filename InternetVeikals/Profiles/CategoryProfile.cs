using AutoMapper;
using InternetVeikals.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Profiles
{
    public class CategoryProfile : Profile
    {
        public  CategoryProfile()
        {
            CreateMap<Category, CategoryUpdateDto>();
            CreateMap<CategoryUpdateDto, Category>();
        }
    }
}
