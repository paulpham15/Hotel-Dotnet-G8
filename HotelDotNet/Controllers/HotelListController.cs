using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelDotNet.Contracts;
using HotelDotNet.Data;
using HotelDotNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelDotNet.Controllers
{
    public class HotelListController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHotelRespository hotelRespository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IRoomAllocationRespository roomAllocationRespository;
        private readonly IRoomTypeRespository roomTypeRepository;
        private readonly IMapper mapper;
    
        public HotelListController(ApplicationDbContext context, IHotelRespository hotelRespository, IWebHostEnvironment webHostEnvironment, IRoomAllocationRespository roomAllocationRespository, IRoomTypeRespository roomTypeRepository, IMapper mapper)
        {
            _context = context;
            this.hotelRespository = hotelRespository;
            this.webHostEnvironment = webHostEnvironment;
            this.roomAllocationRespository = roomAllocationRespository;
            this.roomTypeRepository = roomTypeRepository;
            this.mapper = mapper;
        
        }
        // GET: HotelList
        public async Task<IActionResult> Index(string searchString,int people,string datetime,int day)
        {
           
            var HotelListVM = new List<HotelListVM>();
            ViewData["people"] = people;
            ViewData["datetime"] = datetime;
            ViewData["day"] = day;
            var HotelList = new List<Hotel>();
            if(searchString != null)
            {
                HotelList = await _context.Hotels.Where(q=> q.Location == searchString).ToListAsync();
            }
            else
            {
                HotelList = await _context.Hotels.ToListAsync();
            }
      
            foreach (var hotel in HotelList)
            {
                var Price = _context.RoomAllocations.Where(q => q.HotelId == hotel.Id).Min(x => x.Price);
                HotelListVM.Add(new HotelListVM
                {
                    Id = hotel.Id,
                    Name = hotel.Name,
                    Description = hotel.Description,
                    HotelPicture = hotel.HotelPicture,
                    PricePerDay = Price,
                    Location = hotel.Location,
                    NumberOfBooking = hotel.NumberOfBooking,
                    Rating = hotel.Rating


                });

            };
            return View(HotelListVM);
        }

        // GET: HotelList/Details/5
      
        // GET: HotelList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HotelList/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HotelList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HotelList/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HotelList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HotelList/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}