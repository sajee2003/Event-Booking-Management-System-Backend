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
        await _context.Booking_Assets
            .Include(ba => ba.Booking)
            .Include(ba => ba.Asset)
            .ToListAsync();

        public async Task<Booking_Asset> GetByIdAsync(Guid id) =>
        await _context.Booking_Assets
            .Include(ba => ba.Booking)
            .Include(ba => ba.Asset).FirstOrDefaultAsync(ba => ba.Id == id);

        public async Task<IEnumerable<Booking_Asset>> GetByBookingIdAsync(Guid bookingId) =>
            await _context.Booking_Assets
            .Include(ba => ba.Booking)
            .Include(ba => ba.Asset)
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
