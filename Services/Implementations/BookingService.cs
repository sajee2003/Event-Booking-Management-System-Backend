using System.Collections.Immutable;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Interfaces;

namespace EventBookingManagementSystem_Backend.Services.Implementations
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        // get all bookings
        public async Task<List<BookingResponseDTO>> GetBookings()
        {
            var data = await _bookingRepository.GetBookings();
            if (data == null)
            {
                return null;
            }
            return data.Select(x => new BookingResponseDTO
            {
                BookingId = x.Id,
                date = x.date,
                start_time = x.start_time,
                end_time = x.end_time,
                status = x.status,
                amount = x.amount,
                UserId = x.Id
            }).ToList();
        }

        // get booking by id
        public async Task<BookingResponseDTO> GetBookingById(Guid Id)
        {
            var data = await _bookingRepository.GetBookingById(Id);
            if (data == null)
            {
                return null;
            }
            return new BookingResponseDTO
            {
                BookingId = data.Id,
                date = data.date,
                start_time = data.start_time,
                end_time = data.end_time,
                status = data.status,
                amount = data.amount,
                UserId = data.Id
            };
        }

        // get booking by user id
        public async Task<List<BookingResponseDTO>> GetBookingsByUserId(Guid userId)
        {
            var data = await _bookingRepository.GetBookingsByUserId(userId);
            if (data == null)
            {
                return null;
            }
            return data.Select(x => new BookingResponseDTO
            {
                BookingId = x.Id,
                date = x.date,
                start_time = x.start_time,
                end_time = x.end_time,
                status = x.status,
                amount = x.amount,
                UserId = x.Id
            }).ToList();
        }

        // add booking
        public async Task<BookingResponseDTO> AddBooking(BookingRequestDTO booking)
        {
            var data = new Booking
            {
                Id = Guid.NewGuid(),
                date = booking.date,
                start_time = booking.start_time,
                end_time = booking.end_time,
                status = booking.status,
                amount = booking.amount,
                userId = booking.UserId
            };
            var result = await _bookingRepository.AddBooking(data);
            if (result == null)
            {
                return null;
            }
            return new BookingResponseDTO
            {
                BookingId = result.Id,
                date = result.date,
                start_time = result.start_time,
                end_time = result.end_time,
                status = result.status,
                amount = result.amount,
                UserId = result.Id
            };
        }

        // update booking
        public async Task<BookingResponseDTO> UpdateBooking( Guid Id,BookingRequestDTO booking)
        {
            var data = await _bookingRepository.GetBookingById(Id);
            if (data == null)
            {
                return null;
            }
            data.date = booking.date;
            data.start_time = booking.start_time;
            data.end_time = booking.end_time;
            data.status = booking.status;
            data.amount = booking.amount;
            data.Id = booking.UserId;

            var result = await _bookingRepository.UpdateBooking(data);
            if (result == null)
            {
                return null;
            }
            return new BookingResponseDTO
            {
                BookingId = result.Id,
                date = result.date,
                start_time = result.start_time,
                end_time = result.end_time,
                status = result.status,
                amount = result.amount,
                UserId = result.Id
            };

        }

        // delete booking
        public async Task<bool> DeleteBooking(Guid Id)
        {
            var data = await _bookingRepository.GetBookingById(Id);
            if (data == null)
            {
                return false;
            }
            var result = await _bookingRepository.DeleteBooking(Id);
            return result;
        }
    }
}
