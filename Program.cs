using System.Reflection;
using MediatR;
using POCDotNet.Domain.Repositories;
using POCDotNet.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg =>
  cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly())
);
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
