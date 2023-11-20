using Application.Members.Queries.FindDistinctFilterValues.OrderNumbers;
using Ardalis.Result;
using Ardalis.Result.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Abstractions;

namespace WebAPI.Controllers;

public sealed class FilterValuesController : ApiController
{
    public FilterValuesController(ISender sender) : base(sender)
    {
    }

    [HttpGet]
    [Route("findOrderNumbers")]
    [TranslateResultToActionResult]
    public async Task<Result<List<string>>> FindOrderNumbers(string? search, CancellationToken cancellationToken)
    {
        var query = new FindOrderNumbersQuery(search);
        return await sender.Send(query, cancellationToken);
    }
}
