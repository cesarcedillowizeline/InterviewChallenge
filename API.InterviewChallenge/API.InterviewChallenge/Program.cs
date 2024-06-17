using API.InterviewChallenge.Core.Adapters.Persistence;
using API.InterviewChallenge.Core.Domain.Interfaces;
using API.InterviewChallenge.Core.Domain.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "challenge", Version = "v1" });
});

//// Register the IBookingService and its implementation
//builder.Services.AddScoped<IBookingService, BookingService>();
//builder.Services.AddSingleton<IBookingService, BookingService>();

//// Register the IBookingRepository and its implementation
//builder.Services.AddScoped<IBookingRepository, BookingRepository>();
//builder.Services.AddSingleton<IBookingRepository, BookingRepository>();

//// Register the InMemoryDbContext as a singleton
//builder.Services.AddScoped<InMemoryDbContext>();
//builder.Services.AddSingleton<InMemoryDbContext>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Nombre de tu API V1");
        // URL de la interfaz de usuario de Swagger (opcional)
        c.RoutePrefix = "api"; // Configura la raíz de la URL donde se servirá Swagger UI, por ejemplo "/" para la raíz del sitio
    });
}

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
