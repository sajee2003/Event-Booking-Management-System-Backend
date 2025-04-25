using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.DTOs.ResponseModels
{
    public class Package_ItemResponse
    {
        public Guid Id { get; set; }
        public Guid PackageId { get; set; }
        public Guid ItemId { get; set; }
        public Guid AssetId { get; set; }
       
    }
}
