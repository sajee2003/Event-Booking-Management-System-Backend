using EventBookingManagementSystem_Backend.DTOs.Common.Modal;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;

namespace EventBookingManagementSystem_Backend.Services.Interfaces
{
    public interface IBookingPackageItemService
    {
        Task<IEnumerable<BookingPackageItemDto>> GetAllAsync();
        Task<BookingPackageItemDto> GetByIdAsync(Guid id);
        Task CreateAsync(CreateBookingPackageItemDto dto);
        Task UpdateAsync(UpdateBookingPackageItemDto dto);
        Task DeleteAsync(Guid id);
    }
}
