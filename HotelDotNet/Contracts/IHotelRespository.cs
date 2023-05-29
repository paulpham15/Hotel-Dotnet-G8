using System;
using HotelDotNet.Data;
using HotelDotNet.Models;

namespace HotelDotNet.Contracts
{
    public interface IHotelRespository : IGenericRepository<Hotel>
	{
		Task<HotelRoomsVM> GetHotelDetails(int? id);
        Task<List<HotelListVM>> GetPopularHotel(int number);
        Task<List<HotelListVM>> GetHotelWithKingBed();
        Task<List<HotelListVM>> GetHotelMostPicked();
        Task<List<HotelListVM>> GetHotelWithLocalte(string locate);
    }
}

