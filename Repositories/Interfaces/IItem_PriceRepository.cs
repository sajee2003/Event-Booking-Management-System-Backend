using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.Repositories.Interfaces
{
    public interface IItem_PriceRepository
    {
        Task<IEnumerable<Item_Price>> GetAllAsync();
        Task<Item_Price> GetByIdAsync(Guid id);

        Task<Item_Price> AddAsync(Item_Price itemPrice);

        Task<Item_Price> UpdateAsync(Item_Price itemPrice);
        Task<bool> DeleteAsync(Guid id);


    }
}
