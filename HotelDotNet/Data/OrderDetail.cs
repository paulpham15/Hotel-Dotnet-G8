using System;
namespace HotelDotNet.Data
{
	public class OrderDetail
	{
		public int Id { get; set; }
		public int OrderHeaderId { get; set; }
		public OrderHeader OrderHeader { get; set; }
		public int RoomId { get; set; }
		public Room Room { get; set; }
		public decimal Price { get; set; }
		public int TotalDays { get; set; }


    }
}

