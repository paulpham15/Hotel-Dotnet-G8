using System;
using HotelDotNet.Contracts;
using HotelDotNet.Data;

namespace HotelDotNet.Respositories
{
	public class RoomTypeRepository : GenericRepository<RoomType>, IRoomTypeRespository
    {
        public RoomTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

