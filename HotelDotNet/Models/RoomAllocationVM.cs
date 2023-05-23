using System;
namespace HotelDotNet.Models
{
	public class RoomAllocationVM
	{
		
        public int Id { get; set; }
		public string RoomName { get; set; }
		public int Price { get; set; }
		public string? Picture { get; set; }
		public int? RoomTypeId { get; set; }
		public string? RoomTypeString { get; set; }
		public RoomFacilitiesVM? RoomFacilities { get; set; }
    
	}
}

