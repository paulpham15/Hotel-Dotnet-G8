using System;
using HotelDotNet.Data;

namespace HotelDotNet.Models
{
	public class HotelRoomsVM: HotelListVM
    {
		
		public List<RoomAllocationVM> RoomAllocations { get; set; }
    }
}

