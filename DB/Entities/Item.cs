namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        
        public int item_category_id { get; set; }
        public Item_Category item_Category { get; set; }
    }
}
