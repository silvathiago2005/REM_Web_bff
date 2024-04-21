using MediatR;
using Microsoft.Extensions.Options;
using REM_BFF_V1.Application.UseCases.Login;
using REM_BFF_V1.Application.UseCases.ResetPassword;
using REM_BFF_V1.Infra.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//add scopes
builder.Services.AddMediatR(typeof(LoginRequest));
builder.Services.AddMediatR(typeof(ResetPasswordRequest));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMvcCore();

var app = builder.Build();

public void ConfigureService(IServiceCollection services)
{
    services.AddDbContext<REMContext>(options => options.UserSqlServer(configuration.GetConnection("DefaultConnection")));
}

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
