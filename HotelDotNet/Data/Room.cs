using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelDotNet.Data
{
	public class Room
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public RoomType RoomType { get; set; }
		public decimal Price { get; set; }
        public string? Picture { get; set; }
	
    }

   
}

