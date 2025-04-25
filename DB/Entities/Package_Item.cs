namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Package_Item
    {
        public Guid PackageItemId { get; set; }
        
        public int PackageId { get; set; }
        public Package package { get; set; }

        public int ItemId { get; set; }
        public Item item { get; set; }

        public int AssetId { get; set; }
        public Asset asset { get; set; }
            
    }
}
