using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.Repositories.Interfaces
{
    public interface IBookingRepository
    {
        Task<List<Booking>> GetBookings();
        Task<Booking> GetBookingById(Guid Id);
        Task<List<Booking>> GetBookingsByUserId(Guid userId);
        Task<Booking> AddBooking(Booking booking);
        Task<Booking> UpdateBooking(Booking booking);
        Task<bool> DeleteBooking(Guid Id);
    }
}
