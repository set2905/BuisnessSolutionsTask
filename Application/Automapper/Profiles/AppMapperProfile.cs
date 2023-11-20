using Application.DTO;
using AutoMapper;
using Domain.Entities;

namespace Application.Automapper.Profiles;

public sealed class AppMapperProfile : Profile
{
    public AppMapperProfile()
    {
        CreateMap<Provider, ProviderDto>();
    }
}

