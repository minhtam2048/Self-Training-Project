using AutoMapper;
using E_commerce.DTOs;
using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDTO>()
                .ForMember(destination => destination.Brand, option => option.MapFrom(source => source.Brand.Name))
                .ForMember(destination => destination.Category, option => option.MapFrom(source => source.Category.Name))
                .ForMember(destination => destination.StockPictureUrl, option => option.MapFrom<ProductResolver>());
        }
    }
}
