using FluentValidation;

namespace Application.Commands.CreateOrder;

public sealed class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
{
    public CreateOrderCommandValidator()
    {
        RuleFor(x => x.orderDto.Number).NotEmpty().WithMessage("Order number cannot be empty");
    }
}
