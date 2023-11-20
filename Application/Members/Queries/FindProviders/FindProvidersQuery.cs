using Application.Abstractions;
using Application.DTO;

namespace Application.Members.Queries.FindProviders;

public sealed record FindProvidersQuery(string? search, int page) : IQuery<ProviderDto[]>
{

}
