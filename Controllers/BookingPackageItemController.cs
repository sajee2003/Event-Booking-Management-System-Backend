using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;
using EventBookingManagementSystem_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingManagementSystem_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingPackageItemController : ControllerBase
    {
        private readonly IBookingPackageItemService _service;

        public BookingPackageItemController(IBookingPackageItemService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id) =>
            Ok(await _service.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Create(CreateBookingPackageItemDto dto)
        {
            await _service.CreateAsync(dto);
            return Ok(new { message = "Created successfully" });
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBookingPackageItemDto dto)
        {
            await _service.UpdateAsync(dto);
            return Ok(new { message = "Updated successfully" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteAsync(id);
            return Ok(new { message = "Deleted successfully" });
        }
    }
}
