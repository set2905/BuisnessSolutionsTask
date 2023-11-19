using FluentValidation;
using Persistence.Repositories;

namespace Application.Commands.CreateOrder;

public sealed class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
{
    private readonly IProviderRepository providerRepository;
    public CreateOrderCommandValidator(IProviderRepository providerRepository)
    {
        this.providerRepository = providerRepository;
        RuleFor(x => x.orderDto.Number).NotEmpty().WithMessage("Order number cannot be empty");
        RuleFor(x => x.orderDto.ProviderId).MustAsync(async (id, cancellation) =>
        {
            bool exists = await providerRepository.ProviderExists(id);
            return !exists;
        }).WithMessage("Provider not found");
    }
}
