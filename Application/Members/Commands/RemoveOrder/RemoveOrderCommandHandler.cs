using Application.Abstractions;
using Application.Messaging.Commands.CreateOrder;
using Ardalis.Result;
using Domain.Entities;
using Domain.Errors;
using Domain.Repositories;
using Persistence;

namespace Application.Members.Commands.RemoveOrder;

public sealed class RemoveOrderCommandHandler : ICommandHandler<RemoveOrderCommand>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IOrderRepository orderRepository;

    public RemoveOrderCommandHandler(IUnitOfWork unitOfWork, IOrderRepository orderRepository)
    {
        this.unitOfWork=unitOfWork;
        this.orderRepository=orderRepository;
    }

    /// <summary>
    /// Удаляет заказ из БД (совсем)
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Result> Handle(RemoveOrderCommand request, CancellationToken cancellationToken)
    {
        Order? order = await orderRepository.GetByIdAsync(request.id);
        if (order == null)
            return Result.NotFound(DomainErrors.Order.NotFound);

        orderRepository.Remove(order);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return Result.Success();
    }
}
