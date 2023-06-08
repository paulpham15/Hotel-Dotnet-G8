using System;
using AutoMapper;
using AutoMapper.Execution;
using HotelDotNet.Contracts;
using HotelDotNet.Data;
using HotelDotNet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
namespace HotelDotNet.Respositories
{
    public class HotelResposiory : GenericRepository<Hotel>, IHotelRespository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public HotelResposiory(ApplicationDbContext context,IMapper mapper) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<HotelRoomsVM> GetHotelDetails(int? id)
        {
            var roomAllocation = await context.RoomAllocations.Include(q => q.RoomType).Where(q => q.HotelId == id).ToListAsync();
            var roomAllocationVM =new List<RoomAllocationVM>();

            foreach (var room in roomAllocation)
            {
                var RoomFacials = context.RoomFacilities.Where(q => q.RoomAllocationId == room.Id).Select(x => x.FacilitiesId);
                var Facilities = await context.Facilities.Where(q => RoomFacials.Contains(q.Id)).ToListAsync();
                roomAllocationVM.Add(new RoomAllocationVM
                {
                    RoomName = room.RoomName,
                    Price = room.Price ?? 0,
                    NumberOfRoom = room.NumberOfRoom ?? 0,
                    Picture = room.Picture,
                    Id = room.Id,
                    RoomFacilityList = Facilities,
                    RoomTypeString = room.RoomTypeString
                });
            };
            var hotel = await GetAsync(id);
        
            var hotelRoomAllocationVM = mapper.Map<HotelRoomsVM>(hotel);

            hotelRoomAllocationVM.RoomAllocations = roomAllocationVM;
            
            return hotelRoomAllocationVM;
        }
        public async Task<List<HotelListVM>> GetPopularHotel(int number)
        {
           var HotelPopularVM = new List<HotelListVM>();
            var popularHotel = await context.Hotels.Where(q => q.Rating >= 3).Take(number).ToListAsync();
            foreach (var hotel in popularHotel)
            {
                var Price = context.RoomAllocations.Where(q => q.HotelId == hotel.Id).Min(x => x.Price);
                HotelPopularVM.Add(new HotelListVM
                {
                    Name = hotel.Name,
                    Description = hotel.Description,
                    HotelPicture = hotel.HotelPicture,
                    PricePerDay = Price,
                    Location = hotel.Location,
                    NumberOfBooking = hotel.NumberOfBooking,
                    Rating = hotel.Rating
                    

                });
            };
            return HotelPopularVM;
        }
        public async Task<List<HotelListVM>> GetHotelMostPicked()
        {
            var mosPickHotel = await context.Hotels.Where(q => q.NumberOfBooking >= 8).Take(5).ToListAsync();
            var HotelMosPickedVM = mapper.Map<List<HotelListVM>>(mosPickHotel);
            return HotelMosPickedVM;
        }
        public async Task<List<HotelListVM>> GetHotelWithKingBed()
        {

            var RoomFacials = context.RoomFacilities.Where(q => q.FacilitiesId == 2).Select(x => x.RoomAllocationId);
            var roomAllocations = context.RoomAllocations.Where(q => RoomFacials.Contains(q.Id)).Select(x => x.HotelId);
            var HotelWithBed =await context.Hotels.Where(q => roomAllocations.Contains(q.Id)).ToListAsync();


            var HotelWithBedVM = mapper.Map<List<HotelListVM>>(HotelWithBed);
            return HotelWithBedVM;
        }
        public async Task<List<HotelListVM>> GetHotelKitchenInRoom()
        {

            var RoomFacials = context.RoomFacilities.Where(q => q.FacilitiesId == 5).Select(x => x.RoomAllocationId);
            var roomAllocations = context.RoomAllocations.Where(q => RoomFacials.Contains(q.Id)).Select(x => x.HotelId);
            var KitchenInRoom = await context.Hotels.Where(q => roomAllocations.Contains(q.Id)).ToListAsync();


            var KitchenInRoomVM = mapper.Map<List<HotelListVM>>(KitchenInRoom);
            return KitchenInRoomVM;
        }
        public async Task<List<HotelListVM>> GetHotelWithLocalte(string locate)
        {
            var hotelLocate = context.Hotels.Where(q => q.Location == locate).ToListAsync();
            var HotelLocalVM = mapper.Map<List<HotelListVM>>(hotelLocate);
            return HotelLocalVM;
        }
    }
}

