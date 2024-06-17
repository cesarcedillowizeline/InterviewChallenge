using API.InterviewChallenge.Core.Adapters.Persistence;
using API.InterviewChallenge.Core.Domain.Interfaces;
using API.InterviewChallenge.Core.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

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

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
