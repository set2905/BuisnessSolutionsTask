using Application.DTO;
using AutoMapper;
using Domain.Entities;

namespace Application.Automapper.Profiles;

public sealed class AppMapperProfile : Profile
{
    public AppMapperProfile()
    {
        CreateMap<Provider, ProviderDto>();
        CreateMap<OrderItem, OrderItemDto>();
        CreateMap<Order, OrderDto>().ForMember(x => x.Items, opt => opt.MapFrom<OrderItemsResolver>());
    }
}
public sealed class OrderItemsResolver : IValueResolver<Order, OrderDto, OrderItemDto[]>
{
    public OrderItemDto[] Resolve(Order source, OrderDto destination, OrderItemDto[] destMember, ResolutionContext context)
    {
        OrderItemDto[] result = source.Items.ToList()
            .ConvertAll(x => new OrderItemDto(x.Id, x.Name, x.Quantity, x.Unit))
            .ToArray();
        return result;
    }
}

