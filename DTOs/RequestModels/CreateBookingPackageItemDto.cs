namespace EventBookingManagementSystem_Backend.DTOs.RequestModels
{
    public class CreateBookingPackageItemDto
    {
        public Guid BookingPackageId { get; set; }
        public Guid ItemId { get; set; }
    }
}
