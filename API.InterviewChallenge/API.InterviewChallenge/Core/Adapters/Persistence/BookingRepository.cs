using API.InterviewChallenge.Core.Domain.Interfaces;
using API.InterviewChallenge.Core.Domain.Models;

namespace API.InterviewChallenge.Core.Adapters.Persistence
{
    public class BookingRepository : IBookingRepository
    {
        private readonly InMemoryDbContext _context;

        public BookingRepository(InMemoryDbContext context)
        {
            _context = context;
        }

        public Task<Booking> AddAsync(Booking booking)
        {
            _context.Bookings.Add(booking);
            return Task.FromResult(booking);
        }

        public Task<Booking> GetByIdAsync(int id)
        {
            return Task.FromResult(_context.Bookings.FirstOrDefault(b => b.Id == id));
        }

        public Task<Booking> UpdateAsync(Booking booking)
        {
            var existingBooking = _context.Bookings.FirstOrDefault(b => b.Id == booking.Id);
            if (existingBooking != null)
            {
                _context.Bookings.Remove(existingBooking);
                _context.Bookings.Add(booking);
            }
            return Task.FromResult(booking);
        }

        public Task<bool> DeleteAsync(int id)
        {
            var booking = _context.Bookings.FirstOrDefault(b => b.Id == id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}
