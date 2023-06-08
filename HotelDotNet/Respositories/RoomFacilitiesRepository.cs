using System;
using HotelDotNet.Contracts;
using HotelDotNet.Data;

namespace HotelDotNet.Respositories
{
	public class BookingRepository : GenericRepository<Booking>, IBookingRespository
    {
        public BookingRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

