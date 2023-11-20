using Application.Abstractions;
using Application.DTO;
using Domain.Repositories;

namespace Application.Members.Queries.FindOrders;

public sealed record FindOrdersQuery(DateTime startDate,
                                    DateTime endDate,
                                    int page,
                                    OrderFilter? filter) : IQuery<OrderDto[]>;
