using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;

namespace EventBookingManagementSystem_Backend.Services.Interfaces
{
    public interface IBookingService
    {
        Task<List<BookingResponseDTO>> GetBookings();
        Task<BookingResponseDTO> GetBookingById(Guid Id);
        Task<List<BookingResponseDTO>> GetBookingsByUserId(Guid userId);
        Task<BookingResponseDTO> AddBooking(BookingRequestDTO booking);
        Task<BookingResponseDTO> UpdateBooking(Guid Id,BookingRequestDTO booking);
        Task<bool> DeleteBooking(Guid Id);
    }
}
