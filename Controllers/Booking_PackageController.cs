using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingManagementSystem_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Booking_PackageController : ControllerBase
    {
        private readonly IBooking_PackageService _booking_PackageService;

        public Booking_PackageController(IBooking_PackageService booking_PackageService)
        {
            _booking_PackageService = booking_PackageService;
        }

        // get all booking_packages
        [HttpGet("get-all-booking-packages")]
        public async Task<IActionResult> GetAllBooking_Packages()
        {
            try
            {
                var bookingPackages = await _booking_PackageService.GetAllBooking_Packages();
                return bookingPackages == null ? NotFound(): Ok(bookingPackages);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // get booking_package by id
        [HttpGet("get-booking-package-by-id/{id}")]
        public async Task<IActionResult> GetBooking_PackageById(int id)
        {
            try
            {
                var bookingPackage = await _booking_PackageService.GetBooking_PackageById(id);
                return bookingPackage == null ? NotFound() : Ok(bookingPackage);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // get booking_packages by booking id
        [HttpGet("get-booking-packages-by-booking-id/{bookingId}")]
        public async Task<IActionResult> GetBooking_PackagesByBookingId(Guid bookingId)
        {
            try
            {
                var bookingPackages = await _booking_PackageService.GetBooking_PackagesByBookingId(bookingId);
                return bookingPackages == null ? NotFound() : Ok(bookingPackages);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // get booking_packages by package id
        [HttpGet("get-booking-packages-by-package-id/{packageId}")]
        public async Task<IActionResult> GetBooking_PackagesByPackageId(Guid packageId)
        {
            try
            {
                var bookingPackages = await _booking_PackageService.GetBooking_PackagesByPackageId(packageId);
                return bookingPackages == null ? NotFound() : Ok(bookingPackages);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // add booking_package
        [HttpPost("add-booking-package")]
        public async Task<IActionResult> AddBooking_Package( Booking_PackageRequest booking_packageRequest)
        {
            try
            {
                var bookingPackage = await _booking_PackageService.AddBooking_Package(booking_packageRequest);
                return bookingPackage == null ? NotFound() : Ok(bookingPackage);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // update booking_package
        [HttpPut("update-booking-package/{id}")]
        public async Task<IActionResult> UpdateBooking_Package(int id, Booking_PackageRequest booking_packageRequest)
        {
            try
            {
                var bookingPackage = await _booking_PackageService.UpdateBooking_Package(id, booking_packageRequest);
                return bookingPackage == null ? NotFound() : Ok(bookingPackage);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // delete booking_package
        [HttpDelete("delete-booking-package/{id}")]
        public async Task<IActionResult> DeleteBooking_Package(int id)
        {
            try
            {
                var result = await _booking_PackageService.DeleteBooking_Package(id);
                return result ? Ok() : NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
