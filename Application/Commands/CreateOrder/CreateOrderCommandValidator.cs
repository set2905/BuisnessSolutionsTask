using Domain.Errors;
using FluentValidation;
using Persistence.Repositories;

namespace Application.Commands.CreateOrder;

public sealed class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
{
    private readonly IProviderRepository providerRepository;
    public CreateOrderCommandValidator(IProviderRepository providerRepository)
    {
        this.providerRepository = providerRepository;
        RuleFor(x => x.orderDto.Number).NotEmpty().WithMessage(DomainErrors.Order.EmptyNumber);
        RuleFor(x => x.orderDto.ProviderId).MustAsync(async (id, cancellation) =>
        {
            bool exists = await this.providerRepository.ProviderExists(id);
            return exists;
        }).WithMessage(DomainErrors.Provider.NotFound);
    }
}
