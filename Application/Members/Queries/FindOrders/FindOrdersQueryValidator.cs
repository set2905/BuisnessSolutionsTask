using Domain.Errors;
using FluentValidation;

namespace Application.Members.Queries.FindOrders;

public class FindOrdersQueryValidator : AbstractValidator<FindOrdersQuery>
{
    public FindOrdersQueryValidator()
    {
        RuleFor(x => x.page).GreaterThan(0).WithMessage(DomainErrors.Paging.PageLessThanOne);
        RuleFor(x => x).Must(x => x.endDate>=x.startDate).WithMessage(DomainErrors.Order.IncorrectDateSpan);
    }
}
