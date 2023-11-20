using Ardalis.GuardClauses;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class ProviderRepository : IProviderRepository
{
    private const int DEFAULT_PAGESIZE = 10;
    private readonly ApplicationDbContext dbContext;

    public ProviderRepository(ApplicationDbContext dbContext)
    {
        this.dbContext=dbContext;
    }

    public async Task<bool> ProviderExists(ProviderId id)
    {
        return await dbContext.Set<Provider>().AnyAsync(x => x.Id== id);
    }

    public async Task<List<Provider>> GetProvidersAsync(string? search, int skipPageCount)
    {
        Guard.Against.Negative(skipPageCount, "skipPageCount");
        var query = dbContext.Set<Provider>().AsQueryable();
        if (search!=null)
        {
            query=query.Where(x => x.Name.Contains(search));
        }
        return await query.Skip(skipPageCount*DEFAULT_PAGESIZE).Take(DEFAULT_PAGESIZE).ToListAsync();
    }

}
