namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Booking_Asset
    {
        public Guid Id { get; set; }

        public int BookingId { get; set; }
        public Booking booking { get; set; }
        public int AssetId { get; set; }

        public Asset asset { get; set; }

        public TimeOnly start_time { get; set; }
        public TimeOnly end_time { get; set; }
        


    }
}
