using Application.Abstractions;
using Application.DTO;
using Ardalis.Result;
using Ardalis.Result.FluentValidation;
using AutoMapper;
using Persistence.Repositories;

namespace Application.Members.Queries.FindProviders;

public sealed class FindProvidersQueryHandler : IQueryHandler<FindProvidersQuery, ProviderDto[]>
{
    private readonly IProviderRepository providerRepository;
    private readonly IMapper mapper;
    public FindProvidersQueryHandler(IProviderRepository providerRepository, IMapper mapper)
    {
        this.providerRepository=providerRepository;
        this.mapper=mapper;
    }

    public async Task<Result<ProviderDto[]>> Handle(FindProvidersQuery request,
                                                    CancellationToken cancellationToken)
    {
        ProviderDto[] providers = (await providerRepository.GetProvidersAsync(request.search))
            .ConvertAll(mapper.Map<ProviderDto>)
            .ToArray();
        return Result.Success(providers);
    }
}
