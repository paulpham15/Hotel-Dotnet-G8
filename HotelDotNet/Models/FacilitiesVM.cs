using System;
namespace HotelDotNet.Models
{
	public class FacilitiesVM
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public ICollection<RoomFacilitiesVM> RoomFacilities { get; set; }

    }
}

