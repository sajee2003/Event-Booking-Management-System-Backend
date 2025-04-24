namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Asset_Item
    {
        public Guid AssetItemId { get; set; }
        public int AssetId { get; set; }
        public Asset asset { get; set; }

        public int ItemId { get; set; }
        public Item item { get; set; }

    }
}
