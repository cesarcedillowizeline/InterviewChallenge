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
            throw new NotImplementedException();
        }

        public Task<Booking> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Booking>> GetBookingAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Task<Booking> UpdateAsync(Booking booking)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
