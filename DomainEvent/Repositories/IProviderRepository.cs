using Domain.Entities;

namespace Persistence.Repositories
{
    public interface IProviderRepository
    {
        Task<List<Provider>> GetProvidersAsync(string? search);
        Task<bool> ProviderExists(ProviderId id);
    }
}