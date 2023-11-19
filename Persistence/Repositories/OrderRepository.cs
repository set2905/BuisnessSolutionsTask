﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

internal class OrderRepository
{
    private const int DEFAULT_PAGESIZE = 10;
    private readonly ApplicationDbContext dbContext;

    public OrderRepository(ApplicationDbContext dbContext)
    {
        this.dbContext=dbContext;
    }

    public async Task<Order?> GetByIdAsync(OrderId orderId)
    {
        return await dbContext.Set<Order>().SingleOrDefaultAsync(x => x.Id==orderId);
    }

    public async Task<List<Order>> GetOrders(int page)
    {
        return await dbContext.Set<Order>().Skip(page*DEFAULT_PAGESIZE).Take(DEFAULT_PAGESIZE).ToListAsync();
    }

    public void Add(Order order)
    {
        dbContext.Set<Order>().Add(order);
    }
}
