using AutoMapper;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(configuration =>
        {
            configuration.CreateMap<ProductDto, Product>().ReverseMap();

            configuration.CreateMap<CategoryDto, Category>().ReverseMap();

            configuration.CreateMap<ImageDto, Image>().ReverseMap();

            configuration.CreateMap<ProductImageDto, ProductImage>().ReverseMap();
        });

        return mappingConfig;
    }
}
