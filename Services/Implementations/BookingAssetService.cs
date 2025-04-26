using AutoMapper;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.Common.Modal;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Interfaces;

namespace EventBookingManagementSystem_Backend.Services.Implementations
{
    public class BookingAssetService : IBookingAssetService
    {
        private readonly IBookingAssetRepository _repository;
        private readonly IMapper _mapper;

        public BookingAssetService(IBookingAssetRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BookingAssetDto>> GetAllAsync()
        {
            var list = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<BookingAssetDto>>(list);
        }

        public async Task<BookingAssetDto> GetByIdAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
                throw new KeyNotFoundException($"BookingAsset with ID {id} not found.");

            return _mapper.Map<BookingAssetDto>(entity);
        }

        public async Task<IEnumerable<BookingAssetDto>> GetByBookingIdAsync(Guid bookingId)
        {
            var list = await _repository.GetByBookingIdAsync(bookingId);
            return _mapper.Map<IEnumerable<BookingAssetDto>>(list);
        }

        public async Task<BookingAssetDto> CreateAsync(CreateBookingAssetDto dto)
        {
            var entity = _mapper.Map<Booking_Asset>(dto);
            await _repository.AddAsync(entity);

            return _mapper.Map<BookingAssetDto>(entity);
        }

        public async Task<bool> UpdateAsync(UpdateBookingAssetDto dto)
        {
            var existing = await _repository.GetByIdAsync(dto.Id);
            if (existing == null) return false;

            _mapper.Map(dto, existing);
            _repository.Update(existing);

            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return false;

            _repository.Delete(entity);

            return true;
        }
    }
}
