using API.InterviewChallenge.Core.Domain.Models;

namespace API.InterviewChallenge.Core.Adapters.Persistence
{
    public class InMemoryDbContext
    {
        private readonly List<Booking> _bookings = new List<Booking>();

        public List<Booking> Bookings => _bookings;
    }
}
