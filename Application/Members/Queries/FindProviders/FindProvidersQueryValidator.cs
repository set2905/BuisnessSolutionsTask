using Domain.Errors;
using FluentValidation;

namespace Application.Members.Queries.FindProviders;

public sealed class FindProvidersQueryValidator : AbstractValidator<FindProvidersQuery>
{
    public FindProvidersQueryValidator()
    {
        RuleFor(x => x.page).GreaterThan(0).WithMessage(DomainErrors.Paging.PageLessThanOne);
    }
}
