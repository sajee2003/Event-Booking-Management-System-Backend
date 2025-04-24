using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{
    public class Booking_PackageRepository : IBooking_PackageRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public Booking_PackageRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        // get all booking_packages
        public async Task<List<Booking_Package>> GetAllBooking_Packages()
        {
            return await applicationDbContext.Booking_Packages.ToListAsync();
        }

        // get booking_package by id
        public async Task<Booking_Package> GetBooking_PackageById(int id)
        {
            return await applicationDbContext.Booking_Packages.FindAsync(id);
        }


        // get booking_package by booking id
        public async Task<List<Booking_Package>> GetBooking_PackagesByBookingId(Guid bookingId)
        {
            return await applicationDbContext.Booking_Packages
                .Where(b => b.BookingId == bookingId)
                .ToListAsync();
        }

        // get booking_package by package id
        public async Task<List<Booking_Package>> GetBooking_PackagesByPackageId(Guid packageId)
        {
            return await applicationDbContext.Booking_Packages
                .Where(b => b.PackageId == packageId)
                .ToListAsync();
        }


        // add booking_package
        public async Task<Booking_Package> AddBooking_Package(Booking_Package booking_package)
        {
            await applicationDbContext.Booking_Packages.AddAsync(booking_package);
            await applicationDbContext.SaveChangesAsync();
            return booking_package;
        }

        // update booking_package
        public async Task<Booking_Package> UpdateBooking_Package(Booking_Package booking_package)
        {
            applicationDbContext.Booking_Packages.Update(booking_package);
            await applicationDbContext.SaveChangesAsync();
            return booking_package;
        }

        // delete booking_package
        public async Task<bool> DeleteBooking_Package(int id)
        {
            var booking_package = await applicationDbContext.Booking_Packages.FindAsync(id);
            if (booking_package == null)
            {
                return false;
            }
            applicationDbContext.Booking_Packages.Remove(booking_package);
            await applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
