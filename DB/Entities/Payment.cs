namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }

        public Guid BookingId { get; set; }
         public Booking Booking { get; set; }
        public decimal amount { get; set; }
        public DateOnly payment_date { get; set; }
        public string payment_method { get; set; }

        public string transaction_reference { get; set; }

        public string status { get; set; }
        
    }
}
