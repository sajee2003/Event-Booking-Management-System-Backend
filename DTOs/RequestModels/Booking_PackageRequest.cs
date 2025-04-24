using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.DTOs.RequestModels
{
    public class Booking_PackageRequest
    {
        public int BookingId { get; set; }
       
        public int PackageId { get; set; }

    }
}
