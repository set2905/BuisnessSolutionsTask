using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Abstractions;

[ApiController]
public class ApiController : ControllerBase
{
    protected readonly ISender sender;

    public ApiController(ISender sender)
    {
        this.sender=sender;
    }
}
