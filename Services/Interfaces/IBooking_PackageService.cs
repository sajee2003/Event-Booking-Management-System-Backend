using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;

namespace EventBookingManagementSystem_Backend.Services.Interfaces
{
    public interface IBooking_PackageService
    {
        Task<List<Booking_PackageResponse>> GetAllBooking_Packages();
        Task<Booking_PackageResponse> GetBooking_PackageById(int id);
        Task<List<Booking_PackageResponse>> GetBooking_PackagesByBookingId(Guid bookingId);
        Task<List<Booking_PackageResponse>> GetBooking_PackagesByPackageId(Guid packageId);
        Task<Booking_PackageResponse> AddBooking_Package(Booking_PackageRequest booking_packageRequest);
        Task<Booking_PackageResponse> UpdateBooking_Package(int id, Booking_PackageRequest booking_packageRequest);
        Task<bool> DeleteBooking_Package(int id);
    }
}
