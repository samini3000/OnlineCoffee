using Domain.Repositories;

using Infrustructure.DataAccess;
using Infrustructure.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<CoffeeHouseDBContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("CoffeeHouse")));
builder.Services.AddScoped<ICoffeeTypeRepository, CoffeeTypeRepository>();
//to do : make it cleaner

//builder.Configuration.GetConnectionString(@"Data Source=SAEEDEH-LEGION;Integrated Security=True;;Initial Catalog=CoffeeHouse;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;");

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Application.AssemblyRefrences.Assembly));

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
