using System;
using AutoMapper;
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
        public async Task<List<HotelVM>> GetPopularHotel(int number)
        {
            var popularHotel = context.Hotels.Where(q => q.Rating >= 3).Take(number).ToListAsync();
            var HotelPopularVM = mapper.Map<List<HotelVM>>(popularHotel);
            return HotelPopularVM;
        }
        public async Task<List<HotelVM>> GetHotelWithLocalte(string locate)
        {
            var hotelLocate = context.Hotels.Where(q => q.Location == locate).ToListAsync();
            var HotelLocalVM = mapper.Map<List<HotelVM>>(hotelLocate);
            return HotelLocalVM;
        }
    }
}

