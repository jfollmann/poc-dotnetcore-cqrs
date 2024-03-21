using POCDotNet.Domain.Commands.Requests;
using POCDotNet.Domain.Commands.Responses;

namespace POCDotNet.Domain.Handlers
{
  public interface ICreateCustomerHandler
  {
    CreateCustomerResponse Handle(CreateCustomerRequest command);
  }
}