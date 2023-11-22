using Ardalis.GuardClauses;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public sealed class ProviderRepository : IProviderRepository
{
    private const int DEFAULT_PAGESIZE = 10;
    private readonly ApplicationDbContext dbContext;

    public ProviderRepository(ApplicationDbContext dbContext)
    {
        this.dbContext=dbContext;
    }

    ///<inheritdoc/>

    public async Task<bool> ProviderExists(ProviderId id)
    {
        return await dbContext.Set<Provider>().AnyAsync(x => x.Id== id);
    }

    ///<inheritdoc/>

    public async Task<List<Provider>> GetProvidersAsync(string? search)
    {
        var query = dbContext.Set<Provider>().AsQueryable();
        if (search!=null)
        {
            query=query.Where(x => x.Name.Contains(search));
        }
        return await query.Take(DEFAULT_PAGESIZE).ToListAsync();
    }

}
