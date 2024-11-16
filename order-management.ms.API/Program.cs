using Microsoft.EntityFrameworkCore;
using order_management.ms.API.Data;
using order_management.ms.API.Exceptions;
using order_management.ms.API.Repository;
using order_management.ms.API.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Load configuration from appsettings.json and environment variables
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<OrderManagementDBContext>(options =>
{
    options.UseNpgsql(connectionString); // for postgresSQL

});

// Service and Repository
builder.Services.AddScoped<OrderManagementService>();
builder.Services.AddScoped<OrderManagementRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Middleware for global exception handling.
app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
