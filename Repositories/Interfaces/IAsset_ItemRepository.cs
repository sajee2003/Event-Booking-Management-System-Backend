using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.Repositories.Interfaces
{
    public interface IAsset_ItemRepository
    {
        Task<IEnumerable<Asset_Item>> GetAllAsync();
        Task<Asset_Item> GetByIdAsync(Guid id);
        Task AddAsync(Asset_Item assetItem);
        void Update(Asset_Item assetItem);
        void Delete(Asset_Item assetItem);
        Task<bool> SaveChangesAsync();
    }


}
