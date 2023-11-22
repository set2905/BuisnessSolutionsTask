using Application.DTO;

namespace Application.Messaging.Commands.CreateOrder;

public sealed record CreateOrderCommand : OrderCommand
{
    public CreateOrderCommand(OrderDto orderDto) : base(orderDto)
    {
    }
}
