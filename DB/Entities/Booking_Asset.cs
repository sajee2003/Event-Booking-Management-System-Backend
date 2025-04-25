namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Booking_Asset
    {
        public Guid Id { get; set; }

        public Guid BookingId { get; set; }
        public Booking Booking { get; set; }
        public Guid AssetId { get; set; }

        public Asset Asset { get; set; }

        public TimeOnly start_time { get; set; }
        public TimeOnly end_time { get; set; }



    }
}
