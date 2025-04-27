using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.DTOs.Common.Modal
{
    public class CreateBookingAssetDto
    {
       

        public Guid BookingId { get; set; }

        public Guid AssetId { get; set; }

        public TimeOnly start_time { get; set; }
        public TimeOnly end_time { get; set; }

    }
}
