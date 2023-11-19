using Ardalis.GuardClauses;
using Ardalis.Result;
using Ardalis.Result.FluentValidation;
using Domain.Entities.Validation;
using FluentValidation;

namespace Domain.Entities;

public sealed class OrderItem
{
    private OrderItem()
    {
    }

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


    public static Result<OrderItem> Create(OrderId orderId, string name, decimal quantity, string unit)
    {
        OrderItem orderItem = new(orderId, name, quantity, unit);
        OrderItemValidator validator = new();
        var validation = validator.Validate(orderItem);
        if (!validation.IsValid) return Result<OrderItem>.Invalid(validation.AsErrors());
        return Result.Success(orderItem);
    }
}
public record OrderItemId(int Value);
