using System.ComponentModel.DataAnnotations;

namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Asset_Item
    {

        
        public Guid Id { get; set; }
        public Guid AssetId { get; set; }
        public Asset Asset { get; set; }

        public Guid ItemId { get; set; }
        public Item Item { get; set; }

    }
}
