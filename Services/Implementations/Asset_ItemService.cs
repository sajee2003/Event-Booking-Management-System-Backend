using EventBookingManagementSystem_Backend.Controllers;
using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.CommonModules;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventBookingManagementSystem_Backend.Services.Implementations
{
    public class Asset_ItemService : IAsset_ItemService
    {
        private readonly IAsset_ItemRepository _repository;

        public Asset_ItemService(IAsset_ItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Asset_ItemResponseDto>> GetAllAsync()
        {
            var assetItems = await _repository.GetAllAsync();

            return assetItems.Select(item => new Asset_ItemResponseDto
            {
                Id = item.Id,
                AssetId = item.AssetId,
                ItemId = item.ItemId
            });
        }

        public async Task<Asset_ItemResponseDto> GetByIdAsync(Guid id)
        {
            var assetItem = await _repository.GetByIdAsync(id);
            if (assetItem == null) return null;

            return new Asset_ItemResponseDto
            {
                Id = assetItem.Id,
                AssetId = assetItem.AssetId,
                ItemId = assetItem.ItemId
            };
        }

        public async Task<Asset_ItemResponseDto> CreateAsync(Asset_ItemRequestDto request)
        {
            var newAssetItem = new Asset_Item
            {
                Id = Guid.NewGuid(),
                AssetId = request.AssetId,
                ItemId = request.ItemId
            };

            await _repository.AddAsync(newAssetItem);
            await _repository.SaveChangesAsync();

            return new Asset_ItemResponseDto
            {
                Id = newAssetItem.Id,
                AssetId = newAssetItem.AssetId,
                ItemId = newAssetItem.ItemId
            };
        }

        public async Task<bool> UpdateAsync(Guid id, Asset_ItemRequestDto request)
        {
            var assetItem = await _repository.GetByIdAsync(id);
            if (assetItem == null) return false;

            assetItem.AssetId = request.AssetId;
            assetItem.ItemId = request.ItemId;

            _repository.Update(assetItem);
            return await _repository.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var assetItem = await _repository.GetByIdAsync(id);
            if (assetItem == null) return false;

            _repository.Delete(assetItem);
            return await _repository.SaveChangesAsync();
        }
    }


}
