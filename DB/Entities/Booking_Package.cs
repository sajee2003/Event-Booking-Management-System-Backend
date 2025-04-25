namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Booking_Package
    {
        public Guid BookingPackageId { get; set; }
        public Guid BookingId { get; set; }
        public Booking Booking { get; set; }

        public Guid PackageId { get; set; }

        public Package Package { get; set; }
    }
}
