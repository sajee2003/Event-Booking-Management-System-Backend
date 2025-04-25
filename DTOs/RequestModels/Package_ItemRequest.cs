using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.DTOs.RequestModels
{
    public class Package_ItemRequest
    {
     
        public Guid PackageId { get; set; }
        public Guid ItemId { get; set; }
        public Guid AssetId { get; set; }
       
    }
}
