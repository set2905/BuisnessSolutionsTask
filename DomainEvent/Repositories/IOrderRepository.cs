using Domain.Entities;

namespace Domain.Repositories;

public interface IOrderRepository
{
    void Add(Order order);
    void Remove(Order order);

    /// <summary>
    /// Получить страницу заказов между <paramref name="startDate"/> и <paramref name="endDate"/>. 
    /// Опционально применить фильтр <paramref name="filter"/>
    /// </summary>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="page"></param>
    /// <param name="filter"></param>
    /// <returns></returns>
    Task<List<Order>> GetOrdersAsync(DateTime startDate, DateTime endDate, int page, OrderFilter? filter);
    /// <summary>
    /// Найти заказ по <paramref name="orderId"/>
    /// </summary>
    /// <param name="orderId"></param>
    /// <returns></returns>
    Task<Order?> GetByIdAsync(OrderId orderId);
    /// <summary>
    /// Существует ли другой заказ с <paramref name="orderNumber"/> и <paramref name="providerId"/>, кроме заказа с <paramref name="id"/>
    /// </summary>
    /// <param name="id"></param>
    /// <param name="orderNumber"></param>
    /// <param name="providerId"></param>
    /// <returns></returns>
    Task<bool> IsOrderUnique(OrderId? id, string orderNumber, ProviderId providerId);
    void Update(Order order);
    /// <summary>
    /// Найти номера заказов (например, для фильтрации)
    /// </summary>
    /// <param name="search"></param>
    /// <returns></returns>
    Task<List<string>> GetOrderNumbersAsync(string? search);
}