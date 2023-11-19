using Application.Abstractions;
using Application.DTO;
using Domain.Entities;

namespace Application.Commands.CreateOrder;

public sealed record CreateOrderCommand(OrderDto orderDto) : ICommand;
