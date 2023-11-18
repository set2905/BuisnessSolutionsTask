using Ardalis.GuardClauses;

namespace DomainEvent.Entities;

public sealed class Order
{
    private readonly HashSet<OrderItem> items = new();

    private Order(OrderId id, string number, DateTime date)
    {
        Id=id;
        Number=number;
        Date=date;
    }

    public OrderId Id { get; private set; }
    public string Number { get; private set; }
    public DateTime Date { get; private set; }
    public IReadOnlyCollection<OrderItem> Items => items;

    public static Order Create(OrderId id, string number, DateTime date, ICollection<OrderItem> items)
    {
        Guard.Against.NullOrEmpty(number, nameof(number), "The order number must not be empty");

        Order order = new Order(id, number, date);
        return order;
    }
}

public record OrderId(int Value);
