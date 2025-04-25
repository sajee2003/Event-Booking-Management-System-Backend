using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{
    public class ItemPriceRepository : IItem_PriceRepository
    {
        private readonly ApplicationDbContext _context;

        public ItemPriceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Item_Price>> GetAllAsync() =>
            await _context.ItemPrices.ToListAsync();

        public async Task<Item_Price> GetByIdAsync(Guid id)
        {
            return await _context.ItemPrices.FindAsync(id);
            
        }

        public async Task<Item_Price> AddAsync(Item_Price itemPrice)
        {
           _context.ItemPrices.Add(itemPrice);
            await _context.SaveChangesAsync();
            return itemPrice;
        }

        public async Task<Item_Price> UpdateAsync(Item_Price itemPrice)
        {
            _context.ItemPrices.Update(itemPrice);
            await _context.SaveChangesAsync();
            return itemPrice;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var item = await _context.ItemPrices.FindAsync(id);
            if (item == null) return false;

            _context.ItemPrices.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }
    }


}

