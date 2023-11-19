using Domain.Entities;

namespace Domain.Repositories;

public interface IOrderRepository
{
    void Add(Order order);
    Task<Order?> GetByIdAsync(OrderId orderId);
    Task<List<Order>> GetOrders(int page);
}