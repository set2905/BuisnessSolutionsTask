using Application.Abstractions;
using Application.Members.Queries.FindDistinctFilterValues.OrderItemNames;
using Ardalis.Result;
using Domain.Repositories;
using Persistence.Repositories;

namespace Application.Members.Queries.FindDistinctFilterValues.OrderItemUnits;

public sealed class FindOrderItemUnitsQueryHandler : IQueryHandler<FindOrderItemUnitsQuery, List<string>>
{
    private readonly IOrderItemRepository orderItemRepository;

    public FindOrderItemUnitsQueryHandler(IOrderItemRepository orderItemRepository)
    {
        this.orderItemRepository=orderItemRepository;
    }

    public async Task<Result<List<string>>> Handle(FindOrderItemUnitsQuery request, CancellationToken cancellationToken)
    {
        return Result.Success(await orderItemRepository.GetOrderItemUnitsAsync(request.search));

    }
}
