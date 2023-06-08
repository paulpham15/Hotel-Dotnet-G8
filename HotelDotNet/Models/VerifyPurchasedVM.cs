using System;
using System.ComponentModel.DataAnnotations;

namespace HotelDotNet.Models
{
	public class VerifyPurchasedVM
	{
		public int Id { get; set; }
     
        [Display(Name = "Card Number")]

     
        public int CreditCardNumber { get; set; }
        [Required]
        [Display(Name = "Name Holder")]
        public string CreditNameHolder { get; set; }
        [Required]
        public int CCV { get; set; }
    }
}

