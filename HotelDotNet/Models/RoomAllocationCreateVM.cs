using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HotelDotNet.Models
{
	public class RoomAllocationCreateVM
	{
        [Required]
        [Display(Name = "Roome Name")]
        public string? RoomName { get; set; }

             public int? Price { get; set; }
        [Required]
        [Display(Name = "Number of room")]
        public int? NumberOfRoom { get; set; }
            [Required]
            [Display(Name = "Roome Type")]
            public int? RoomTypeId { get; set; }
            public SelectList? RoomTypes { get; set; }

            [Display(Name = "Facilities")]
            public List<int> FacilitiesId { get; set; }
            public int? HotelId { get; set; }
            public IFormFile? Picture { get; set; }
            public string? ImageUrl { get; set; }
    }
	
}

