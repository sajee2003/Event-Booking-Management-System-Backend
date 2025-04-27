using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.DTOs.CommonModules
{
    public class Asset_ItemRequestDto
    {
        public Guid AssetId { get; set; }
        public Guid ItemId { get; set; }
    }
}
