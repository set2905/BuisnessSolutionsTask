using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;


internal class OrderRepository : IOrderRepository
{
    private const int DEFAULT_PAGESIZE = 10;
    private readonly ApplicationDbContext dbContext;

    public OrderRepository(ApplicationDbContext dbContext)
    {
        this.dbContext=dbContext;
    }

    public async Task<List<Order>> FindOrdersAsync(DateTime startDate,
                                                   DateTime endDate,
                                                   int page,
                                                   OrderFilter? filter)
    {
        IQueryable<Order> query = dbContext.Set<Order>()
                             .Include(o => o.Items)
                             .Include(o => o.Provider)
                             .Where(x => x.Date>=startDate&&x.Date<=endDate);

        if (filter!=null) query=ApplyFilters(query, filter);

        return await query.Skip(page*DEFAULT_PAGESIZE).Take(DEFAULT_PAGESIZE).ToListAsync();
    }

    public async Task<Order?> GetByIdAsync(OrderId orderId)
    {
        return await dbContext.Set<Order>()
            .Include(x => x.Items)
            .Include(x => x.Provider)
            .SingleOrDefaultAsync(x => x.Id==orderId);
    }

    public async Task<bool> IsOrderUnique(OrderId? id, string orderNumber, ProviderId providerId)
    {
        return !await dbContext.Set<Order>()
            .AnyAsync(x => x.Number==orderNumber&&x.ProviderId==providerId&x.Id!=id);
    }

    public async Task<List<Order>> GetOrdersAsync(int page, DateTime startDate, DateTime endDate)
    {
        var baseQuery = dbContext.Set<Order>()
             .Where(x => x.Date>=startDate && x.Date<=endDate)
             .Skip(page*DEFAULT_PAGESIZE)
             .Take(DEFAULT_PAGESIZE)
             .Include(x => x.Items)
             .Include(x => x.Provider);
        return await baseQuery.ToListAsync();
    }

    public void Add(Order order)
    {
        dbContext.Set<Order>().Add(order);
    }
    public void Update(Order order)
    {
        dbContext.Set<Order>().Update(order);
    }

    private IQueryable<Order> ApplyFilters(IQueryable<Order> query, OrderFilter filter)
    {
        if (filter.numberFilter!=null)
            query=query.Where(o => filter.numberFilter.Any(n => o.Number.Contains(n)));
        if (filter.providerFilter!=null)
            query=query.Where(o => filter.providerFilter.Any(id => id==o.ProviderId));
        if (filter.orderItemNameFilter!=null)
            query=query.Where(o => filter.orderItemNameFilter.Any(f => o.Items.Any(i => i.Name.Contains(f))));
        if (filter.orderItemUnitFilter!=null)
            query=query.Where(o => filter.orderItemUnitFilter.Any(f => o.Items.Any(i => i.Unit.Contains(f))));
        return query;
    }
}


