using Application.Abstractions;
using Application.DTO;
using Application.Messaging.Commands;

namespace Application.Messaging.Commands.UpdateOrder;

public sealed record UpdateOrderCommand : OrderCommand
{
    public UpdateOrderCommand(OrderDto orderDto) : base(orderDto)
    {
    }
}

