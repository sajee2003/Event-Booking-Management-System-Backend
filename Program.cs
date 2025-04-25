
using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.Repositories.Implementations;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using EventBookingManagementSystem_Backend.Services.Implementations;
using EventBookingManagementSystem_Backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text.Json.Serialization;

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
            //add-scoped-repositories
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IPackage_ItemRepository, Package_ItemRepository>();
            builder.Services.AddScoped<IBookingRepository, BookingRepository>();
            builder.Services.AddScoped<IBooking_PackageRepository, Booking_PackageRepository>();

            //add-scoped-services               
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IPackage_ItemService, Package_ItemService>();
            builder.Services.AddScoped<IBookingService, BookingService>();
            builder.Services.AddScoped<IBooking_PackageService, Booking_PackageService>();
            builder.Services.AddScoped<IPackageRepository, PackageRepository>();
            builder.Services.AddScoped<IPackageService, PackageService>();

            builder.Services.AddScoped<IItemRepository, ItemRepository>();
            builder.Services.AddScoped<IItemService, ItemService>();

            builder.Services.AddScoped<IItemCategoryRepository, ItemCategoryRepository>();
            builder.Services.AddScoped<IItemCategoryService, ItemCategoryService>();


            builder.Services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            builder.Services.AddScoped<IInvoiceService, InvoiceService>();
          
            builder.Services.AddControllers()
.AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
});




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
