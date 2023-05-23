using System;
using AutoMapper;
using HotelDotNet.Contracts;
using HotelDotNet.Data;
using HotelDotNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using HotelDotNet.Utility;
using Amazon.S3;
using Amazon.S3.Transfer;
using Microsoft.AspNetCore.Hosting;
using NuGet.Packaging.Signing;

namespace HotelDotNet.Respositories
{
    public class RoomAllocationResposiory : GenericRepository<RoomAllocation>, IRoomAllocationRespository
    {
        private readonly ApplicationDbContext context;
        private readonly IHotelRespository hotel;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IRoomFacilitiesRespository roomFacilitiesRespository;
        private readonly IRoomTypeRespository roomTypeRespository;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;

        public RoomAllocationResposiory(ApplicationDbContext context,IHotelRespository hotel,IWebHostEnvironment webHostEnvironment,IRoomFacilitiesRespository roomFacilitiesRespository,IRoomTypeRespository roomTypeRespository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(context)
        {
            this.context = context;
            this.hotel = hotel;
            this.webHostEnvironment = webHostEnvironment;
            this.roomFacilitiesRespository = roomFacilitiesRespository;
            this.roomTypeRespository = roomTypeRespository;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<bool> AllocationExists(int hotelId, int roomTypeId)
        {
            return await context.RoomAllocations.AnyAsync(q => q.HotelId == hotelId && q.RoomTypeId == roomTypeId);
        }

        public async Task CreateRoomRequest(RoomAllocationCreateVM model)
        {

            var roomType = await context.RoomTypes.Where(q => q.Id == model.RoomTypeId).ToListAsync();
            foreach(var room in roomType)
            {
                var newRoom = new RoomAllocation()
                {
                    RoomName = model.RoomName,
                    RoomTypeId = model.RoomTypeId,
                    Picture = model.ImageUrl,
                    Price = model.Price,
                    HotelId = model.HotelId,
                    NumberOfRoom = model.NumberOfRoom,
                    RoomTypeString = room.Title,

                };
                await AddAsync(newRoom);

                foreach (int id in model.FacilitiesId)
                {
                    var newFacilitiesRoom = new RoomFacilities
                    {
                        FacilitiesId = id,
                        RoomAllocationId = newRoom.Id,
                    };
                    await roomFacilitiesRespository.AddAsync(newFacilitiesRoom);

                }


            }
        
          
        }
       

    }
}

