using System;
using AutoMapper;
using HotelDotNet.Data;
using HotelDotNet.Models;

namespace HotelDotNet.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Hotel, HotelVM>().ReverseMap();
            CreateMap<Hotel, HotelListVM>().ReverseMap();
            CreateMap<Hotel, HotelRoomsVM>().ReverseMap();
            CreateMap<RoomType, RoomTypeVM>().ReverseMap();
            CreateMap<Room, RoomVM>().ReverseMap();
            CreateMap<RoomAllocation, RoomAllocationVM>().ReverseMap();
            CreateMap<RoomAllocation, RoomAllocationCreateVM>().ReverseMap();
            CreateMap<User, UserListVM>().ReverseMap();
        }
            
    }
}

