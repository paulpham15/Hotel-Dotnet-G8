using System;
using HotelDotNet.Data;
using HotelDotNet.Models;

namespace HotelDotNet.Contracts
{
    public interface IHotelRespository : IGenericRepository<Hotel>
	{
		Task<HotelRoomsVM> GetHotelDetails(int? id);
        Task<List<HotelVM>> GetPopularHotel(int number);
        Task<List<HotelVM>> GetHotelWithLocalte(string locate);
    }
}

