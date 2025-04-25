using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;

namespace EventBookingManagementSystem_Backend.Services.Interfaces
{
    public interface IItemCategoryService
    {

        Task<IEnumerable<Item_Category>> GetAllAsync();
        Task<Item_Category> GetByIdAsync(Guid id);
        Task<Item_Category> AddAsync(ItemCategoryRequest dto);
        Task<Item_Category> UpdateAsync(Guid id, ItemCategoryRequest dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
