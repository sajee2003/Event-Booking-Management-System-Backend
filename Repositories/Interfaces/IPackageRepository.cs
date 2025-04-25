using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.Repositories.Interfaces
{
    public interface IPackageRepository
    {
        Task<IEnumerable<Package>> GetAllAsync();
        Task<Package> GetByIdAsync(Guid id);
        Task<Package> AddAsync(Package package);
        Task<Package> UpdateAsync(Package package);
        Task<bool> DeleteAsync(Guid id);
    }
}
