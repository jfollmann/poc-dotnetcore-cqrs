namespace POCDotNet.Domain.Queries.Responses
{
  public class FindCustomerByIdResponse
  {
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
  }
}