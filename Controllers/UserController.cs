using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingManagementSystem_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllUsersAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var user = await _service.GetUserByIdAsync(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserRequest dto)
        {
            var created = await _service.CreateUserAsync(dto);
            return CreatedAtAction(nameof(Get), new { id = created.UserId }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UserRequest dto)
        {

            var updated = await _service.UpdateUserAsync(id, dto);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)

        {
            var result = await _service.DeleteUserAsync(id);
            return result ? NoContent() : NotFound();
        }
    }
}
