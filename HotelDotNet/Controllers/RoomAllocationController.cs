using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelDotNet.Data;
using Microsoft.AspNetCore.Authorization;

namespace HotelDotNet.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RoomAllocationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoomAllocationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RoomAllocation
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RoomAllocations.Include(r => r.RoomType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RoomAllocation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RoomAllocations == null)
            {
                return NotFound();
            }

            var roomAllocation = await _context.RoomAllocations
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomAllocation == null)
            {
                return NotFound();
            }

            return View(roomAllocation);
        }

        // GET: RoomAllocation/Create
        public IActionResult Create()
        {
            ViewData["RoomTypeId"] = new SelectList(_context.RoomTypes, "Id", "Id");
            return View();
        }

        // POST: RoomAllocation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoomName,RoomTypeId,HotelId,Price,NumberOfRoom,Picture")] RoomAllocation roomAllocation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roomAllocation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomTypeId"] = new SelectList(_context.RoomTypes, "Id", "Id", roomAllocation.RoomTypeId);
            return View(roomAllocation);
        }

        // GET: RoomAllocation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RoomAllocations == null)
            {
                return NotFound();
            }

            var roomAllocation = await _context.RoomAllocations.FindAsync(id);
            if (roomAllocation == null)
            {
                return NotFound();
            }
            ViewData["RoomTypeId"] = new SelectList(_context.RoomTypes, "Id", "Id", roomAllocation.RoomTypeId);
            return View(roomAllocation);
        }

        // POST: RoomAllocation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoomName,RoomTypeId,HotelId,Price,NumberOfRoom,Picture")] RoomAllocation roomAllocation)
        {
            if (id != roomAllocation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomAllocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomAllocationExists(roomAllocation.Id))
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
            ViewData["RoomTypeId"] = new SelectList(_context.RoomTypes, "Id", "Id", roomAllocation.RoomTypeId);
            return View(roomAllocation);
        }

        // GET: RoomAllocation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RoomAllocations == null)
            {
                return NotFound();
            }

            var roomAllocation = await _context.RoomAllocations
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomAllocation == null)
            {
                return NotFound();
            }

            return View(roomAllocation);
        }

        // POST: RoomAllocation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RoomAllocations == null)
            {
                return Problem("Entity set 'ApplicationDbContext.RoomAllocations'  is null.");
            }
            var roomAllocation = await _context.RoomAllocations.FindAsync(id);
            if (roomAllocation != null)
            {
                _context.RoomAllocations.Remove(roomAllocation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomAllocationExists(int id)
        {
          return (_context.RoomAllocations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
