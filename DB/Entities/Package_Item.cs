namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Package_Item
    {
        public Guid Id { get; set; }
        
        public int package_id { get; set; }
        public Package package { get; set; }

        public int item_id { get; set; }
        public Item item { get; set; }

        public int asset_id { get; set; }
        public Asset asset { get; set; }
            
    }
}
