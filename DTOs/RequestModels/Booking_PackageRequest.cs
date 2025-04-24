using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.DTOs.RequestModels
{
    public class Booking_PackageRequest
    {
        public Guid BookingId { get; set; }
       
        public Guid PackageId { get; set; }

    }
}
