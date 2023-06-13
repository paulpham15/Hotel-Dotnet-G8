using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HotelDotNet.Models
{
	public class HotelVM
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        [Display(Name = "Number Of Room")]
        public int NumberOfBooking { get; set; }
        //public RoomVM Room { get; set; }
        public int? Rating { get; set; }
        [Display(Name = "Hotel Picture")]
        public IFormFile? HotelPicture { get; set; }
        public string? ImageUrl { get; set; }
        
    }
}

