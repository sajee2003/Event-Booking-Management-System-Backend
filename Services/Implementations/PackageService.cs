using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Interfaces;

namespace EventBookingManagementSystem_Backend.Services.Implementations
{
    public class PackageService : IPackageService
    {
        private readonly IPackageRepository _repository;

        public PackageService(IPackageRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<PackageResponse>> GetAllAsync()
        {
            var packages = await _repository.GetAllAsync();
            return packages.Select(p => new PackageResponse
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                price = p.price
            });
        }

        public async Task<PackageResponse> GetByIdAsync(Guid id)
        {
            var p = await _repository.GetByIdAsync(id);
            if (p == null) return null;

            return new PackageResponse
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                price = p.price
            };
        }

        public async Task<PackageResponse> AddAsync(PackageRequest dto)
        {
            var package = new Package
            {
                Name = dto.Name,
                Description = dto.Description,
                price = dto.price
            };

            var result = await _repository.AddAsync(package);

            return new PackageResponse
            {
                Id = result.Id,
                Name = result.Name,
                Description = result.Description,
                price = result.price
            };
        }

        public async Task<PackageResponse> UpdateAsync(Guid id, PackageRequest dto)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null) return null;

            existing.Name = dto.Name;
            existing.Description = dto.Description;
            existing.price = dto.price;

            var updated = await _repository.UpdateAsync(existing);

            return new PackageResponse
            {
                Id = updated.Id,
                Name = updated.Name,
                Description = updated.Description,
                price = updated.price
            };
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }

}
