using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{
    public class BookingAssetRepository : IBookingAssetRepository
    {
        private readonly ApplicationDbContext _context;

        public BookingAssetRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Booking_Asset>> GetAllAsync() =>
        await _context.Booking_Assets.ToListAsync();

        public async Task<Booking_Asset> GetByIdAsync(Guid id) =>
        await _context.Booking_Assets.FindAsync(id);

        public async Task<IEnumerable<Booking_Asset>> GetByBookingIdAsync(Guid bookingId) =>
            await _context.Booking_Assets
                .Where(b => b.BookingId == bookingId)
        .ToListAsync();

        public async Task AddAsync(Booking_Asset bookingAsset)
        {

            await _context.Booking_Assets.AddAsync(bookingAsset);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Booking_Asset bookingAsset)
        {
            _context.Booking_Assets.Update(bookingAsset);
            await _context.SaveChangesAsync();
        }


        public void Delete(Booking_Asset bookingAsset)
        {
            _context.Booking_Assets.Remove(bookingAsset);
            _context.SaveChanges();
        }


    }
}
