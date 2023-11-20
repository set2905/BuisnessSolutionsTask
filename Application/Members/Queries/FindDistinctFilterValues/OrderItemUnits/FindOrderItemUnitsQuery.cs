using Application.Abstractions;

namespace Application.Members.Queries.FindDistinctFilterValues.OrderItemUnits;

public sealed record FindOrderItemUnitsQuery(string? search) : IQuery<List<string>>;

