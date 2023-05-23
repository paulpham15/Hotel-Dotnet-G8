using System;
namespace HotelDotNet.Data
{
	public class OrderHeader
	{
		public int Id { get; set; }
		public string CustomerId { get; set; }
		public ApplicationUser Customer { get; set; }
		public DateTime DateOfOrder { get; set; }
		public decimal OrderTotal { get; set; }
		public string? OrderStatus { get; set; }
		public string? PaymentStatus { get; set; }
		public string? SessionId { get; set; }
		public string? PaymentIntentId { get; set; }
		public DateTime DateofPayment { get; set; }
		public DateTime DueDate { get; set; }
		public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

    }
}

