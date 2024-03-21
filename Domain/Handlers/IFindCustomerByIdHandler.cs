using POCDotNet.Domain.Queries.Requests;
using POCDotNet.Domain.Queries.Responses;

namespace POCDotNet.Domain.Handlers
{
  public interface IFindCustomerByIdHandler
  {
    FindCustomerByIdResponse? Handle(FindCustomerByIdRequest command);
  }
}