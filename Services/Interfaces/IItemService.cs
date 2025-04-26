using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;

namespace EventBookingManagementSystem_Backend.Services.Interfaces
{
    public interface IItemService
    {
        Task<List<Item>> GetAllAsync();
        Task<Item> GetByIdAsync(Guid id);
        Task<Item> AddAsync(ItemRequest dto);

        Task<Item> UpdateAsync(Guid id, ItemRequest dto);

        Task<bool> DeleteAsync(Guid id);

    }
}
