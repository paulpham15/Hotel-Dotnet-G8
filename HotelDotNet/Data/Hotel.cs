using System;
using System.ComponentModel.DataAnnotations;

namespace HotelDotNet.Data
{
	public class Hotel
	{
    
        public int Id { get; set; }
        public string Name { get; set; }
		public string Location { get; set; }

        public int? Rating { get; set; }
	
		public string? Description { get; set; }
		
		public string? HotelPicture { get; set; }

		public int? NumberOfBooking { get; set; }

		public HotelAvail hotelAvail { get; set; }

    }
	public enum HotelAvail : int
	{
		Full = 0,
		Available = 1,
	}
}

