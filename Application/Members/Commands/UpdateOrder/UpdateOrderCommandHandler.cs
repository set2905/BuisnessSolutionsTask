using Application.Abstractions;
using Application.Commands.UpdateOrder;
using Ardalis.Result;
using Ardalis.Result.FluentValidation;
using Domain.Entities;
using Domain.Errors;
using Domain.Repositories;
using Persistence;
using Persistence.Repositories;

namespace Application.Messaging.Commands.UpdateOrder;

internal class UpdateOrderCommandHandler : ICommandHandler<UpdateOrderCommand>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IOrderRepository orderRepository;
    private readonly IProviderRepository providerRepository;

    public UpdateOrderCommandHandler(IUnitOfWork unitOfWork, IOrderRepository orderRepository, IProviderRepository providerRepository)
    {
        this.unitOfWork = unitOfWork;
        this.orderRepository = orderRepository;
        this.providerRepository = providerRepository;
    }

    public async Task<Result> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
    {
        var validator = new UpdateOrderCommandValidator(providerRepository, orderRepository);
        var validation = await validator.ValidateAsync(request);
        if (!validation.IsValid)
            return Result.Invalid(validation.AsErrors());

        var order = await orderRepository.GetByIdAsync(request.orderDto.Id!);
        if (order == null) return Result.NotFound(DomainErrors.Order.NotFound);

        order.Modify(request.orderDto.Number,
                     request.orderDto.Date,
                     request.orderDto.ProviderId);
        foreach (var item in request.orderDto.Items)
        {
            if (item.Id == null)
            {
                order.AddOrderItem(item.Name, item.Quantity, item.Unit);
            }
            else
            {
                OrderItem? foundItem = order.Items.SingleOrDefault(x => x.Id == item.Id);
                if (foundItem == null) return Result.NotFound($"{DomainErrors.OrderItem.NotFound} {item.Name}");
                foundItem.Modify(item.Name, item.Quantity, item.Unit);
            }
        }

        orderRepository.Update(order);
        await unitOfWork.SaveChangesAsync();
        return Result.Success();
    }
}
