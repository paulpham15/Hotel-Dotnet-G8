using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HotelDotNet.Models
{
	public class BookingVM
	{
        public int Id { get; set; }

    
        public int HotelId { get; set; }
      
        public int RoomAllocationId { get; set; }
        public string DateCheckIn { get; set; }
        public int TotalPrice { get; set; }
        public int TotalDay{ get; set; }
        public string? ClientId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public int ClientPhoneNumber { get; set; }
        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        [Display(Name = "Email")]
        public string? ClientEmail { get; set; }
        public int TotalPeople { get; set; }
        public string? Note { get; set; }
        public bool? DoneBooking { get; set; }
    }
}

