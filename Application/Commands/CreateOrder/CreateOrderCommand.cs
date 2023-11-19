using Application.Abstractions;
using Domain.Entities;

namespace Application.Commands.CreateOrder;

public sealed record CreateOrderCommand(string number, DateTime date, ProviderId providerId) : ICommand;
