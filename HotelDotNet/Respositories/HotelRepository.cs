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
            var hotel = await GetAsync(id);
        
            var hotelRoomAllocationVM = mapper.Map<HotelRoomsVM>(hotel);
           
            hotelRoomAllocationVM.RoomAllocations = mapper.Map<List<RoomAllocationVM>>(roomAllocation);
            
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
            var mosPickHotel = await context.Hotels.Where(q => q.NumberOfBooking >= 10).ToListAsync();
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
        public async Task<List<HotelListVM>> GetHotelWithLocalte(string locate)
        {
            var hotelLocate = context.Hotels.Where(q => q.Location == locate).ToListAsync();
            var HotelLocalVM = mapper.Map<List<HotelListVM>>(hotelLocate);
            return HotelLocalVM;
        }
    }
}

