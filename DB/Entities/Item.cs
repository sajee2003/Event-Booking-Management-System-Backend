namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }

        public Guid ItemCategoryId { get; set; }
        public Item_Category ItemCategory { get; set; }
    }
}
