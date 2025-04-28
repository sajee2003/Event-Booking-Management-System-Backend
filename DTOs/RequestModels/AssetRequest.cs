using EventBookingManagementSystem_Backend.Assests.Enums;

namespace EventBookingManagementSystem_Backend.DTOs.RequestModels
{
    public class AssetRequest
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public AssetStatus AssetStatus { get; set; }
    }
}
