using System;
using HotelDotNet.Data;
using HotelDotNet.Models;

namespace HotelDotNet.Contracts
{ 
        public interface IRoomAllocationRespository : IGenericRepository<RoomAllocation>
        {
             //Task RoomAllocation(int roomTypeId);
             Task<bool> AllocationExists(int hotelId, int roomTypeId);
             Task CreateRoomRequest(RoomAllocationCreateVM model);
               
		}
	
}

