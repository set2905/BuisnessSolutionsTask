
using Application.Abstractions;
using Ardalis.Result;
using Persistence.Repositories;

namespace Application.Members.Queries.FindDistinctFilterValues.OrderItemNames;

public sealed class FindOrderItemNamesQueryHandler : IQueryHandler<FindOrderItemNamesQuery, List<string>>
{
    private readonly IOrderItemRepository orderItemRepository;

    public FindOrderItemNamesQueryHandler(IOrderItemRepository orderItemRepository)
    {
        this.orderItemRepository=orderItemRepository;
    }

    public async Task<Result<List<string>>> Handle(FindOrderItemNamesQuery request, CancellationToken cancellationToken)
    {
        return Result.Success(await orderItemRepository.GetOrderItemNamesAsync(request.search));
    }
}
