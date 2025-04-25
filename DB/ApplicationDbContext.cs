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


        public DbSet<Package> Packages { get; set; }

        public DbSet<Item_Category> Item_Categories { get; set; }
        public DbSet<Item> Items { get; set; }

        public DbSet<Booking_Package_Item> Booking_Package_Item { get; set; }


    }
}