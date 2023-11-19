using FluentValidation;

namespace Domain.Entities.Validation;

internal class OrderValidator : AbstractValidator<Order>
{
    public OrderValidator()
    {
        RuleFor(x=>x.Number).NotEmpty().WithMessage("The order number must not be empty");
    }
}
