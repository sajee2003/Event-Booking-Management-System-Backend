using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{
    public class BookingPackageItemRepository : IBookingPackageItemRepository
    {
        private readonly ApplicationDbContext _context;
        public BookingPackageItemRepository(ApplicationDbContext context) => _context = context;

        public async Task<IEnumerable<Booking_Package_Item>> GetAllAsync() =>
            await _context.Booking_Package_Items.ToListAsync();

        public async Task<Booking_Package_Item> GetByIdAsync(Guid id) =>
            await _context.Booking_Package_Items.FindAsync(id);

        public async Task AddAsync(Booking_Package_Item entity)
        {
            _context.Booking_Package_Items.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Booking_Package_Item entity)
        {
            _context.Booking_Package_Items.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await _context.Booking_Package_Items.FindAsync(id);
            if (item != null)
            {
                _context.Booking_Package_Items.Remove(item);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Booking_Package_Item> GetByCompositeKeyAsync(Guid bookingPackageId, Guid itemId) 
        { return await _context.Booking_Package_Items.FirstOrDefaultAsync(x => x.BookingPackageId == bookingPackageId && x.ItemId == itemId); }
    }
}
