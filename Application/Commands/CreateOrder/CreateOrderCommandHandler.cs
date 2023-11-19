using Application.Abstractions;
using Ardalis.Result;
using Ardalis.Result.FluentValidation;
using Domain.Entities;
using Domain.Repositories;
using Persistence;

namespace Application.Commands.CreateOrder;
public class CreateOrderCommandHandler : ICommandHandler<CreateOrderCommand>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IOrderRepository orderRepository;

    public CreateOrderCommandHandler(IUnitOfWork unitOfWork, IOrderRepository orderRepository)
    {
        this.unitOfWork=unitOfWork;
        this.orderRepository=orderRepository;
    }

    public async Task<Result> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateOrderCommandValidator();
        var validation = await validator.ValidateAsync(request);
        if (!validation.IsValid)
            return Result.Invalid(validation.AsErrors());

        Order order = Order.Create(request.number, request.date, request.providerId);
        orderRepository.Add(order);
        await unitOfWork.SaveChangesAsync();
        return Result.SuccessWithMessage("Order succesfully created");
    }
}
