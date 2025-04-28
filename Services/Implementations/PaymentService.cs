using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Interfaces;

namespace EventBookingManagementSystem_Backend.Services.Implementations
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<IEnumerable<PaymentResponse>> GetAllPaymentsAsync()
        {
            var payments = await _paymentRepository.GetAllPaymentsAsync();
            return payments.Select(p => MapToResponseDto(p));
        }

        public async Task<PaymentResponse> GetPaymentByIdAsync(Guid id)
        {
            var payment = await _paymentRepository.GetPaymentByIdAsync(id);
            if (payment == null)
                return null;

            return MapToResponseDto(payment);
        }

        public async Task<PaymentResponse> AddPaymentAsync(PaymentRequest paymentRequest)
        {
            var payment = new Payment
            {
                Id = Guid.NewGuid(),
                BookingId = paymentRequest.BookingId,
                amount = paymentRequest.Amount,
                payment_date = paymentRequest.PaymentDate,
                payment_method = paymentRequest.PaymentMethod,
                transaction_reference = paymentRequest.TransactionReference,
                status = paymentRequest.Status
            };

            await _paymentRepository.AddPaymentAsync(payment);

            return MapToResponseDto(payment);
        }

        public async Task UpdatePaymentAsync(Guid id, PaymentRequest paymentRequest)
        {
            var existingPayment = await _paymentRepository.GetPaymentByIdAsync(id);
            if (existingPayment == null)
                throw new Exception("Payment not found");

            existingPayment.BookingId = paymentRequest.BookingId;
            existingPayment.amount = paymentRequest.Amount;
            existingPayment.payment_date = paymentRequest.PaymentDate;
            existingPayment.payment_method = paymentRequest.PaymentMethod;
            existingPayment.transaction_reference = paymentRequest.TransactionReference;
            existingPayment.status = paymentRequest.Status;

            await _paymentRepository.UpdatePaymentAsync(existingPayment);
        }

        public async Task DeletePaymentAsync(Guid id)
        {
            await _paymentRepository.DeletePaymentAsync(id);
        }

        private PaymentResponse MapToResponseDto(Payment payment)
        {
            return new PaymentResponse
            {
                Id = payment.Id,
                BookingId = payment.BookingId,
                Amount = payment.amount,
                PaymentDate = payment.payment_date,
                PaymentMethod = payment.payment_method,
                TransactionReference = payment.transaction_reference,
                Status = payment.status
            };
        }

      
    }
}
