using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.CommonModules;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingManagementSystem_Backend.Services.Implementations
{
    public class AssetService : IAssetService
    {
        private readonly IAssetRepository _assetRepository;

        public AssetService(IAssetRepository assetRepository)
        {
            _assetRepository = assetRepository;
        }


        public async Task<IEnumerable<Asset>> GetAllAsset()
        {
            var assets = await _assetRepository.GetAllAsset();
            return assets.Select(a => new Asset
            {
                Id = a.Id,
                Name = a.Name,
                //capacity = a.capacity,
                Description = a.Description,
                AssetStatus = a.AssetStatus
            });
        }

        public async Task<AssetDTO> GetByIdAsync(Guid id)
        {
            var asset = await _assetRepository.GetByIdAsync(id);
            if (asset == null) return null;

            return new AssetDTO
            {
                 
                Name = asset.Name,
                Description = asset.Description
            };
        }


        public async Task<AssetDTO> UpdateAsync(Guid id, AssetDTO asset)
        {
            var existing = await _assetRepository.GetByIdAsync(id);
            if (existing == null) return null;

            existing.Name = asset.Name;
            existing.Description = asset.Description;

            var updated = await _assetRepository.UpdateAsync(existing);
            return new AssetDTO
            {
               
                Name = updated.Name,
                Description = updated.Description
            };
        }
        public async Task CreateAssetAsync(Asset asset)
        {
            await _assetRepository.AddAsync(asset);
        }

        public async Task<bool> DeleteAsset(Guid id)
        {
            return await _assetRepository.DeleteAsync(id);
        }


    }
}
