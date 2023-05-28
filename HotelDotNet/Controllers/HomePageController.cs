using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelDotNet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelDotNet.Controllers
{
   
    public class HomePageController : Controller
    {
        private readonly ApplicationDbContext context;

        public HomePageController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Location = new SelectList(context.Locations, "Name", "Name");
            return View();
         
        }
    }
}

