using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HotelDotNet.Models
{
	public class HotelEditVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int NumberOfBooking { get; set; }
        //public RoomVM Room { get; set; }
        public int? Rating { get; set; }
        [Display(Name = "Picture Hotel")]
        public IFormFile? PickerHotelPicture { get; set; }
        public string? ImageUrl { get; set; }
    }
}


