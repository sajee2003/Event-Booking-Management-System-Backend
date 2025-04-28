
using System.Threading.Tasks;
using EventBookingManagementSystem_Backend.DB.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingManagementSystem_Backend.Repositories.Interfaces
{
    public interface IAssetRepository
    {
        Task<List<Asset>> GetAllAsset();
        Task<Asset> GetByIdAsync(Guid id);
        Task<Asset> CreateAssetAsync(Asset asset);
        Task<Asset> UpdateAsync(Asset asset);
        Task<bool> DeleteAsync(Guid id);
    }
}
