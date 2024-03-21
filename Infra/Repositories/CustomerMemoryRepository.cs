using POCDotNet.Domain.Entites;
using POCDotNet.Domain.Repositories;

namespace POCDotNet.Infra.Repositories
{
  public class CustomerMemoryRepository : ICustomerRepository
  {
    public List<Customer> DbCustomer { get; set; }

    public CustomerMemoryRepository()
    {
      DbCustomer =
      [
        new("Jefferson Follmann", "jf@gmail.com", new Guid("0e60b197-53e8-4cd7-b536-c8a7b137902b")),
        new("Andressa Duarte", "ad.duarte@gmail.com"),
        new("Antonio Follmann", "at.follmann@gmail.com")
      ];
    }

    public int Save(Customer customer)
    {
      DbCustomer.Add(customer);
      return 1;
    }

    public Customer? GetCustomerById(Guid Id)
    {
      return DbCustomer.SingleOrDefault((item) => item.Id == Id);
    }
  }
}