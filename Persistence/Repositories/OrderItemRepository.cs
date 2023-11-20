using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public sealed class OrderItemRepository : IOrderItemRepository
{
    private const int DEFAULT_PAGESIZE = 10;
    private readonly ApplicationDbContext dbContext;

    public OrderItemRepository(ApplicationDbContext dbContext)
    {
        this.dbContext=dbContext;
    }

    public async Task<List<string>> GetOrderItemNamesAsync(string? search)
    {
        var query = dbContext.Set<OrderItem>().Select(x => x.Name);
        if (search!=null)
            query=query.Where(x => x.Contains(search));
        return await query.Distinct().Take(DEFAULT_PAGESIZE).ToListAsync();
    }

    public async Task<List<string>> GetOrderItemUnitsAsync(string? search)
    {
        var query = dbContext.Set<OrderItem>().Select(x => x.Unit);
        if (search!=null)
            query=query.Where(x => x.Contains(search));
        return await query.Distinct().Take(DEFAULT_PAGESIZE).ToListAsync();
    }
}
