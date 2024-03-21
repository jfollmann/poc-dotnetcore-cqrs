using MediatR;
using POCDotNet.Domain.Queries.Responses;

namespace POCDotNet.Domain.Queries.Requests
{
  public class FindCustomerByIdRequest : IRequest<FindCustomerByIdResponse>
  {
    public Guid Id { get; set; }
  }
}