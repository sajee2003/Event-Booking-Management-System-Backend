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
    }
}
