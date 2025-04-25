using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;
using System.Threading.Tasks;

namespace EventBookingManagementSystem_Backend.Services.Interfaces
{
    public interface IPackageService
    {
        Task<IEnumerable<PackageResponse>> GetAllAsync();
        Task<PackageResponse> GetByIdAsync(Guid id);
        Task<PackageResponse> AddAsync(PackageRequest dto);
        Task<PackageResponse> UpdateAsync(Guid id, PackageRequest dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
