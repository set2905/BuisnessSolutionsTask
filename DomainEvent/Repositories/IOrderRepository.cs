using Domain.Entities;

namespace Domain.Repositories;

public interface IOrderRepository
{
    void Add(Order order);
    Task<List<Order>> FindOrdersAsync(DateTime startDate, DateTime endDate, int page, OrderFilter? filter);
    Task<Order?> GetByIdAsync(OrderId orderId);
    Task<List<Order>> GetOrdersAsync(int page, DateTime startDate, DateTime endDate);
    Task<bool> IsOrderUnique(OrderId? id, string orderNumber, ProviderId providerId);
    void Update(Order order);
}