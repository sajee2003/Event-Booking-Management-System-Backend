using EventBookingManagementSystem_Backend.DB.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EventBookingManagementSystem_Backend.DB
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Package_Item> Package_Items { get; set; }
        public DbSet<Booking_Package> Booking_Packages { get; set; }
    }
}