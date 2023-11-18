using Ardalis.GuardClauses;

namespace Domain.Entities;

public sealed class OrderItem
{
    internal OrderItem(OrderId orderId, string name, decimal quantity, string unit)
    {
        Id=new(0);
        OrderId=orderId;
        Name=name;
        Quantity=quantity;
        Unit=unit;
    }

    public OrderItemId Id { get; private set; }
    public OrderId OrderId { get; private set; }
    public string Name { get; private set; }
    public decimal Quantity { get; private set; }
    public string Unit { get; private set; }


    public static OrderItem Create(OrderId orderId, string name, decimal quantity, string unit)
    {
        Guard.Against.NullOrEmpty(name, nameof(name), "Order item name cannot be empty");
        Guard.Against.NullOrEmpty(unit, nameof(unit), "Order item unit cannot be empty");
        Guard.Against.Negative(quantity, nameof(quantity), "Quantity cannot be negative");
        var orderItem = new OrderItem(orderId, name, quantity, unit);
        return orderItem;
    }
}
public record OrderItemId(int Value);
