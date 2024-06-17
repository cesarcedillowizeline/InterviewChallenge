using API.InterviewChallenge.Core.Adapters.Persistence;
using API.InterviewChallenge.Core.Domain.Models;

namespace API.InterviewChallenge.Core.Domain.Interfaces
{
    public interface IBookingRepository
    {
        Task<Booking> AddAsync(Booking booking);
        Task<Booking> GetByIdAsync(int id);
        Task<Booking> UpdateAsync(Booking booking);
        Task<bool> DeleteAsync(int id);
    }
}
