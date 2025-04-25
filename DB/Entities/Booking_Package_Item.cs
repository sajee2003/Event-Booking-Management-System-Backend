namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Booking_Package_Item
    {
        public Guid Id { get; set; }
        public int BookingPackageId { get; set; }
        public Booking_Package booking_package { get; set; }

        public int ItemId { get; set; }
        
        public Item item { get; set; }
    }
}
