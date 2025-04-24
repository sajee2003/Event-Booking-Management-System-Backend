namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public DateOnly date { get; set; }
        
        public TimeOnly start_time { get; set; }
        public TimeOnly end_time { get; set; }

        public string status { get; set; }
        public decimal amount { get; set; }

        //Navigation Properties
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
