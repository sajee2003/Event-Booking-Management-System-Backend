using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.DTOs.Common.Modal
{
    public class UpdateBookingAssetDto
    {
        public Guid Id { get; set; }
        public Guid BookingId { get; set; }
        public Guid AssetId { get; set; }
        public TimeOnly start_time { get; set; }
        public TimeOnly end_time { get; set; }

    }
}
