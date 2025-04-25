using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly ApplicationDbContext _context;

        public InvoiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Invoice>> GetAllAsync()
        {
            return await _context.Set<Invoice>().ToListAsync();
        }

        public async Task<Invoice> GetByIdAsync(Guid id)
        {
            return await _context.Set<Invoice>().FindAsync(id);
        }

        public async Task<Invoice> AddAsync(Invoice invoice)
        {
            _context.Set<Invoice>().Add(invoice);
            await _context.SaveChangesAsync();
            return invoice;
        }

        public async Task<Invoice> UpdateAsync(Invoice invoice)
        {
            _context.Set<Invoice>().Update(invoice);
            await _context.SaveChangesAsync();
            return invoice;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var existing = await GetByIdAsync(id);
            if (existing == null) return false;

            _context.Set<Invoice>().Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
