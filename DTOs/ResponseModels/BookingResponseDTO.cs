using EventBookingManagementSystem_Backend.DB.Entities;

namespace EventBookingManagementSystem_Backend.DTOs.ResponseModels
{
    public class BookingResponseDTO
    {
        public Guid BookingId { get; set; }
        public DateOnly date { get; set; }

        public TimeOnly start_time { get; set; }
        public TimeOnly end_time { get; set; }

        public string status { get; set; }
        public decimal amount { get; set; }

        public Guid UserId { get; set; }
        
    }
}
