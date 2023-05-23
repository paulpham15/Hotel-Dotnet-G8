using System;
namespace HotelDotNet.Models
{
	public class OrderDetailVM
	{
		public int Id { get; set; }
		public int OrderHeaderId { get; set; }
		public OrderHeaderVM OrderHeader { get; set; }
		public int RoomId { get; set; }
		public RoomVM Room { get; set; }
		public decimal Price { get; set; }
		public int TotalDays { get; set; }


    }
}

