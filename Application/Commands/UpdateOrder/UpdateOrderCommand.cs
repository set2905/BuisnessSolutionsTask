using Application.Abstractions;
using Application.DTO;

namespace Application.Commands.UpdateOrder;

public sealed record UpdateOrderCommand : OrderCommand
{
    public UpdateOrderCommand(OrderDto orderDto) : base(orderDto)
    {
    }
}

