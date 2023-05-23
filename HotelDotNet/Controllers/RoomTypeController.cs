using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelDotNet.Data;
using HotelDotNet.Contracts;
using AutoMapper;
using HotelDotNet.Models;
using HotelDotNet.Respositories;
using Microsoft.AspNetCore.Authorization;

namespace HotelDotNet.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RoomTypeController : Controller
    {

        private readonly IRoomTypeRespository roomTypeRespository;
        private readonly IMapper mapper;
        private readonly IRoomAllocationRespository roomAllocationRespository;

        public RoomTypeController(IRoomTypeRespository roomTypeRespository, IMapper mapper, IRoomAllocationRespository roomAllocationRespository)
        {
            this.mapper = mapper;
            this.roomAllocationRespository = roomAllocationRespository;
            this.roomTypeRespository = roomTypeRespository;
        }

        // GET: RoomType
        public async Task<IActionResult> Index()
        {
            var roomType = mapper.Map<List<RoomTypeVM>>(await roomTypeRespository.GetAllAsync());
            return View(roomType);
        }

        // GET: RoomType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var roomTypes = await roomTypeRespository.GetAsync(id);
            if (roomTypes == null)
            {
                return NotFound();
            }

            var roomTypeVM = mapper.Map<RoomTypeVM>(roomTypes);
            return View(roomTypeVM);
        }

        // GET: RoomType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RoomTypeVM roomTypeVM)
        {
            if (ModelState.IsValid)
            {
                var roomType = mapper.Map<RoomType>(roomTypeVM);
                await roomTypeRespository.AddAsync(roomType);
                return RedirectToAction(nameof(Index));
            }
            return View(roomTypeVM);
        }

        // GET: RoomType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var roomTypes = await roomTypeRespository.GetAsync(id);
            if (roomTypes == null)
            {
                return NotFound();
            }

            var leaveTypeVM = mapper.Map<RoomTypeVM>(roomTypes);
            return View(leaveTypeVM);
        }

        // POST: RoomType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, RoomTypeVM roomTypeVM)
        {
            if (id != roomTypeVM.Id)
            {
                return NotFound();
            }

            var roomType = await roomTypeRespository.GetAsync(id);

            if (roomType == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    mapper.Map(roomTypeVM, roomType);
                    await roomTypeRespository.UpdateAsync(roomType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await roomTypeRespository.Exists(roomTypeVM.Id))
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
            return View(roomTypeVM);
        }

        // GET: RoomType/Delete/5
       

        // POST: RoomType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await roomTypeRespository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AllocateRoom(int id)

        {
            //await roomAllocationRespository.RoomAllocation(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
