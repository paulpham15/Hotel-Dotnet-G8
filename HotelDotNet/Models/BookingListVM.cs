using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HotelDotNet.Models
{
    public class BookingListVM
    {
		public int Id { get; set; }
        [Display(Name = "Hotel Name")]
        public string HotelName { get; set; }
        [Display(Name = "Room Name")]
        public string RoomName { get; set; }
        [Display(Name = "Booking Id")]
        public string BookingId { get; set; }
        public int Price { get; set; }
        public int People { get; set; }
        public int Day { get; set; }
        [Display(Name = "Checkin Date")]
        public string CheckinDate { get; set; }
        [Display(Name = "Status Booking")]
        public bool Status { get; set; }
       

    }
}

