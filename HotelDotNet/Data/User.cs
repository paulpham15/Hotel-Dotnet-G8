using System;
using Microsoft.AspNetCore.Identity;

namespace HotelDotNet.Data
{
    public class User : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Address { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public DateTime DateJoined { get; set; }
    }
}

