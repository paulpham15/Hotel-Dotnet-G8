using System;
using HotelDotNet.Data;

namespace HotelDotNet.Models
{
	public class CartVM
	{
		public int Id { get; set; }
		public int HotelId { get; set; }
		public RoomVM Room { get; set; }
		public string CustomerId { get; set; }
		public ApplicationUser Customer { get; set; }
		public DateTime FromDate { get; set; }
		public DateTime ToData { get; set; }
		public decimal TotalPrice { get; set; }
		public int TotalDays { get; set; }

    }
}

