using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{

    public class AssetRepository : IAssetRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public AssetRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        //public Task<IEnumerable<object>> GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<List<Asset>> GetAllAsset()
        {
            return await applicationDbContext.Assets.ToListAsync();
        }

        public async Task<Asset> GetByIdAsync(Guid id) =>
                await applicationDbContext.Assets.FindAsync(id);

        public async Task<Asset> AddAsync(Asset asset)
        {
            applicationDbContext.Assets.Add(asset);
            await applicationDbContext.SaveChangesAsync();
            return asset;
        }

        public async Task<Asset> UpdateAsync(Asset asset)
        {
            applicationDbContext.Assets.Update(asset);
            await applicationDbContext.SaveChangesAsync();
            return asset;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var asset = await applicationDbContext.Assets.FindAsync(id);
            if (asset == null) return false;

            applicationDbContext.Assets.Remove(asset);
            await applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
