namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        
        public int ItemCategoryId { get; set; }
        public Item_Category item_Category { get; set; }
    }
}
