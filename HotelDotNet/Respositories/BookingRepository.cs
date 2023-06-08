using System;
using HotelDotNet.Contracts;
using HotelDotNet.Data;

namespace HotelDotNet.Respositories
{
	public class RoomFacilitiesRepository : GenericRepository<RoomFacilities>, IRoomFacilitiesRespository
    {
        public RoomFacilitiesRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

