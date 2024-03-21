using MediatR;
using POCDotNet.Domain.Commands.Requests;
using POCDotNet.Domain.Commands.Responses;
using POCDotNet.Domain.Entites;
using POCDotNet.Domain.Repositories;

namespace POCDotNet.Domain.Handlers
{
  public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
  {
    ICustomerRepository _repository;

    public CreateCustomerHandler(ICustomerRepository repository)
    {
      this._repository = repository;
    }

    public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
      var customer = new Customer(request.Name, request.Email);
      _repository.Save(customer);
      var result = new CreateCustomerResponse
      {
        Id = customer.Id,
        Name = customer.Name,
        Email = customer.Email,
        Date = DateTime.Now
      };
      return Task.FromResult(result);
    }
  }
}