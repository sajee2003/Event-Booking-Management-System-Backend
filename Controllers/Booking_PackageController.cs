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
    }
}
