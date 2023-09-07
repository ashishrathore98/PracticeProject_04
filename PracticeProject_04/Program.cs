using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PracticeProject_04.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PracticeProject_04DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PracticeProject_04DbContext") ?? throw new InvalidOperationException("Connection string 'PracticeProject_04DbContext' not found.")));

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

app.Run();
