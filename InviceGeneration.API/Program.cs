using InviceGeneration.Application.QueryHandler;
using InviceGeneration.Application.RepositoryInterface;
using InviceGeneration.Infrastructure.Repository;
using InvoiceGeneration.Infrastructure.DbConnection;
using Microsoft.Data.SqlClient;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//my service

builder.Services.AddScoped<IInvoiceRepository,InvoiceRepository>();
builder.Services.AddMediatR(cfg => { cfg.RegisterServicesFromAssemblyContaining<GetInvoiceQueryHandler>(); });

// Add DapperDbContext to the DI container
builder.Services.AddScoped<DapperDbContext>(provider =>
{
    var connectionString = builder.Configuration.GetConnectionString("FTCSCS");
 
    return new DapperDbContext(connectionString);
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
