using AutoMapper;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.Common.Modal;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.DTOs.ResponseModels;

namespace EventBookingManagementSystem_Backend.AutoMapper
{
    public class BookingAssetProfile :Profile
    {
        public BookingAssetProfile()
        {

            //
            CreateMap<Booking_Asset, BookingAssetDto>().ReverseMap();
            CreateMap<CreateBookingAssetDto, Booking_Asset>();
            CreateMap<UpdateBookingAssetDto, Booking_Asset>();

            CreateMap<Booking_Package_Item, BookingPackageItemDto>().ReverseMap();
            CreateMap<CreateBookingPackageItemDto, Booking_Package_Item>();
                //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
            CreateMap<UpdateBookingPackageItemDto, Booking_Package_Item>();

        }
    }
}
