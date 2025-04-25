namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Item_Price
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public Item Item { get; set; }

        public decimal base_price { get; set; }
        public string currency { get; set; }

        public Guid assetId { get; set; }
        public Asset asset { get; set; }

        public string price_type { get; set; }



    }
}
