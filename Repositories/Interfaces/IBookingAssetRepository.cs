using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.Repositories.Interfaces
{
    public interface IBookingAssetRepository
    {
        Task<IEnumerable<Booking_Asset>> GetAllAsync();
        Task<Booking_Asset> GetByIdAsync(Guid id);
        Task<IEnumerable<Booking_Asset>> GetByBookingIdAsync(Guid bookingId);
        Task AddAsync(Booking_Asset bookingAsset);
        Task Update(Booking_Asset bookingAsset);
        void Delete(Booking_Asset bookingAsset);
    }
}
