namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }

        public int booking_id { get; set; }
        public decimal amount { get; set; }
        public DateOnly payment_date { get; set; }
        public string payment_method { get; set; }

        public string transaction_reference { get; set; }

        public string status { get; set; }
        //ioniun
    }
}
