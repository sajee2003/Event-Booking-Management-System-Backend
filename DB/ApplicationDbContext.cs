using Microsoft.EntityFrameworkCore;
using System;

namespace EventBookingManagementSystem_Backend.DB
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
