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
    }
}

