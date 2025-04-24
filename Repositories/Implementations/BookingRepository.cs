using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public BookingRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
    }
}
