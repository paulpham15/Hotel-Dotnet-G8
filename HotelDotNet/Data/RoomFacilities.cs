using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HotelDotNet.Data
{
	public class RoomFacilities
	{
        public int Id { get; set; }

        [ForeignKey("RoomAllocationId")]
        public int RoomAllocationId { get; set; }
        public RoomAllocation RoomAllocation { get; set; }

        [ForeignKey("FacilitiesId")]
        public int FacilitiesId { get; set; }
        public Facilities Facilities { get; set; }

    }
}

