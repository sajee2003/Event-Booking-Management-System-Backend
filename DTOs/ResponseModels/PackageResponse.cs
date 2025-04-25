namespace EventBookingManagementSystem_Backend.DTOs.ResponseModels
{
    public class PackageResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
    }
}
