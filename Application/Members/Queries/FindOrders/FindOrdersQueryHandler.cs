using Application.Abstractions;
using Application.DTO;
using Application.Members.Queries.FindProviders;
using Ardalis.Result;
using Ardalis.Result.FluentValidation;
using AutoMapper;
using Domain.Repositories;
using Persistence.Repositories;

namespace Application.Members.Queries.FindOrders;

public sealed class FindOrdersQueryHandler : IQueryHandler<FindOrdersQuery, OrderDto[]>
{
    private readonly IOrderRepository orderRepository;
    private readonly IMapper mapper;

    public FindOrdersQueryHandler(IOrderRepository orderRepository, IMapper mapper)
    {
        this.orderRepository=orderRepository;
        this.mapper=mapper;
    }

    public async Task<Result<OrderDto[]>> Handle(FindOrdersQuery request, CancellationToken cancellationToken)
    {
        var validator = new FindOrdersQueryValidator();
        var validation = await validator.ValidateAsync(request);
        if (!validation.IsValid)
            return Result.Invalid(validation.AsErrors());

        OrderDto[] orders = (await orderRepository.GetOrdersAsync(request.startDate,
                                                                   request.endDate,
                                                                   request.page-1,
                                                                   request.filter))
                                                                   .ConvertAll(mapper.Map<OrderDto>)
                                                                   .ToArray();
        return Result.Success(orders);
    }
}
