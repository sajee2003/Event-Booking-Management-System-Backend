using AutoMapper;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.Common.Modal;

namespace EventBookingManagementSystem_Backend.AutoMapper
{
    public class BookingAssetProfile :Profile
    {
        public BookingAssetProfile()
        {
            CreateMap<Booking_Asset, BookingAssetDto>().ReverseMap();

            CreateMap<CreateBookingAssetDto, Booking_Asset>();
            
            CreateMap<UpdateBookingAssetDto, Booking_Asset>();
            
        }
    }
}
