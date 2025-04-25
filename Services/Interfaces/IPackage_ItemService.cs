using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;

namespace EventBookingManagementSystem_Backend.Services.Interfaces
{
    public interface IPackage_ItemService
    {
        Task<List<Package_ItemResponse>> GetAllPackageItems();
        Task<List<Package_ItemResponse>> GetPackageItemsByPackageId(Guid packageId);
        Task<List<Package_ItemResponse>> GetPackageItemsByItemId(Guid itemId);
        Task<List<Package_ItemResponse>> GetPackageItemsByAssetId(Guid assetId);
        Task<Package_ItemResponse> AddPackageItem(Package_ItemRequest package_Item);
        Task<Package_ItemResponse> UpdatePackageItem(Guid Id,Package_ItemRequest package_Item);
        Task<bool> DeletePackageItem(Guid id);
    }
}
