using System;
using HotelDotNet.Data;

namespace HotelDotNet.Models
{
	public class HotelRoomsVM: HotelListVM
    {
		public BookingCreateVM BookingCreate { get; set; }
        public List<RoomAllocationVM> RoomAllocations { get; set; }
      
    }
}

