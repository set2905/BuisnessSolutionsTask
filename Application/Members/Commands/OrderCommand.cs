using Application.Abstractions;
using Application.DTO;

namespace Application.Messaging.Commands;

public abstract record OrderCommand(OrderDto orderDto) : ICommand;
