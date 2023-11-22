namespace Persistence.Repositories
{
    public interface IOrderItemRepository
    {
        /// <summary>
        /// Получить уникальные имена элементов заказа (например, для фильтрации)
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        Task<List<string>> GetOrderItemNamesAsync(string? search);
        /// <summary>
        /// Получить уникальные имена подразделений элементов заказа (например, для фильтрации)
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        Task<List<string>> GetOrderItemUnitsAsync(string? search);
    }
}