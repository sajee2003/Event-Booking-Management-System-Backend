using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;

namespace EventBookingManagementSystem_Backend.Services.Interfaces
{
    public interface IPaymentService
    {

        Task<IEnumerable<PaymentResponse>> GetAllPaymentsAsync();
        Task<PaymentResponse> GetPaymentByIdAsync(Guid id);
        Task<PaymentResponse> AddPaymentAsync(PaymentRequest paymentRequest);
        Task UpdatePaymentAsync(Guid id, PaymentRequest paymentRequest);
        Task DeletePaymentAsync(Guid id);
    }
}
