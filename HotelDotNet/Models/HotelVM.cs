using System;
namespace HotelDotNet.Models
{
	public class HotelVM
	{
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        //public RoomVM Room { get; set; }
        public int? Rating { get; set; }
        public IFormFile? HotelPicture { get; set; }
        public string? ImageUrl { get; set; }
        
    }
}

