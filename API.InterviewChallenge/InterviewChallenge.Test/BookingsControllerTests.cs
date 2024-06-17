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
        // Arrange
        var booking = new Booking { Id = 1, CustomerName = "John Doe", CheckInDate = DateTime.Now, CheckOutDate = DateTime.Now.AddDays(1), RoomType = "Deluxe" };
        _mockBookingService.Setup(service => service.CreateBookingAsync(It.IsAny<Booking>())).ReturnsAsync(booking);

        // Act
        var result = await _controller.CreateBooking(booking);

        // Assert
        var actionResult = Assert.IsType<CreatedAtActionResult>(result.Result);
        var returnValue = Assert.IsType<Booking>(actionResult.Value);
        Assert.Equal(booking.Id, returnValue.Id);
    }

    [Fact]
    public async Task GetBooking_ReturnsOkObjectResult()
    {
        // Arrange
        var booking = new Booking { Id = 1, CustomerName = "John Doe", CheckInDate = DateTime.Now, CheckOutDate = DateTime.Now.AddDays(1), RoomType = "Deluxe" };
        _mockBookingService.Setup(service => service.GetBookingAsync(1)).ReturnsAsync(booking);

        // Act
        var result = await _controller.GetBooking(1);

        // Assert
        var actionResult = Assert.IsType<OkObjectResult>(result.Result);
        var returnValue = Assert.IsType<Booking>(actionResult.Value);
        Assert.Equal(booking.Id, returnValue.Id);
    }

    [Fact]
    public async Task GetBooking_ReturnsNotFoundResult()
    {
        // Arrange
        _mockBookingService.Setup(service => service.GetBookingAsync(1)).ReturnsAsync((Booking)null);

        // Act
        var result = await _controller.GetBooking(1);

        // Assert
        Assert.IsType<NotFoundResult>(result.Result);
    }

    [Fact]
    public async Task UpdateBooking_ReturnsOkObjectResult()
    {
        // Arrange
        var booking = new Booking { Id = 1, CustomerName = "John Doe", CheckInDate = DateTime.Now, CheckOutDate = DateTime.Now.AddDays(1), RoomType = "Deluxe" };
        _mockBookingService.Setup(service => service.UpdateBookingAsync(1, booking)).ReturnsAsync(booking);

        // Act
        var result = await _controller.UpdateBooking(1, booking);

        // Assert
        var actionResult = Assert.IsType<OkObjectResult>(result);
        var returnValue = Assert.IsType<Booking>(actionResult.Value);
        Assert.Equal(booking.Id, returnValue.Id);
    }

    [Fact]
    public async Task DeleteBooking_ReturnsNoContentResult()
    {
        // Arrange
        _mockBookingService.Setup(service => service.DeleteBookingAsync(1)).ReturnsAsync(true);

        // Act
        var result = await _controller.DeleteBooking(1);

        // Assert
        Assert.IsType<NoContentResult>(result);
    }

    [Fact]
    public async Task DeleteBooking_ReturnsNotFoundResult()
    {
        // Arrange
        _mockBookingService.Setup(service => service.DeleteBookingAsync(1)).ReturnsAsync(false);

        // Act
        var result = await _controller.DeleteBooking(1);

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }
}
