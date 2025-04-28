namespace EventBookingManagementSystem_Backend.DTOs.ResponseModels
{
    public class Item_PriceResponse
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public decimal BasePrice { get; set; }
        public string Currency { get; set; }
        public Guid AssetId { get; set; }
        public decimal Price { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
