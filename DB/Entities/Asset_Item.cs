namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Asset_Item
    {
        public Guid Id { get; set; }
        public int asset_id { get; set; }
        public Asset asset { get; set; }

        public int item_id { get; set; }
        public Item item { get; set; }

    }
}
