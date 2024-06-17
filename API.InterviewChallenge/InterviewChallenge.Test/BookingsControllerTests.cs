using API.InterviewChallenge;
using API.InterviewChallenge.Controllers;
using API.InterviewChallenge.Core.Domain.Interfaces;
using API.InterviewChallenge.Core.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;

public class BookingsControllerTests
{
    private readonly Mock<IBookingService> _mockBookingService;
    private readonly BookingsController _controller;

    public BookingsControllerTests()
    {
        _mockBookingService = new Mock<IBookingService>();
        _controller = new BookingsController(_mockBookingService.Object);
    }

    [Fact]
    public async Task CreateBooking_ReturnsCreatedAtActionResult()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public async Task GetBooking_ReturnsOkObjectResult()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public async Task GetBooking_ReturnsNotFoundResult()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public async Task UpdateBooking_ReturnsOkObjectResult()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public async Task DeleteBooking_ReturnsNoContentResult()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public async Task DeleteBooking_ReturnsNotFoundResult()
    {
        throw new NotImplementedException();
    }
}
