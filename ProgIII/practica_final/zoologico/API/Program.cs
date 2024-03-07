using System.Reflection;
using API.Data;
using API.Services.Zoos.DBValidators;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ZoosContext>((options) => {
    options.UseNpgsql(builder.Configuration.GetConnectionString("ZoosConnection"));
});

builder.Services.AddMediatR((config) => 
    config.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly())
);

builder.Services.AddFluentValidation((config) =>
{
    config.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});

builder.Services.AddScoped<IExisteZooConEseNombreCiudadYPais, ExisteZooConEseNombreCiudadYPais>();

var app = builder.Build();

app.UseCors((config) =>
{
    config.AllowAnyOrigin();
    config.AllowAnyHeader();
    config.AllowAnyMethod();
});


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
