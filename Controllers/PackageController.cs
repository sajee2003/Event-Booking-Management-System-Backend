using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingManagementSystem_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PackageController : ControllerBase
    {
        private readonly IPackageService _service;

        public PackageController(IPackageService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var packages = await _service.GetAllAsync();
            return Ok(packages);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var package = await _service.GetByIdAsync(id);
            if (package == null) return NotFound();
            return Ok(package);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PackageRequest dto)
        {
            var created = await _service.AddAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] PackageRequest dto)
        {
            var updated = await _service.UpdateAsync(id, dto);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted) return NotFound();
            return Ok("deleted successfully!");
        }
    }
}
