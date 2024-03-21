using POCDotNet.Domain.Queries.Requests;
using POCDotNet.Domain.Queries.Responses;
using POCDotNet.Domain.Repositories;

namespace POCDotNet.Domain.Handlers
{
  public class FindCustomerByIdHandler : IFindCustomerByIdHandler
  {
    ICustomerRepository _repository;
    public FindCustomerByIdHandler(ICustomerRepository repository)
    {
      _repository = repository;
    }

    public FindCustomerByIdResponse? Handle(FindCustomerByIdRequest command)
    {
      var customer = _repository.GetCustomerById(command.Id);
      if(customer is null) return null;
      return new FindCustomerByIdResponse
      {
        Id = customer.Id,
        Email = customer.Email,
        Name = customer.Name
      };
    }
  }
}