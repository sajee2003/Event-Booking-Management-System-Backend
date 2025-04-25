using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Interfaces;

namespace EventBookingManagementSystem_Backend.Services.Implementations
{
    public class ItemCategoryService : IItemCategoryService
    {

        private readonly IItemCategoryRepository _repository;

        public ItemCategoryService(IItemCategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Item_Category>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Item_Category> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Item_Category> AddAsync(ItemCategoryRequest dto)
        {
            var entity = new Item_Category
            {
                Id = Guid.NewGuid(),
                name = dto.Name,
                description = dto.Description
            };

            return await _repository.AddAsync(entity);
        }

        public async Task<Item_Category> UpdateAsync(Guid id, ItemCategoryRequest dto)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null) return null;

            existing.name = dto.Name;
            existing.description = dto.Description;

            return await _repository.UpdateAsync(existing);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
