using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelDotNet.Contracts;
using HotelDotNet.Data;
using HotelDotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelDotNet.Controllers
{
   
    public class HomePageController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IHotelRespository hotelRespository;

        public HomePageController(ApplicationDbContext context, IHotelRespository hotelRespository)
        {
            this.context = context;
            this.hotelRespository = hotelRespository;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            ViewBag.Location = new SelectList(context.Locations, "Name", "Name");
            List<HotelListVM> popularHotel = await hotelRespository.GetPopularHotel(5);
            List<HotelListVM> bedKingHotel = await hotelRespository.GetHotelWithKingBed();
            var model = new HomePageListVM
            {
                PopularList = popularHotel,
                HotelBedList= bedKingHotel,
            };
            return View(model);
         
        }
    }
}

