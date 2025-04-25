using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;

namespace EventBookingManagementSystem_Backend.Services.Interfaces
{
    public interface IInvoiceService
    {
        Task<IEnumerable<InvoiceResponse>> GetAllAsync();
        Task<InvoiceResponse> GetByIdAsync(Guid id);
        Task<InvoiceResponse> AddAsync(InvoiceRequest dto);
        Task<InvoiceResponse> UpdateAsync(Guid id, InvoiceRequest dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
