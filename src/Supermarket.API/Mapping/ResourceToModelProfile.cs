using AutoMapper;
using Supermarket.API.Resources;

namespace Supermarket.API.Mapping
{
	public class ResourceToModelProfile : Profile
	{
		public ResourceToModelProfile()
		{
			CreateMap<SaveCategoryResource, Category>();
			
			CreateMap<SaveProductResource, Product>()
				.ForMember(src => src.UnitOfMeasurement, opt => opt.MapFrom(src => (UnitOfMeasurement)src.UnitOfMeasurement));
			
			CreateMap<ProductsQueryResource, ProductsQuery>();
		}
	}
}