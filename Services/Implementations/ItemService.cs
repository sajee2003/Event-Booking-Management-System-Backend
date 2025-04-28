using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Interfaces;

namespace EventBookingManagementSystem_Backend.Services.Implementations
{
    public class ItemService : IItemService
    {


        private readonly IItemRepository _repository;

        public ItemService(IItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Item>> GetAllAsync()
        {


            var Data = await _repository.GetAllAsync();

            return Data;
        }

        public Task<Item> GetByIdAsync(Guid id)
        {
            var Data = _repository.GetByIdAsync(id); ;

            return Data;
        }


        public Task<Item> AddAsync(ItemRequest dto)
        {
            var item = new Item
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                description = dto.Description,
                ItemCategoryId = dto.ItemCategoryId
            };
            return _repository.AddAsync(item);
        }

        public async Task<Item> UpdateAsync(Guid id, ItemRequest dto)
        {
            var data = await _repository.GetByIdAsync(id);
            if (data == null) return null;

            data.Name = dto.Name;
            data.description = dto.Description;
            data.ItemCategoryId = dto.ItemCategoryId;

            return await _repository.UpdateAsync(data);
        }


        public async Task<bool> DeleteAsync(Guid id)
        {
            var data = await _repository.GetByIdAsync(id);
            if (data == null)
                return false;
            return await _repository.DeleteAsync(data);
        }
    }
}
