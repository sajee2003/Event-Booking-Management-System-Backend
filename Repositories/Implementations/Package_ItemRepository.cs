using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{
    public class Package_ItemRepository : IPackage_ItemRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public Package_ItemRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        // get all package items
        public async Task<List<Package_Item>> GetAllPackageItems()
        {
            return await applicationDbContext.Package_Items.ToListAsync();
        }

        // get package item by id

        public async Task<Package_Item> GetPackageItemById(Guid id)
        {
            return await applicationDbContext.Package_Items.SingleOrDefaultAsync(x => x.Id == id);
        }

        // get package item by package id

        public async Task<List<Package_Item>> GetPackageItemsByPackageId(Guid packageId)
        {
            return await applicationDbContext.Package_Items.Where(x => x.PackageId == packageId).ToListAsync();
        }

        // get package item by item id

        public async Task<List<Package_Item>> GetPackageItemsByItemId(Guid itemId)
        {
            return await applicationDbContext.Package_Items.Where(x => x.ItemId == itemId).ToListAsync();
        }

        // get package item by asset id

        public async Task<List<Package_Item>> GetPackageItemsByAssetId(Guid assetId)
        {
            return await applicationDbContext.Package_Items.Where(x => x.AssetId == assetId).ToListAsync();
        }


        // add package item
        public async Task<Package_Item> AddPackageItem(Package_Item package_Item)
        {
            await applicationDbContext.Package_Items.AddAsync(package_Item);
            await applicationDbContext.SaveChangesAsync();
            return package_Item;
        }

        // update package item

        public async Task<Package_Item> UpdatePackageItem(Package_Item package_Item)
        {
            applicationDbContext.Package_Items.Update(package_Item);
            await applicationDbContext.SaveChangesAsync();
            return package_Item;
        }

        // delete package item

        public async Task<bool> DeletePackageItem(Guid id)
        {
            var package_Item = await applicationDbContext.Package_Items.FindAsync(id);
            if (package_Item == null)
            {
                return false;
            }
            applicationDbContext.Package_Items.Remove(package_Item);
            await applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
