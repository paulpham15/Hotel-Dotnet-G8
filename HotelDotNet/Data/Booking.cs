using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelDotNet.Data
{
	public class Booking
	{
		public int Id { get; set; }

        [ForeignKey("HotelId")]
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        [ForeignKey("RoomAllocationId")]
        public int RoomAllocationId { get; set; }
        public RoomAllocation RoomAllocation { get; set; }
        public int TotalPrice { get; set; }
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public int? ClientPhoneNumber { get; set; }
        public int TotalClient { get; set; }
        public string? Note { get; set; }
        public bool? DoneBooking { get; set; }
    }
}

