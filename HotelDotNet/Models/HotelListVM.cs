using System;
namespace HotelDotNet.Models
{
	public class HotelListVM
	{
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        //public RoomVM Room { get; set; }
        public string? Rating { get; set; }
       
        public string? HotelPicture { get; set; }
    }
}

