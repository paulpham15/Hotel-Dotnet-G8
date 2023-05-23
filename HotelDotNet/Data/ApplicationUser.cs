using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HotelDotNet.Data
{
	public class ApplicationUser: IdentityUser
	{
		[Required]
		public string Name { get; set; }
		public string? city { get; set; }
	}
}

