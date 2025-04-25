using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.Repositories.Interfaces
{
    public interface IItemRepository
    {

        Task<List<Item>> GetAllAsync();
        Task<Item?> GetByIdAsync(Guid id);
        Task<Item> AddAsync(Item item);
        Task<Item> UpdateAsync(Item item);
        Task<bool> DeleteAsync(Item item);
        Task<bool> ExistsAsync(Guid id);
    }
}
