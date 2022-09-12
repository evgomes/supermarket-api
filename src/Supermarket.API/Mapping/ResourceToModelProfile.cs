using AutoMapper;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Models.Queries;
using Supermarket.API.Resources;

namespace Supermarket.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();

            CreateMap<SaveProductResource, Product>()
                .ForMember(src => src.UnitOfMeasurement, opt => opt.MapFrom(src => src.UnitOfMeasurement.GetHashCode()));

            CreateMap<ProductsQueryResource, ProductsQuery>();
        }
    }
}