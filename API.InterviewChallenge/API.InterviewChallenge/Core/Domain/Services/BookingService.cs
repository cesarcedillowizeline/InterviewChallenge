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
            // Business logic for creating a booking
            return await _bookingRepository.AddAsync(booking);
        }

        public async Task<Booking> GetBookingAsync(int id)
        {
            return await _bookingRepository.GetByIdAsync(id);
        }

        public async Task<Booking> UpdateBookingAsync(int id, Booking booking)
        {
            // Business logic for updating a booking
            return await _bookingRepository.UpdateAsync(booking);
        }

        public async Task<bool> DeleteBookingAsync(int id)
        {
            return await _bookingRepository.DeleteAsync(id);
        }
    }
}
