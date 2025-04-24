
using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.Repositories.Implementations;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Implementations;
using EventBookingManagementSystem_Backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace EventBookingManagementSystem_Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IPackage_ItemRepository, Package_ItemRepository>();
            builder.Services.AddScoped<IBookingRepository, BookingRepository>();
            builder.Services.AddScoped<IBooking_PackageRepository,Booking_PackageRepository>();

            builder.Services.AddScoped<IPackage_ItemService, Package_ItemService>();
            builder.Services.AddScoped<IBookingService, BookingService>();
            builder.Services.AddScoped<IBooking_PackageService, Booking_PackageService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
