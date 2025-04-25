namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Package_Item
    {


        

        public Guid Id { get; set; }


        public Guid PackageId { get; set; }
        public Package package { get; set; }

        public Guid ItemId { get; set; }

        public Item item { get; set; }

        public Guid AssetId { get; set; }
        public Asset asset { get; set; }

    }
}
