using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.Repositories.Interfaces
{
    public interface IBookingPackageItemRepository
    {
        Task<IEnumerable<Booking_Package_Item>> GetAllAsync();
        Task<Booking_Package_Item> GetByIdAsync(Guid id);
        Task AddAsync(Booking_Package_Item entity);
        Task UpdateAsync(Booking_Package_Item entity);
        Task DeleteAsync(Guid id);
        Task<Booking_Package_Item> GetByCompositeKeyAsync(Guid bookingPackageId, Guid itemId);
    }
}
