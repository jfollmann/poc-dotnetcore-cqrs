using MediatR;
using Microsoft.AspNetCore.Mvc;
using POCDotNet.Domain.Commands.Requests;
using POCDotNet.Domain.Queries.Requests;

namespace POCDotNet.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CustomerController : ControllerBase
  {
    [HttpGet]
    [Route("")]
    public IActionResult GetById(
      [FromServices] IMediator mediator,
      [FromQuery] FindCustomerByIdRequest command)
    {
      var target = mediator.Send(command);
      if (target is null) return NotFound();
      return Ok(target.Result);
    }

    [HttpPost]
    [Route("")]
    public IActionResult Create(
      [FromServices] IMediator mediator,
      [FromBody] CreateCustomerRequest command)
    {
      var target = mediator.Send(command);
      return Ok(target.Result);
    }
  }
}