using Application.Abstractions;

namespace Application.Members.Queries.FindDistinctFilterValues.OrderNumbers;

public sealed record FindOrderNumbersQuery(string? search) : IQuery<List<string>>;

