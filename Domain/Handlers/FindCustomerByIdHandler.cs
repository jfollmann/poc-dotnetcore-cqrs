using MediatR;
using POCDotNet.Domain.Queries.Requests;
using POCDotNet.Domain.Queries.Responses;
using POCDotNet.Domain.Repositories;

namespace POCDotNet.Domain.Handlers
{
  public class FindCustomerByIdHandler : IRequestHandler<FindCustomerByIdRequest, FindCustomerByIdResponse?>
  {
    ICustomerRepository _repository;
    public FindCustomerByIdHandler(ICustomerRepository repository)
    {
      _repository = repository;
    }

    public Task<FindCustomerByIdResponse?> Handle(FindCustomerByIdRequest request, CancellationToken cancellationToken)
    {
      var customer = _repository.GetCustomerById(request.Id);
      if (customer is null) return Task.FromResult<FindCustomerByIdResponse?>(null);
      var result = new FindCustomerByIdResponse
      {
        Id = customer.Id,
        Email = customer.Email,
        Name = customer.Name
      };
      return Task.FromResult(result);
    }
  }
}