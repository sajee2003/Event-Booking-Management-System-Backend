namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Booking_Package
    {
        public Guid Id { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }

        public int PackageId { get; set; }

        public Package package { get; set; }
    }
}
