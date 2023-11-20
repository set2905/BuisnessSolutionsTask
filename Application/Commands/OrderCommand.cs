using Application.Abstractions;
using Application.DTO;

namespace Application.Commands;

public abstract record OrderCommand(OrderDto orderDto) : ICommand;
