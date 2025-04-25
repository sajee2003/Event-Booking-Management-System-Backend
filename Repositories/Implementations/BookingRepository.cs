using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public BookingRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        //get all bookings
        public async Task<List<Booking>> GetBookings()
        {
            return await applicationDbContext.Bookings.ToListAsync();
        }

        // get booking by id 
        public async Task<Booking> GetBookingById(Guid Id)
        {
            return await applicationDbContext.Bookings.FindAsync(Id);
        }

        //get booking by user id
        public async Task<List<Booking>> GetBookingsByUserId(Guid userId)
        {
            return await applicationDbContext.Bookings.Where(x => x.Id == userId).ToListAsync();
        }

        // add booking
        public async Task<Booking> AddBooking(Booking booking)
        {
            await applicationDbContext.Bookings.AddAsync(booking);
            await applicationDbContext.SaveChangesAsync();
            return booking;
        }

        // update booking
        public async Task<Booking> UpdateBooking(Booking booking)
        {
            applicationDbContext.Bookings.Update(booking);
            await applicationDbContext.SaveChangesAsync();
            return booking;
        }

        // delete booking
        public async Task<bool> DeleteBooking(Guid Id)
        {
            var booking = await applicationDbContext.Bookings.FindAsync(Id);
            if (booking == null)
            {
                return false;
            }
            applicationDbContext.Bookings.Remove(booking);
            await applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
