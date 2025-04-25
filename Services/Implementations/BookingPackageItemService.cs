using AutoMapper;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.Common.Modal;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;
using EventBookingManagementSystem_Backend.Repositories.Implementations;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Interfaces;

namespace EventBookingManagementSystem_Backend.Services.Implementations
{
    public class BookingPackageItemService : IBookingPackageItemService
    {
        private readonly IBookingPackageItemRepository _repository;
        private readonly IMapper _mapper; 
        private readonly IItemRepository _itemRepository;
        private readonly IBooking_PackageRepository _bookingPackageRepository;
        

        public BookingPackageItemService(IBookingPackageItemRepository repository, 
            IMapper mapper,
            IItemRepository itemRepository,
            IBooking_PackageRepository bookingPackageRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _itemRepository = itemRepository;
            _bookingPackageRepository = bookingPackageRepository;
        }

        public async Task<IEnumerable<BookingPackageItemDto>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<BookingPackageItemDto>>(items);
        }

        public async Task<BookingPackageItemDto> GetByIdAsync(Guid id)
        {
            var item = await _repository.GetByIdAsync(id);
            return _mapper.Map<BookingPackageItemDto>(item);
        }

        public async Task CreateAsync(CreateBookingPackageItemDto dto)
        {
            var itemExists = await _itemRepository.ExistsAsync(dto.ItemId);
            if (!itemExists)
                throw new ArgumentException($"Item with ID '{dto.ItemId}' does not exist.");

            var packageExists = await _bookingPackageRepository.ExistsAsync(dto.BookingPackageId);
            if (!packageExists)
                throw new ArgumentException($"BookingPackage with ID '{dto.BookingPackageId}' does not exist.");


            var entity = _mapper.Map<Booking_Package_Item>(dto);
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(UpdateBookingPackageItemDto dto)
        {
            // 1. Validate foreign keys
            var bookingPackageExists =await _bookingPackageRepository.ExistsAsync(dto.BookingPackageId);
            var itemExists = await _itemRepository.ExistsAsync(dto.ItemId);

            if (!bookingPackageExists)
                throw new ArgumentException("Invalid BookingPackageId");

            if (!itemExists)
                throw new ArgumentException("Invalid ItemId");

            // 2. Check if the entity exists before updating
            var existingEntity = await _repository.GetByCompositeKeyAsync(dto.BookingPackageId, dto.ItemId);
            if (existingEntity == null)
                throw new KeyNotFoundException("Booking_Package_Item not found.");

            // 3. Map the update data to the existing entity
            _mapper.Map(dto, existingEntity);

            // 4. Persist the update
            await _repository.UpdateAsync(existingEntity);
        }

        public async Task DeleteAsync(Guid id) => await _repository.DeleteAsync(id);
    }
}
