using Ardalis.GuardClauses;
using Ardalis.Result;
using Ardalis.Result.FluentValidation;
using Domain.Entities.Validation;

namespace Domain.Entities;

public sealed class Order
{
    private readonly HashSet<OrderItem> items = new();

    private Order()
    {
    }
    private Order(string number, DateTime date, ProviderId providerId)
    {
        Id=new(0);
        Number=number;
        Date=date;
        ProviderId=providerId;
    }

    public OrderId Id { get; private set; }
    public string Number { get; private set; }
    public DateTime Date { get; private set; }
    public ProviderId ProviderId { get; private set; }
    public IReadOnlyCollection<OrderItem> Items => items;

    public OrderItem AddOrderItem(string name, decimal quantity, string unit)
    {
        var item = OrderItem.Create(Id, name, quantity, unit);
        items.Add(item);
        return item;
    }
    public static Result<Order> Create(string number, DateTime date, ProviderId providerId)
    {
        Order order = new Order(number, date, providerId);
        var validator = new OrderValidator();
        var validation = validator.Validate(order);
        if (!validation.IsValid) return Result<Order>.Invalid(validation.AsErrors());
        return Result.Success(order);
    }
}

public record OrderId(int Value);
