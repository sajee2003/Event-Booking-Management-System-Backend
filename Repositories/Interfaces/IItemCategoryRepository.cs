using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.Repositories.Interfaces
{
    public interface IItemCategoryRepository
    {

        Task<IEnumerable<Item_Category>> GetAllAsync();
        Task<Item_Category> GetByIdAsync(Guid id);
        Task<Item_Category> AddAsync(Item_Category category);
        Task<Item_Category> UpdateAsync(Item_Category category);
        Task<bool> DeleteAsync(Guid id);
    }
}
