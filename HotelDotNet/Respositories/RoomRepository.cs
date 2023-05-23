using System;
using HotelDotNet.Contracts;
using HotelDotNet.Data;

namespace HotelDotNet.Respositories
{
	public class RoomRepository : GenericRepository<Room>, IRoomRespository
    {
        public RoomRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

