using System;
using System.ComponentModel.DataAnnotations;

namespace HotelDotNet.Data
{
	public class Report
	{
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Note { get; set; }
    }
}

