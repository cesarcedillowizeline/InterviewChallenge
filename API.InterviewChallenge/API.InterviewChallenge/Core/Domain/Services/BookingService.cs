using API.InterviewChallenge.Core.Domain.Interfaces;
using API.InterviewChallenge.Core.Domain.Models;

namespace API.InterviewChallenge.Core.Domain.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<Booking> CreateBookingAsync(Booking booking)
        {
            throw new NotImplementedException();
        }

        public async Task<Booking> GetBookingAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Booking>> GetBookingAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public async Task<Booking> UpdateBookingAsync(int id, Booking booking)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteBookingAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
