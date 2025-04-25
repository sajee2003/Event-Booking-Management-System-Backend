using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;

namespace EventBookingManagementSystem_Backend.Services.Interfaces
{
    public interface IItem_PriceService
    {
        Task<IEnumerable<Item_PriceResponse>> GetAllAsync();
        Task<Item_PriceResponse> GetByIdAsync(Guid id);
        Task<Item_PriceResponse> CreateAsync(Item_PriceRequest dto);
        Task<Item_PriceResponse> UpdateAsync(Guid id, Item_PriceRequest dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
