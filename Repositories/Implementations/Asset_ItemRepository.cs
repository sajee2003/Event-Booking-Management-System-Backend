using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{
    public class Asset_ItemRepository : IAsset_ItemRepository
    {
        private readonly ApplicationDbContext _context;

        public Asset_ItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Asset_Item>> GetAllAsync()
        {
            return await _context.Asset_Items.ToListAsync();
        }

        public async Task<Asset_Item> GetByIdAsync(Guid id)
        {
            return await _context.Asset_Items.FindAsync(id);
        }

        public async Task AddAsync(Asset_Item assetItem)
        {
            await _context.Asset_Items.AddAsync(assetItem);
        }

        public void Update(Asset_Item assetItem)
        {
            _context.Asset_Items.Update(assetItem);
        }

        public void Delete(Asset_Item assetItem)
        {
            _context.Asset_Items.Remove(assetItem);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}