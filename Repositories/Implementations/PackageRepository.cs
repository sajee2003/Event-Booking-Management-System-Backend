using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{
    public class PackageRepository : IPackageRepository
    {
        private readonly ApplicationDbContext _context;

        public PackageRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Package>> GetAllAsync()
        {
            var data = await _context.Packages.ToListAsync();
            return data;
        }

        public async Task<Package> GetByIdAsync(Guid id)
        {
            var data = await _context.Packages.FindAsync(id);
            return data;
        }

        public async Task<Package> AddAsync(Package package)
        {
            _context.Packages.Add(package);
            await _context.SaveChangesAsync();
            return package;
        }

        public async Task<Package> UpdateAsync(Package package)
        {
            _context.Packages.Update(package);
            await _context.SaveChangesAsync();
            return package;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var existing = await GetByIdAsync(id);
            if (existing == null) return false;

            _context.Packages.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }
    }

}
