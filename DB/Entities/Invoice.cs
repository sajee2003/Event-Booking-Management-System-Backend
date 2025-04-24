namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public int booking_id { get; set; }

        public int Invoice_No { get; set; }
        public DateOnly date { get; set; }
        public DateOnly due_date { get; set; }
        public decimal total_amount { get; set; }


    }
}
