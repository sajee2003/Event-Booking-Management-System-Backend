namespace EventBookingManagementSystem_Backend.DTOs.RequestModels
{
    public class PaymentRequest
    {

        public Guid BookingId { get; set; }
        public decimal Amount { get; set; }
        public DateOnly PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionReference { get; set; }
        public string Status { get; set; }
    }
}
