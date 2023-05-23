using System;
using HotelDotNet.Data;
using HotelDotNet.Models;

namespace HotelDotNet.Contracts
{
    public interface IHotelRespository : IGenericRepository<Hotel>
	{
		Task<HotelRoomsVM> GetHotelDetails(int? id);
	}
}

