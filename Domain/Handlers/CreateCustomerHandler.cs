using POCDotNet.Domain.Commands.Requests;
using POCDotNet.Domain.Commands.Responses;
using POCDotNet.Domain.Entites;
using POCDotNet.Domain.Repositories;

namespace POCDotNet.Domain.Handlers
{
  public class CreateCustomerHandler : ICreateCustomerHandler
  {
    ICustomerRepository _repository;

    public CreateCustomerHandler(ICustomerRepository repository)
    {
      this._repository = repository;
    }

    public CreateCustomerResponse Handle(CreateCustomerRequest command)
    {
      var customer = new Customer(command.Name, command.Email);
      _repository.Save(customer);

      return new CreateCustomerResponse
      {
        Id = customer.Id,
        Name = customer.Name,
        Email = customer.Email,
        Date = DateTime.Now
      };
    }
  }
}