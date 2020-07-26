using AutoMapper;
using E_commerce.DTOs;
using E_Commerce.Models;
using Microsoft.Extensions.Configuration;

namespace E_commerce.Helpers
{
    public class ProductResolver : IValueResolver<Product, ProductToReturnDTO, string>
    {
        private readonly IConfiguration _config;
        public ProductResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Product source, ProductToReturnDTO destination, string destMember, ResolutionContext resolutionContext)
        {
            if(!string.IsNullOrEmpty(source.StockPictureUrl))
            {
                return _config["ApiUrl"] + source.StockPictureUrl;
            }

            return null;
        }
    }
}