using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelDotNet.Data
{
	public class RoomType
	{
		public int Id { get; set; }
		public string Title { get; set; }
    }

}

