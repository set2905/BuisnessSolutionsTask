using Application.DTO;
using Application.Members.Commands.RemoveOrder;
using Application.Members.Queries.FindOrders;
using Application.Messaging.Commands.CreateOrder;
using Application.Messaging.Commands.UpdateOrder;
using Ardalis.Result;
using Ardalis.Result.AspNetCore;
using Domain.Entities;
using Domain.Repositories;
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

    [HttpPost]
    [Route("find")]
    [TranslateResultToActionResult]
    public async Task<Result<OrderDto[]>> FindOrders(DateTime startDate,
                                                     DateTime endDate,
                                                     int page,
                                                     OrderFilter? filter,
                                                     CancellationToken cancellationToken)
    {
        var query = new FindOrdersQuery(startDate, endDate, page, filter);
        return await sender.Send(query, cancellationToken);
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

    [HttpPost]
    [Route("remove")]
    [TranslateResultToActionResult]
    public async Task<Result> RemoveOrder(OrderId orderId, CancellationToken cancellationToken)
    {
        var command = new RemoveOrderCommand(orderId);
        return await sender.Send(command, cancellationToken);
    }
}
