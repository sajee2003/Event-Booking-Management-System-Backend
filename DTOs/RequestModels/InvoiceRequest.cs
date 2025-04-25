using EventBookingManagementSystem_Backend.Assests.Enums;

namespace EventBookingManagementSystem_Backend.DTOs.RequestModels
{
    public class InvoiceRequest
    {
        public Guid BookingId { get; set; }

        public int Invoice_No { get; set; }
        public DateOnly date { get; set; }
        public DateOnly due_date { get; set; }
        public decimal total_amount { get; set; }

        public InvoiceStatus Status { get; set; }
    }
}
