namespace EventBookingManagementSystem_Backend.DTOs.Common.Modal
{
    public class BookingPackageItemDto
    {
        public Guid Id { get; set; }
        public Guid BookingPackageId { get; set; }
        public Guid ItemId { get; set; }
    }
}
