using Domain.Entities;

namespace Domain.Repositories;

public sealed record OrderFilter(string[]? numberFilter,
                                ProviderId[]? providerFilter,
                                string[]? orderItemNameFilter,
                                string[]? orderItemUnitFilter);
