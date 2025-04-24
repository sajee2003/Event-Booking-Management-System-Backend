using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingManagementSystem_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        // get all bookings
        [HttpGet("get-all-booking")]
        public async Task<IActionResult> GetBookings()
        {
            try
            {
                var data = await _bookingService.GetBookings();
                return data == null ? NotFound() : Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // get booking by id
        [HttpGet("get-booking-by-id/{Id}")]
        public async Task<IActionResult> GetBookingById(Guid Id)
        {
            try
            {
                var data = await _bookingService.GetBookingById(Id);
                return data == null ? NotFound() : Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // get booking by user id
        [HttpGet("get-booking-by-user-id/{userId}")]
        public async Task<IActionResult> GetBookingsByUserId(Guid userId)
        {
            try
            {
                var data = await _bookingService.GetBookingsByUserId(userId);
                return data == null ? NotFound() : Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // add booking
        [HttpPost("add-booking")]
        public async Task<IActionResult> AddBooking( BookingRequestDTO booking)
        {
            try
            {
                var data = await _bookingService.AddBooking(booking);
                return data == null ? NotFound() : Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // update booking
        [HttpPut("update-booking")]
        public async Task<IActionResult> UpdateBooking(Guid Id,BookingRequestDTO booking)
        {
            try
            {
                var data = await _bookingService.UpdateBooking(Id,booking);
                return data == null ? NotFound() : Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // delete booking
        [HttpDelete("delete-booking/{Id}")]
        public async Task<IActionResult> DeleteBooking(Guid Id)
        {
            try
            {
                var data = await _bookingService.DeleteBooking(Id);
                return data == false ? NotFound() : Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
