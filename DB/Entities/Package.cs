namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Package
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
    }
}
