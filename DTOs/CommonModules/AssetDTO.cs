using EventBookingManagementSystem_Backend.Assests.Enums;
using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.DTOs.CommonModules
{
    public class AssetDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
      

        public int capacity { get; set; }

        public AssetStatus status { get; set; }
    }
}
