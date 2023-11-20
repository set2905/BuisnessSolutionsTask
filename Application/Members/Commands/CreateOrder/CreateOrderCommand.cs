using Application.Abstractions;
using Application.DTO;
using Application.Messaging.Commands;
using Domain.Entities;

namespace Application.Messaging.Commands.CreateOrder;

public sealed record CreateOrderCommand : OrderCommand
{
    public CreateOrderCommand(OrderDto orderDto) : base(orderDto)
    {
    }
}
