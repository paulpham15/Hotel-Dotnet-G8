using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelDotNet.Data;
using HotelDotNet.Contracts;
using HotelDotNet.Respositories;
using HotelDotNet.Models;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace HotelDotNet.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HotelController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHotelRespository hotelRespository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IRoomAllocationRespository roomAllocationRespository;
        private readonly IRoomTypeRespository roomTypeRepository;
        private readonly IMapper mapper;

        public HotelController(ApplicationDbContext context,IHotelRespository hotelRespository,IWebHostEnvironment webHostEnvironment, IRoomAllocationRespository roomAllocationRespository,IRoomTypeRespository roomTypeRepository,IMapper mapper)
        {
            _context = context;
            this.hotelRespository = hotelRespository;
            this.webHostEnvironment = webHostEnvironment;
            this.roomAllocationRespository = roomAllocationRespository;
            this.roomTypeRepository = roomTypeRepository;
            this.mapper = mapper;
        }

        // GET: Hotel
        public async Task<IActionResult> Index()
        {
        
              return _context.Hotels != null ? 
                          View(await _context.Hotels.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Hotels'  is null.");
        }

        // GET: Hotel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var model = await hotelRespository.GetHotelDetails(id);
            return View(model);
        }

        // GET: Hotel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hotel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HotelVM hotelVm)
        {
            if (ModelState.IsValid)
            {
                if (hotelVm?.HotelPicture != null)
                {
                    string folder = "img/HotelImg/";

                    hotelVm.ImageUrl = await UploadImage(folder, hotelVm.HotelPicture);

                }
                var hotel = new Hotel()
                {
                    Name = hotelVm.Name,
                    Description = hotelVm.Description,
                    HotelPicture = hotelVm.ImageUrl,
                    Rating = hotelVm.Rating,
                    Location = hotelVm.Location
                };
                await hotelRespository.AddAsync(hotel);
                return RedirectToAction(nameof(Index));
            }
            return View(hotelVm);
        }
        public async Task<IActionResult> CreateRoom(int? id)
        {
            var model = new RoomAllocationCreateVM
            {
                RoomTypes = new SelectList(await roomTypeRepository.GetAllAsync(), "Id", "Title"),
                HotelId = id,
            };
            ViewBag.Facilities = new SelectList(_context.Facilities, "Id", "Title");

            return View(model);
        }

        // POST: Hotel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRoom(RoomAllocationCreateVM roomVM)
        {
           
                if (ModelState.IsValid)
                {
                    if (roomVM?.Picture != null)
                    {
                        string folder = "img/HotelImg/";

                    roomVM.ImageUrl = await UploadImage(folder, roomVM.Picture);
                       
                    }


                    await roomAllocationRespository.CreateRoomRequest(roomVM);
                  
                    return RedirectToAction(nameof(Index));
                 
                }
            
          
            roomVM.RoomTypes = new SelectList(await roomTypeRepository.GetAllAsync(), "Id", "Title", roomVM.RoomTypeId);
            ViewBag.Facilities = new SelectList(_context.Facilities, "Id", "Title");
            return View(roomVM);
        }


        // GET: Hotel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Hotels == null)
            {
                return NotFound();
            }

            var hotel = await _context.Hotels.FindAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return View(hotel);
        }

        // POST: Hotel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Location,Rating,Description,HotelPicture")] Hotel hotel)
        {
            if (id != hotel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hotel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelExists(hotel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(hotel);
        }

        // GET: Hotel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Hotels == null)
            {
                return NotFound();
            }

            var hotel = await _context.Hotels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }

        // POST: Hotel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Hotels == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Hotels'  is null.");
            }
            var hotel = await _context.Hotels.FindAsync(id);
            if (hotel != null)
            {
                _context.Hotels.Remove(hotel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HotelExists(int id)
        {
          return (_context.Hotels?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {

            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverFolder = Path.Combine(webHostEnvironment.WebRootPath, folderPath);

            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return "/" + folderPath;
        }
    }
}
