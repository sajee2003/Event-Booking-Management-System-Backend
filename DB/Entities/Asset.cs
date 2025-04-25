using EventBookingManagementSystem_Backend.Assests.Enums;

namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public AssetStatus AssetStatus { get; set; }


        public ICollection<Asset_Item> Asset_Items { get; set; }

        public ICollection<Package_Item> Package_Items { get; set; }
        public ICollection<Item_Price> Item_Prices { get; set; }

        public ICollection<Booking_Asset> Booking_Assets { get; set; }


    }
}
