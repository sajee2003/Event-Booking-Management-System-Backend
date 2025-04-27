using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Interfaces;

namespace EventBookingManagementSystem_Backend.Services.Implementations
{
    public class Item_PriceService : IItem_PriceService
    {
        private readonly IItem_PriceRepository _repository;

        public Item_PriceService(IItem_PriceRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Item_PriceResponse>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return items.Select(item => new Item_PriceResponse
            {
                Id = item.ID,
                ItemId = item.ItemId,
                BasePrice = item.base_price,
                Currency = item.currency,
                AssetId = item.assetId,
                Price = item.price,
                ValidFrom = item.ValidFrom,
                ValidTo = item.ValidTo
            });
        }

        public async Task<Item_PriceResponse> GetByIdAsync(Guid id)
        {
            var item = await _repository.GetByIdAsync(id);
            if (item == null) return null;

            return new Item_PriceResponse
            {
                Id = item.ID,
                ItemId = item.ItemId,
                BasePrice = item.base_price,
                Currency = item.currency,
                AssetId = item.assetId,
                Price = item.price,
                ValidFrom = item.ValidFrom,
                ValidTo = item.ValidTo
            };
        }

        public async Task<Item_PriceResponse> CreateAsync(Item_PriceRequest dto)
        {
            var item = new Item_Price
            {
                ID =new Guid (),
                ItemId = dto.ItemId,
                base_price = dto.BasePrice,
                currency = dto.Currency,
                assetId = dto.AssetId,
                price = dto.Price,
                ValidFrom = dto.ValidFrom,
                ValidTo = dto.ValidTo
            };

            var created = await _repository.AddAsync(item);

            return new Item_PriceResponse
            {
                Id = created.ID,
                ItemId = created.ItemId,
                BasePrice = created.base_price,
                Currency = created.currency,
                AssetId = created.assetId,
                Price = created.price,
                ValidFrom = created.ValidFrom,
                ValidTo = created.ValidTo
            };
        }

        public async Task<Item_PriceResponse> UpdateAsync(Guid id, Item_PriceRequest dto)
        {
            var item = await _repository.GetByIdAsync( id);
            if (item == null) return null;

            item.ItemId = dto.ItemId;
            item.base_price = dto.BasePrice;
            item.currency = dto.Currency;
            item.assetId = dto.AssetId;
            item.price = dto.Price;
            item.ValidFrom = dto.ValidFrom;
            item.ValidTo = dto.ValidTo;

            var updated = await _repository.UpdateAsync(item);

            return new Item_PriceResponse
            {
                Id = updated.ID,
                ItemId = updated.ItemId,
                BasePrice = updated.base_price,
                Currency = updated.currency,
                AssetId = updated.assetId,
                Price = updated.price,
                ValidFrom = updated.ValidFrom,
                ValidTo = updated.ValidTo
            };
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
            return true;
        }
    }

}
