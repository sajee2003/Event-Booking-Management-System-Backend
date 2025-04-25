using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Interfaces;

namespace EventBookingManagementSystem_Backend.Services.Implementations
{
    public class Booking_PackageService : IBooking_PackageService
    {
        private readonly IBooking_PackageRepository booking_PackageRepository;

        public Booking_PackageService(IBooking_PackageRepository booking_PackageRepository)
        {
            this.booking_PackageRepository = booking_PackageRepository;
        }

        // get all booking_packages
        public async Task<List<Booking_PackageResponse>> GetAllBooking_Packages()
        {
            var data = await booking_PackageRepository.GetAllBooking_Packages();
            return data.Select(b => new Booking_PackageResponse
            {

                BookingId = b.BookingId,
                PackageId = b.PackageId,

            }).ToList();

        }

        // get booking_package by id
        public async Task<Booking_PackageResponse> GetBooking_PackageById(int id)
        {
            var data = await booking_PackageRepository.GetBooking_PackageById(id);
            if (data == null)
            {
                return null;
            }
            return new Booking_PackageResponse
            {
                BookingId = data.BookingId,
                PackageId = data.PackageId,

            };
        }

        // get booking_package by booking id
        public async Task<List<Booking_PackageResponse>> GetBooking_PackagesByBookingId(Guid bookingId)
        {
            var data = await booking_PackageRepository.GetBooking_PackagesByBookingId(bookingId);
            return data.Select(b => new Booking_PackageResponse
            {
                BookingId = b.BookingId,
                PackageId = b.PackageId,
            }).ToList();
        }

        // get booking_package by package id
        public async Task<List<Booking_PackageResponse>> GetBooking_PackagesByPackageId(Guid packageId)
        {
            var data = await booking_PackageRepository.GetBooking_PackagesByPackageId(packageId);
            return data.Select(b => new Booking_PackageResponse
            {
                BookingId = b.BookingId,
                PackageId = b.PackageId,
            }).ToList();
        }

        // add booking_package
        public async Task<Booking_PackageResponse> AddBooking_Package(Booking_PackageRequest booking_PackageRequest)
        {
            var booking_package = new Booking_Package
            {
                BookingId = booking_PackageRequest.BookingId,
                PackageId = booking_PackageRequest.PackageId,
            };
            var data = await booking_PackageRepository.AddBooking_Package(booking_package);
            return new Booking_PackageResponse
            {
                BookingId = data.BookingId,
                PackageId = data.PackageId,
            };
        }

        // update booking_package
        public async Task<Booking_PackageResponse> UpdateBooking_Package(int id, Booking_PackageRequest booking_PackageRequest)
        {
            var booking_package = await booking_PackageRepository.GetBooking_PackageById(id);
            if (booking_package == null)
            {
                return null;
            }
            booking_package.BookingId = booking_PackageRequest.BookingId;
            booking_package.PackageId = booking_PackageRequest.PackageId;
            var data = await booking_PackageRepository.UpdateBooking_Package(booking_package);
            return new Booking_PackageResponse
            {
                BookingId = data.BookingId,
                PackageId = data.PackageId,
            };
        }

        // delete booking_package
        public async Task<bool> DeleteBooking_Package(int id)
        {
            var booking_package = await booking_PackageRepository.GetBooking_PackageById(id);
            if (booking_package == null)
            {
                return false;
            }
            return await booking_PackageRepository.DeleteBooking_Package(id);
        }
    }
}
