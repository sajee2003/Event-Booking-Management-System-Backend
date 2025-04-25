using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.DTOs.ResponseModels
{
    public class Booking_PackageResponse
    {
        public Guid BookingPackageId { get; set; }
        public Guid BookingId { get; set; }
        public Guid PackageId { get; set; }

    }
}
