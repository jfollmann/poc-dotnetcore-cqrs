using MediatR;
using POCDotNet.Domain.Commands.Responses;

namespace POCDotNet.Domain.Commands.Requests
{
  public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
  {
    public required string Name { get; set; }
    public required string Email { get; set; }
  }
}