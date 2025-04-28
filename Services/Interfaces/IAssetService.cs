using EventBookingManagementSystem_Backend.Controllers;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.CommonModules;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingManagementSystem_Backend.Services.Interfaces
{
    public interface IAssetService
    {
        // Task<IActionResult> GetAllAsset();

        Task<IEnumerable<Asset>> GetAllAsset();
        Task<AssetDTO> GetByIdAsync(Guid id);
        Task<Asset> CreateAssetAsync(AssetRequest assetDto);
        Task<AssetDTO> UpdateAsync(Guid id, AssetDTO asset);
        Task<bool> DeleteAsset(Guid id);




    }
}
