namespace Persistence.Repositories
{
    public interface IOrderItemRepository
    {
        Task<List<string>> GetOrderItemNamesAsync(string? search);
        Task<List<string>> GetOrderItemUnitsAsync(string? search);
    }
}