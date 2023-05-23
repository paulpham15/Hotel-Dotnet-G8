using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelDotNet.Models
{
	public class RoomVM : RoomAllocationCreateVM
    {
	
        public RoomTypeVM RoomType { get; set; }
       
		
    }
}

