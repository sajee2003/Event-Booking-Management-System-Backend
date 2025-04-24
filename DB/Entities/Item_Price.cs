namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Item_Price
    {
        public Guid ItemPriceID { get; set; }
        public int ItemId { get; set; }
        public Item item { get; set; }

        public decimal base_price { get; set; }
        public string currency { get; set; }

        public int asset_id { get; set; }
        public Asset asset { get; set; }

        public string price_type { get; set; }



    }
}
