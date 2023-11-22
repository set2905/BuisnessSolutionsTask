using Domain.Entities;

namespace Persistence.Repositories
{
    public interface IProviderRepository
    {
        /// <summary>
        /// Найти поставщиков по имени (например, для фильтрации)
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        Task<List<Provider>> GetProvidersAsync(string? search);
        /// <summary>
        /// Существует ли поставщик с <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> ProviderExists(ProviderId id);
    }
}