namespace POCDotNet.Domain.Commands.Responses
{
  public class CreateCustomerResponse
  {
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public DateTime Date { get; set; }
  }
}