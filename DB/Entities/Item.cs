namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }


        public Guid ItemCategoryId { get; set; }
        public Item_Category ItemCategory { get; set; }



        public ICollection<Asset_Item> Asset_Items { get; set; }

        public ICollection<Item_Price> Item_Prices { get; set; }


        public ICollection<Package_Item> Package_Items { get; set; }

        public ICollection<Booking_Package_Item> Booking_Package_Items { get; set; }
    }
}
