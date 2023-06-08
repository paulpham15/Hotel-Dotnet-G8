using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HotelDotNet.Models
{
	public class BookingCreateVM
	{
        [Required]
        [Range(1, 3, ErrorMessage = "Can only be between 1 .. 3")]
        public int people { get; set; }
        [Required]
        [Range(1, 3, ErrorMessage = "Can only be between 1 .. 3")]
        public int day { get; set; }
        [Required]
        public string datetime { get; set; }
        [Required]
        [Range(1, 9999999999999999999, ErrorMessage = "Can only be between 1 .. 3")]
        public int totalprice { get; set; }
    }
}

