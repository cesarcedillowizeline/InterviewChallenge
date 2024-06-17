using API.InterviewChallenge.Core.Domain.Models;

namespace API.InterviewChallenge.Core.Domain.Interfaces
{
    public interface IBookingService
    {
        Task<Booking> CreateBookingAsync(Booking booking);
        Task<Booking> GetBookingAsync(int id);
        Task<Booking> UpdateBookingAsync(int id, Booking booking);
        Task<List<Booking>> GetBookingAsync(DateTime startDate, DateTime endDate);
        Task<bool> DeleteBookingAsync(int id);
    }
}
