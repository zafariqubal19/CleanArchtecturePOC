using AutoMapper;
using Mena.Poc.Application.Interfaces;
using Mena.Poc.Application.Service;
using Mena.Poc.Domain.Interfaces.Repository;
using Mena.Poc.Infrastructure.Repository;
using Mena.Poc.Persistance.DataAccess;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<MenaPocDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("MenaPocConnectionString")));
builder.Services.AddScoped<IUserRepository,UserRepository>();
//builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<IBookRepository,BooksRepository>();
builder.Services.AddScoped<IBooksServices,BooksService>();
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
