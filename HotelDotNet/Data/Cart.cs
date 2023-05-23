using System;
namespace HotelDotNet.Data
{
	public class Cart
	{
		public int Id { get; set; }
		public int HotelId { get; set; }
		public Room Room { get; set; }
		public string CustomerId { get; set; }
		public ApplicationUser Customer { get; set; }
		public DateTime FromDate { get; set; }
		public DateTime ToData { get; set; }
		public decimal TotalPrice { get; set; }
		public int TotalDays { get; set; }

    }
}

