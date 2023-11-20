using Domain.Entities;

namespace Domain.Repositories;

public interface IOrderRepository
{
    void Add(Order order);
    Task<Order?> GetByIdAsync(OrderId orderId);
    Task<List<Order>> GetOrdersAsync(int page, DateTime startDate, DateTime endDate);
    Task<bool> IsOrderUnique(OrderId? id, string orderNumber, ProviderId providerId);
    void Update(Order order);
}