using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.CommonModules;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingManagementSystem_Backend.Services.Interfaces
{
    public interface IAsset_ItemService
    {
        Task<IEnumerable<Asset_ItemResponseDto>> GetAllAsync();
        Task<Asset_ItemResponseDto> GetByIdAsync(Guid id);
        Task<Asset_ItemResponseDto> CreateAsync(Asset_ItemRequestDto request);
        Task<bool> UpdateAsync(Guid id, Asset_ItemRequestDto request);
        Task<bool> DeleteAsync(Guid id);
    }
}
