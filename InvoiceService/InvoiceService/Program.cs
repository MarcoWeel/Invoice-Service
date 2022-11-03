using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using InvoiceService.Data;
using MySqlConnector;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var conStrBuilder = new MySqlConnectionStringBuilder(
    builder.Configuration.GetConnectionString("DBConnectionString"));
var connection = conStrBuilder.ConnectionString;

builder.Services.AddDbContext<InvoiceServiceContext>(options =>
    options.UseMySql(connection, ServerVersion.AutoDetect(connection)));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
