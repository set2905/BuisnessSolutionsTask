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

}
