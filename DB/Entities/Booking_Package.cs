namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Booking_Package
    {
        public Guid Id { get; set; }
        public int booking_id { get; set; }
        public Booking Booking { get; set; }

        public int package_id { get; set; }

        public Package package { get; set; }
    }
}
