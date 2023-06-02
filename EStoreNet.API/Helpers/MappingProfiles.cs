using AutoMapper;
using EStoreNet.API.DTOs;
using EStoreNet.Core.Entitites;

namespace EStoreNet.API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(d => d.productBrand, o => o.MapFrom(s => s.productBrand.Name))
                .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                .ForMember(p => p.PictureUrl, o => o.MapFrom<ProductUrlResolver>());


        }

    }
}
