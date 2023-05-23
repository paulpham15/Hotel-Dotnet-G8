using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelDotNet.Data
{
	public class RoomAllocation
	{
		public int Id { get; set; }
		public string? RoomName { get; set; }
		[ForeignKey("RoomTypeId")]
		public RoomType RoomType { get; set; }
		public int? RoomTypeId { get; set; }

        //[ForeignKey("FacilitiesId")]
        //public Facilities Facilities { get; set; }
        //public int? FacilitiesId { get; set; }

        public int? HotelId { get; set; }

		public int? Price { get; set; }
		public string? RoomTypeString { get;set; }

		public int? NumberOfRoom { get; set; }

        public string? Picture { get; set; }
		public virtual ICollection<Facilities> FacilityList { get; set; }


    }
}

