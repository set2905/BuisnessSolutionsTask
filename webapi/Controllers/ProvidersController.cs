using Application.DTO;
using Application.Messaging.Commands.CreateOrder;
using Ardalis.Result.AspNetCore;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Abstractions;
using Application.Members.Queries.FindProviders;

namespace WebAPI.Controllers;

[Route("api/providers")]
public sealed class ProvidersController : ApiController
{
    public ProvidersController(ISender sender) : base(sender)
    {
    }

    [HttpGet]
    [Route("find")]
    [TranslateResultToActionResult]
    public async Task<Result<ProviderDto[]>> FindProviders(string? search, int page, CancellationToken cancellationToken)
    {
        var command = new FindProvidersQuery(search, page);
        return await sender.Send(command, cancellationToken);
    }
}
