using FluentValidation;

namespace Application.Commands.CreateOrder;

public sealed class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
{
    public CreateOrderCommandValidator()
    {
        RuleFor(x => x.number).NotEmpty().WithMessage("Order number cannot be empty");
    }
}
