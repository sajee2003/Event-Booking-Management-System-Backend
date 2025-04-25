namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Booking
    {

        public Guid Id { get; set; }
        public Guid userId { get; set; }
        public User user { get; set; }
        public DateOnly date { get; set; }
        
        public TimeOnly start_time { get; set; }
        public TimeOnly end_time { get; set; }

        public string status { get; set; }
        public decimal amount { get; set; }


        public ICollection<Invoice> Invoices { get; set; }



    }
}
