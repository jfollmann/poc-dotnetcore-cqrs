using POCDotNet.Domain.Handlers;
using POCDotNet.Domain.Repositories;
using POCDotNet.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ICreateCustomerHandler, CreateCustomerHandler>();
builder.Services.AddTransient<IFindCustomerByIdHandler, FindCustomerByIdHandler>();
builder.Services.AddSingleton<ICustomerRepository, CustomerMemoryRepository>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
