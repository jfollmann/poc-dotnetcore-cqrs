namespace POCDotNet.Domain.Commands.Requests
{
  public class CreateCustomerRequest
  {
    public required string Name { get; set; }
    public required string Email { get; set; }
  }
}