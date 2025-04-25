using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.Repositories.Interfaces
{
    public interface IPackage_ItemRepository
    {
        Task<List<Package_Item>> GetAllPackageItems();
        Task<Package_Item> GetPackageItemById(Guid id);
        Task<List<Package_Item>> GetPackageItemsByPackageId(Guid packageId);
        Task<List<Package_Item>> GetPackageItemsByItemId(Guid itemId);
        Task<List<Package_Item>> GetPackageItemsByAssetId(Guid assetId);
        Task<Package_Item> AddPackageItem(Package_Item package_Item);
        Task<Package_Item> UpdatePackageItem(Package_Item package_Item);
        Task<bool> DeletePackageItem(Guid id);

    }
}
