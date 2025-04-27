namespace EventBookingManagementSystem_Backend.DTOs.ResponseModels
{
    public class UpdateBookingPackageItemDto
    {
        public Guid Id { get; set; }
        public Guid BookingPackageId { get; set; }
        public Guid ItemId { get; set; }
    }
}
