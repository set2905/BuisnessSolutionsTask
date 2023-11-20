using Application.Abstractions;

namespace Application.Members.Queries.FindDistinctFilterValues.OrderItemNames;

public sealed record FindOrderItemNamesQuery(string? search) : IQuery<List<string>>;
