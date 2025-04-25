using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationDbContext _context;

        public ItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Item>> GetAllAsync()
        {
            return await _context.Items.Include(i => i.ItemCategory).ToListAsync();
        }


     //       public async Task<List<Item>> GetAllAsync()
     //   {
     //       return await _context.Items
     //.Include(i => i.ItemCategory)
     //.Include(i => i.Asset_Items)
     //    .ThenInclude(ai => ai.Asset)
     //.Include(i => i.Item_Prices)
     //.Include(i => i.Package_Items)
     //    .ThenInclude(pi => pi.Package)
     //.Include(i => i.Booking_Package_Items)
     //    .ThenInclude(bpi => bpi.BookingPackage)
     //.AsSplitQuery()
     //.ToListAsync();

     //   }

        public async Task<Item?> GetByIdAsync(Guid id)
        {
            return await _context.Items
                .Include(i => i.ItemCategory)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<Item> AddAsync(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<Item> UpdateAsync(Item item)
        {

            _context.Items.Update(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<bool> DeleteAsync(Item item)
        {
            //var item = await _context.Items.FindAsync(id);
            //if (item == null) return false;

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }

        public Task<Item> AddAsync(ItemRequest dto)
        {
            throw new NotImplementedException();
        }

        public Task<Item> UpdateAsync(Guid id, ItemRequest dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(Guid id) {
            return await _context.Items.AnyAsync(i => i.Id == id);
        }
    }
}
