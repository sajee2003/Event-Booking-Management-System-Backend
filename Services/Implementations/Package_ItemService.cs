using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Interfaces;

namespace EventBookingManagementSystem_Backend.Services.Implementations
{
    public class Package_ItemService : IPackage_ItemService
    {
        private readonly IPackage_ItemRepository _package_ItemRepository;

        public Package_ItemService(IPackage_ItemRepository package_ItemRepository)
        {
            _package_ItemRepository = package_ItemRepository;
        }

        // get all package item

        public async Task<List<Package_ItemResponse>> GetAllPackageItems()
        {
             var data = await _package_ItemRepository.GetAllPackageItems();
             return data.Select(x => new Package_ItemResponse
             {
                 Id = x.Id,
                 PackageId = x.PackageId,
                 ItemId = x.ItemId,
                 AssetId = x.AssetId
             }).ToList();
        }

        // get package item by packageId
        public async Task<List<Package_ItemResponse>> GetPackageItemsByPackageId(Guid packageId)
        {
            var data = await _package_ItemRepository.GetPackageItemsByPackageId(packageId);
            return data.Select(x => new Package_ItemResponse
            {
                Id = x.Id,
                PackageId = x.PackageId,
                ItemId = x.ItemId,
                AssetId = x.AssetId
            }).ToList();
        }

        // get package item by itemId

        public async Task<List<Package_ItemResponse>> GetPackageItemsByItemId(Guid itemId)
        {
            var data = await _package_ItemRepository.GetPackageItemsByItemId(itemId);
            return data.Select(x => new Package_ItemResponse
            {
                Id = x.Id,
                PackageId = x.PackageId,
                ItemId = x.ItemId,
                AssetId = x.AssetId
            }).ToList();
        }

        // get package item by assetId

        public async Task<List<Package_ItemResponse>> GetPackageItemsByAssetId(Guid assetId)
        {
            var data = await _package_ItemRepository.GetPackageItemsByAssetId(assetId);
            return data.Select(x => new Package_ItemResponse
            {
                Id = x.Id,
                PackageId = x.PackageId,
                ItemId = x.ItemId,
                AssetId = x.AssetId
            }).ToList();
        }

        // add package item

        public async Task<Package_ItemResponse> AddPackageItem(Package_ItemRequest package_Item)
        {
            var addedPackageItem = new Package_Item
            {
                Id = Guid.NewGuid(),
                PackageId = package_Item.PackageId,
            };
            var data = await _package_ItemRepository.AddPackageItem(addedPackageItem);
            return new Package_ItemResponse
            {
                Id = data.Id,
                PackageId = data.PackageId,
                ItemId = data.ItemId,
                AssetId = data.AssetId
            };
        }

        // update package item

        public async Task<Package_ItemResponse> UpdatePackageItem(Guid Id, Package_ItemRequest package_Item)
        {
            var data = await _package_ItemRepository.GetPackageItemById(Id);

            data.PackageId = package_Item.PackageId;
            data.ItemId = package_Item.ItemId;
            data.AssetId = package_Item.AssetId;


            var res = await _package_ItemRepository.UpdatePackageItem(data);
            return new Package_ItemResponse
            {
                Id = res.Id,
                PackageId = res.PackageId,
                ItemId = res.ItemId,
                AssetId = res.AssetId
            };
        }

        // delete package item

        public async Task<bool> DeletePackageItem(Guid id)
        {
            return await _package_ItemRepository.DeletePackageItem(id);
        }
    }
}
