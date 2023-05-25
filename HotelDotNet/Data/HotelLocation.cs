using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelDotNet.Data
{
	public class HotelLocation
	{
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

