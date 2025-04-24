namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Booking_Package_Item
    {
        public Guid Id { get; set; }
        public int booking_package_id { get; set; }
        public Booking_Package booking_package { get; set; }

        public int item_id { get; set; }
        
        public Item item { get; set; }
    }
}
