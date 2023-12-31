﻿using Application.Abstractions;
using Ardalis.Result;
using Ardalis.Result.FluentValidation;
using Domain.Entities;
using Domain.Repositories;
using Persistence;
using Persistence.Repositories;

namespace Application.Messaging.Commands.CreateOrder;
public class CreateOrderCommandHandler : ICommandHandler<CreateOrderCommand>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IOrderRepository orderRepository;
    private readonly IProviderRepository providerRepository;

    public CreateOrderCommandHandler(IUnitOfWork unitOfWork,
                                     IOrderRepository orderRepository,
                                     IProviderRepository providerRepository)
    {
        this.unitOfWork = unitOfWork;
        this.orderRepository = orderRepository;
        this.providerRepository = providerRepository;
    }
    /// <summary>
    /// Создает новый заказ
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Result> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateOrderCommandValidator(providerRepository, orderRepository);
        var validation = await validator.ValidateAsync(request);
        if (!validation.IsValid)
            return Result.Invalid(validation.AsErrors());

        var orderItems = request.orderDto.Items.ToList().ConvertAll(x => OrderItem.Create(x.Name, x.Quantity, x.Unit));
        Order order = Order.Create(request.orderDto.Number,
                                   request.orderDto.Date,
                                   request.orderDto.Provider.Id,
                                   orderItems);
        orderRepository.Add(order);
        await unitOfWork.SaveChangesAsync();
        return Result.Success();
    }
}
