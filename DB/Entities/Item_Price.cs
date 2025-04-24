namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Item_Price
    {
        public Guid ID { get; set; }
        public int item_id { get; set; }
        public Item item { get; set; }

        public decimal base_price { get; set; }
        public string currency { get; set; }

        public int asset_id { get; set; }

        public string price_type { get; set; }



    }
}
