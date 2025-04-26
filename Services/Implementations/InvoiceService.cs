using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Interfaces;

namespace EventBookingManagementSystem_Backend.Services.Implementations
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _repository;

        public InvoiceService(IInvoiceRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<InvoiceResponse>> GetAllAsync()
        {
            var list = await _repository.GetAllAsync();
            return list.Select(i => new InvoiceResponse
            {
                Id = i.Id,
                BookingId = i.BookingId,
                Invoice_No = i.Invoice_No,
                date = i.date,
                due_date = i.due_date,
                total_amount = i.total_amount,
                Status = i.Status
            });
        }

        public async Task<InvoiceResponse> GetByIdAsync(Guid id)
        {
            var invoice = await _repository.GetByIdAsync(id);
            if (invoice == null) return null;

            return new InvoiceResponse
            {
                Id = invoice.Id,
                BookingId = invoice.BookingId,
                Invoice_No = invoice.Invoice_No,
                date = invoice.date,
                due_date = invoice.due_date,
                total_amount = invoice.total_amount,
                Status = invoice.Status
            };
        }

        public async Task<InvoiceResponse> AddAsync(InvoiceRequest dto)
        {
            var invoice = new Invoice
            {
                BookingId = dto.BookingId,
                Invoice_No = dto.Invoice_No,
                date = dto.date,
                due_date = dto.due_date,
                total_amount = dto.total_amount,
                Status = dto.Status
            };

            var created = await _repository.AddAsync(invoice);

            return new InvoiceResponse
            {
                Id = created.Id,
                BookingId = created.BookingId,
                Invoice_No = created.Invoice_No,
                date = created.date,
                due_date = created.due_date,
                total_amount = created.total_amount,
                Status = created.Status
            };
        }

        public async Task<InvoiceResponse> UpdateAsync(Guid id, InvoiceRequest dto)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null) return null;

            existing.BookingId = dto.BookingId;
            existing.Invoice_No = dto.Invoice_No;
            existing.date = dto.date;
            existing.due_date = dto.due_date;
            existing.total_amount = dto.total_amount;
            existing.Status = dto.Status;

            var updated = await _repository.UpdateAsync(existing);

            return new InvoiceResponse
            {
                Id = updated.Id,
                BookingId = updated.BookingId,
                Invoice_No = updated.Invoice_No,
                date = updated.date,
                due_date = updated.due_date,
                total_amount = updated.total_amount,
                Status = updated.Status
            };
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
