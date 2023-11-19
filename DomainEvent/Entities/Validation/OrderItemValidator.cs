using Ardalis.GuardClauses;
using FluentValidation;
using System.Xml.Linq;

namespace Domain.Entities.Validation;

internal class OrderItemValidator : AbstractValidator<OrderItem>
{
    public OrderItemValidator()
    {
        RuleFor(x=>x.Name).NotEmpty().WithMessage("Order item name cannot be empty");
        RuleFor(x => x.Unit).NotEmpty().WithMessage("Order item unit cannot be empty");
        RuleFor(x => x.Quantity).GreaterThan(0).WithMessage("Quantity cannot be negative");
    }
}
