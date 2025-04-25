using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using Microsoft.EntityFrameworkCore;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{
    public class ItemCategoryRepository : IItemCategoryRepository
    {


        private readonly ApplicationDbContext _context;

        public ItemCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Item_Category>> GetAllAsync()
        {
            return await _context.Item_Categories.ToListAsync();
        }

        public async Task<Item_Category> GetByIdAsync(Guid id)
        {
            return await _context.Item_Categories.FindAsync(id);
        }

        public async Task<Item_Category> AddAsync(Item_Category category)
        {
            _context.Item_Categories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Item_Category> UpdateAsync(Item_Category category)
        {
            _context.Item_Categories.Update(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var category = await _context.Item_Categories.FindAsync(id);
            if (category == null)
                return false;

            _context.Item_Categories.Remove(category);
            await _context.SaveChangesAsync();
            return true;
        }

        public Task<Item_Category> AddAsync(ItemCategoryRequest dto)
        {
            throw new NotImplementedException();
        }

        public Task<Item_Category> UpdateAsync(Guid id, ItemCategoryRequest dto)
        {
            throw new NotImplementedException();
        }
    }
}
