namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Booking_Package_Item
    {
        public Guid Id { get; set; }
        public Guid BookingPackageId { get; set; }
        public Booking_Package BookingPackage { get; set; }

        public Guid ItemId { get; set; }

        public Item Item { get; set; }
    }
}