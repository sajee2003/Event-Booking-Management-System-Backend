using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.CommonModules;
using EventBookingManagementSystem_Backend.Services.Implementations;
using EventBookingManagementSystem_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingManagementSystem_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Asset_ItemController : ControllerBase
    {
        private readonly IAsset_ItemService _service;

        public Asset_ItemController(IAsset_ItemService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var assetItems = await _service.GetAllAsync();
            return Ok(assetItems);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var assetItem = await _service.GetByIdAsync(id);
            if (assetItem == null)
                return NotFound();

            return Ok(assetItem);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Asset_ItemRequestDto request)
        {
            var created = await _service.CreateAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] Asset_ItemRequestDto request)
        {
            var updated = await _service.UpdateAsync(id, request);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
