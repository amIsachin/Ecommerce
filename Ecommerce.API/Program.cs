using Application.Repositories.Classes;
using Application.Repositories.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency injection.
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// Connection string.
builder.Services.AddDbContext<EcommerceDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("EcommerceConnection"), assemply =>
assemply.MigrationsAssembly("Ecommerce.API")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// CORS.
app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
