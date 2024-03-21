using POCDotNet.Domain.Entites;

namespace POCDotNet.Domain.Repositories
{
  public interface ICustomerRepository
  {
    int Save(Customer customer);
    Customer? GetCustomerById(Guid Id);
  }
}