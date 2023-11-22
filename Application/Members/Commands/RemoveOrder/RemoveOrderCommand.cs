using Application.Abstractions;
using Domain.Entities;

namespace Application.Members.Commands.RemoveOrder;

public sealed record RemoveOrderCommand(OrderId id) : ICommand;