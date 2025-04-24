using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.DTOs.RequestModels
{
    public class BookingRequestDTO
    {
        public DateOnly date { get; set; }
        public TimeOnly start_time { get; set; }
        public TimeOnly end_time { get; set; }

        public string status { get; set; }
        public decimal amount { get; set; }

        public Guid UserId { get; set; }
        
    }
}
