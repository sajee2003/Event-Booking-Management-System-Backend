using EventBookingManagementSystem_Backend.DTOs.Common.Modal;
using EventBookingManagementSystem_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingManagementSystem_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingAssetController : ControllerBase
    {
        private readonly IBookingAssetService _service;

        public BookingAssetController(IBookingAssetService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
    Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _service.GetByIdAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpGet("booking/{bookingId}")]
        public async Task<IActionResult> GetByBookingId(Guid bookingId) =>
            Ok(await _service.GetByBookingIdAsync(bookingId));

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBookingAssetDto dto)
        {
            var result = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateBookingAssetDto dto)
        {
            if (id != dto.Id) return BadRequest();
            var success = await _service.UpdateAsync(dto);
            return success ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var success = await _service.DeleteAsync(id);
            return success ? NoContent() : NotFound();
        }

    }
}
