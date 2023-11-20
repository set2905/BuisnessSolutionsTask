﻿using Domain.Errors;
using Domain.Repositories;
using FluentValidation;
using Persistence.Repositories;

namespace Application.Messaging.Commands.CreateOrder;

public sealed class CreateOrderCommandValidator : AbstractValidator<OrderCommand>
{
    private readonly IProviderRepository providerRepository;
    private readonly IOrderRepository orderRepository;
    public CreateOrderCommandValidator(IProviderRepository providerRepository, IOrderRepository orderRepository)
    {
        this.providerRepository = providerRepository;
        this.orderRepository = orderRepository;
        RuleFor(x => x.orderDto.Number).NotEmpty()
                                       .WithMessage(DomainErrors.Order.EmptyNumber);

        RuleFor(x => x.orderDto).Must(x => !x.Items.Any(i => x.Number.Equals(i.Name)))
            .WithMessage(DomainErrors.Order.NumberEqualsToItemName);

        RuleFor(x => x.orderDto.ProviderId).MustAsync(async (id, cancellation) =>
        {
            bool exists = await this.providerRepository.ProviderExists(id);
            return exists;
        }).WithMessage(DomainErrors.Provider.NotFound);

        RuleFor(x => x.orderDto).MustAsync(async (dto, cancellation) =>
        {
            bool isUnique = await this.orderRepository.IsOrderUnique(dto.Id, dto.Number, dto.ProviderId);
            return isUnique;
        }).WithMessage(DomainErrors.Order.MultiIndexNotUnique);
    }
}
