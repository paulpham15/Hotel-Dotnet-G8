using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelDotNet.Contracts;
using HotelDotNet.Data;
using HotelDotNet.Models;
using MailKit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;

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
        
            List<HotelListVM> popularHotel = await hotelRespository.GetHotelMostPicked();
            List<HotelListVM> bedKingHotel = await hotelRespository.GetHotelWithKingBed();
            List<HotelListVM> kitchenInRoom = await hotelRespository.GetHotelKitchenInRoom();
            var model = new HomePageListVM
            {
                PopularList = popularHotel,
                HotelBedList = bedKingHotel,
                KitchenInRoom= kitchenInRoom
            };
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> FindHotel(string searchString, int people,string datetime,int day)
        {

            
            return RedirectToAction("Index", "HotelList", new { searchString = searchString, people=people,datetime= datetime,day=day });

        }
        [HttpPost]
        public async Task<IActionResult> GoBooking(int HotelId,int roomId, int people, string datetime, int numberofday, int totalprice)
        {
            if (ModelState.IsValid)
            { return RedirectToAction("Booking", "ClientBooking", new { HotelId = HotelId, roomId = roomId, people = people, datetime = datetime, numberofday = numberofday, totalprice = totalprice }); }
            return View();
                

        }
        [HttpGet]
        public async Task<IActionResult> GetPriceHotel(int RoomId)
        {
            var Price = context.RoomAllocations.Where(q => q.Id == RoomId).Select(x => x.Price);
            return Json(new { items = Price });
        }
        public async Task<IActionResult> HotelDetail(int id, int people,string datetime,int day)
        {
            ViewBag.People = people;
            ViewBag.Datetime = datetime;
            ViewBag.Day = day;
            ViewBag.Rooms = new SelectList(context.RoomAllocations.Where(q=> q.HotelId == id), "Id", "RoomName");
            var model = await hotelRespository.GetHotelDetails(id);
            return View(model);
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromForm] MailRequest request)
        {
            try
            {
               
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}

