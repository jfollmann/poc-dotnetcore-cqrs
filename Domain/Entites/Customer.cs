namespace POCDotNet.Domain.Entites
{
  public class Customer(string name, string email, Guid? Id = null)
  {
    public Guid Id { get; private set; } = Id ?? Guid.NewGuid();
    public string Name { get; private set; } = name;
    public string Email { get; private set; } = email;
  }
}