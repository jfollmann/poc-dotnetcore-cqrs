using Microsoft.AspNetCore.Mvc;
using POCDotNet.Domain.Commands.Requests;
using POCDotNet.Domain.Handlers;
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
      [FromServices] IFindCustomerByIdHandler handler,
      [FromQuery] FindCustomerByIdRequest command)
    {
      var result = handler.Handle(command);
      if (result is null) return NotFound();
      return Ok(result);
    }

    [HttpPost]
    [Route("")]
    public IActionResult Create(
      [FromServices] ICreateCustomerHandler handler,
      [FromBody] CreateCustomerRequest command)
    {
      var response = handler.Handle(command);
      return Ok(response);
    }
  }
}