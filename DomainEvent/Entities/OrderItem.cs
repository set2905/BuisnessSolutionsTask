using Ardalis.GuardClauses;
using Domain.Errors;

namespace Domain.Entities;

public sealed class OrderItem
{
    private OrderItem()
    {
    }

    internal OrderItem(string name, decimal quantity, string unit)
    {
        Name=name;
        Quantity=quantity;
        Unit=unit;
    }

    public OrderItemId Id { get; private set; }
    public OrderId OrderId { get; private set; }
    public string Name { get; private set; }
    public decimal Quantity { get; private set; }
    public string Unit { get; private set; }


    public static OrderItem Create(string name, decimal quantity, string unit)
    {
        Guard.Against.NullOrEmpty(name, nameof(name), DomainErrors.OrderItem.EmptyName);
        Guard.Against.NullOrEmpty(unit, nameof(unit), DomainErrors.OrderItem.EmptyUnit);
        Guard.Against.Negative(quantity, nameof(quantity), DomainErrors.OrderItem.NegativeQuantity);
        var orderItem = new OrderItem(name, quantity, unit);
        return orderItem;
    }
}
public record OrderItemId(int Value);
