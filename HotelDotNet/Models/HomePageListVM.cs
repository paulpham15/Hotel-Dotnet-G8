using System;
namespace HotelDotNet.Models
{
	public class HomePageListVM
	{
		public List<HotelListVM> PopularList { get; set; }
        public List<HotelListVM> HotelBedList { get; set; }
    }
}

