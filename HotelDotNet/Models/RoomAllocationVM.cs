using System;
using HotelDotNet.Data;
namespace HotelDotNet.Models
{
	public class RoomAllocationVM
	{
		
        public int Id { get; set; }
		public string RoomName { get; set; }
		public int Price { get; set; }
		public int NumberOfRoom { get; set; }
		public string? Picture { get; set; }
		public int? RoomTypeId { get; set; }
		public string? RoomTypeString { get; set; }
        public List<Facilities> RoomFacilityList { get; set; }

        public RoomFacilitiesVM? RoomFacilities { get; set; }
    
	}
}

