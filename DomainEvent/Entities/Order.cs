using Ardalis.GuardClauses;

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
    public Provider Provider { get; private set; } = null!;
    public IReadOnlyCollection<OrderItem> Items => items;

    public OrderItem AddOrderItem(string name, decimal quantity, string unit)
    {
        var item = OrderItem.Create(Id, name, quantity, unit);
        items.Add(item);
        return item;
    }
    public static Order Create(string number, DateTime date, ProviderId providerId)
    {
        Guard.Against.NullOrEmpty(number, nameof(number), "The order number must not be empty");
        Order order = new Order(number, date, providerId);
        return order;
    }
}

public record OrderId(int Value);
