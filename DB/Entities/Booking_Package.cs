namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Booking_Package
    {
        public Guid Id { get; set; }
        public Guid BookingId { get; set; }
        public Booking Booking { get; set; }

        public Guid PackageId { get; set; }
        //jlbg
        public Package Package { get; set; }
    }
}