using Domain.Entities;

namespace Persistence.Repositories
{
    public interface IProviderRepository
    {
        Task<Provider?> GetByIdAsync(ProviderId id);
    }
}