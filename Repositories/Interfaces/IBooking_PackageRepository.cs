using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.Repositories.Interfaces
{
    public interface IBooking_PackageRepository
    {
        Task<List<Booking_Package>> GetAllBooking_Packages();
        Task<Booking_Package> GetBooking_PackageById(Guid id);
        Task<List<Booking_Package>> GetBooking_PackagesByBookingId(Guid bookingId);
        Task<List<Booking_Package>> GetBooking_PackagesByPackageId(Guid packageId);
        Task<Booking_Package> AddBooking_Package(Booking_Package booking_package);
        Task<Booking_Package> UpdateBooking_Package(Booking_Package booking_package);
        Task<bool> DeleteBooking_Package(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
