using Application.DTO;
using Application.Messaging.Commands.CreateOrder;
using Application.Messaging.Commands.UpdateOrder;
using Ardalis.Result;
using Ardalis.Result.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Abstractions;

namespace WebAPI.Controllers;

[Route("api/orders")]
public sealed class OrdersController : ApiController
{
    public OrdersController(ISender sender)
        : base(sender)
    {
    }

    [HttpGet]
    [Route("find")]
    [TranslateResultToActionResult]
    public async Task<Result> FindOrders(, CancellationToken cancellationToken)
    {

    }

    [HttpPost]
    [Route("create")]
    [TranslateResultToActionResult]
    public async Task<Result> CreateOrder(OrderDto orderDto, CancellationToken cancellationToken)
    {
        var command = new CreateOrderCommand(orderDto);
        return await sender.Send(command, cancellationToken);
    }
    [HttpPost]
    [Route("update")]
    [TranslateResultToActionResult]
    public async Task<Result> UpdateOrder(OrderDto orderDto, CancellationToken cancellationToken)
    {
        var command = new UpdateOrderCommand(orderDto);
        return await sender.Send(command, cancellationToken);
    }
}
