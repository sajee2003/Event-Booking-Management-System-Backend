using EventBookingManagementSystem_Backend.DTOs.Common.Modal;

namespace EventBookingManagementSystem_Backend.Services.Interfaces
{
    public interface IBookingAssetService
    {
        Task<IEnumerable<BookingAssetDto>> GetAllAsync();
        Task<BookingAssetDto> GetByIdAsync(Guid id);
        Task<IEnumerable<BookingAssetDto>> GetByBookingIdAsync(Guid bookingId);
        Task<BookingAssetDto> CreateAsync(CreateBookingAssetDto bookingAsset);
        Task<bool> UpdateAsync(UpdateBookingAssetDto bookingAsset);
        Task<bool> DeleteAsync(Guid id);
    }
}
