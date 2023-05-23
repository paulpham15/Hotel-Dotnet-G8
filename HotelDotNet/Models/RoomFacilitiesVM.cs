using System;
namespace HotelDotNet.Models
{
    public class RoomFacilitiesVM
    {
        public int Id { get; set; }
        public string Name {get;set;}
        public int RoomId { get; set; }
        public int FacilitiesId { get; set; }
    }
}

