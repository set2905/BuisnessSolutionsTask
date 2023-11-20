using Domain.Entities;

namespace Persistence.Repositories
{
    public interface IProviderRepository
    {
        Task<List<Provider>> GetProvidersAsync(string? search, int skipPageCount);
        Task<bool> ProviderExists(ProviderId id);
    }
}