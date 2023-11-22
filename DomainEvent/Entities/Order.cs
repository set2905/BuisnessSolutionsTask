using Ardalis.GuardClauses;
using Domain.Errors;

namespace Domain.Entities;

public sealed class Order
{
    private readonly HashSet<OrderItem> items = new();

    private Order()
    {
    }
    private Order(string number, DateTime date, ProviderId providerId, IEnumerable<OrderItem> items)
    {
        Number=number;
        Date=date;
        ProviderId=providerId;
        this.items=items.ToHashSet();
    }

    public OrderId Id { get; private set; }
    public string Number { get; private set; }
    public DateTime Date { get; private set; }
    public ProviderId ProviderId { get; private set; }
    public Provider Provider { get; private set; } = null!;
    public IReadOnlyCollection<OrderItem> Items => items;

    public OrderItem AddOrderItem(string name, decimal quantity, string unit)
    {
        var item = OrderItem.Create(name, quantity, unit);
        items.Add(item);
        return item;
    }

    public void RemoveOrderItem(OrderItemId id)
    {
        items.RemoveWhere(x => x.Id==id);
    }
    public void Modify(string number, DateTime date, ProviderId providerId)
    {
        Guard.Against.NullOrEmpty(number, nameof(number), DomainErrors.Order.EmptyNumber);
        Number = number;
        Date = date;
        ProviderId = providerId;
    }
    public static Order Create(string number, DateTime date, ProviderId providerId, IList<OrderItem> items)
    {
        Guard.Against.NullOrEmpty(number, nameof(number), DomainErrors.Order.EmptyNumber);
        Order order = new Order(number, date, providerId, items);
        return order;
    }
}

public record OrderId(int Value);
