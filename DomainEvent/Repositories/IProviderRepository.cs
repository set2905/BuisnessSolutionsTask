using Domain.Entities;

namespace Persistence.Repositories
{
    public interface IProviderRepository
    {
        Task<bool> ProviderExists(ProviderId id);
    }
}