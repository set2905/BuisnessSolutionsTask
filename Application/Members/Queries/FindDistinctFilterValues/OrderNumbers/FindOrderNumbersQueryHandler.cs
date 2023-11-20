using Application.Abstractions;
using Ardalis.Result;
using Domain.Repositories;

namespace Application.Members.Queries.FindDistinctFilterValues.OrderNumbers;

public sealed class FindOrderNumbersQueryHandler : IQueryHandler<FindOrderNumbersQuery, List<string>>
{
    private readonly IOrderRepository orderRepository;

    public FindOrderNumbersQueryHandler(IOrderRepository orderRepository)
    {
        this.orderRepository = orderRepository;
    }

    public async Task<Result<List<string>>> Handle(FindOrderNumbersQuery request, CancellationToken cancellationToken)
    {
        return Result.Success(await orderRepository.GetOrderNumbersAsync(request.search));
    }
}
