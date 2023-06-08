using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelDotNet.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HotelDotNet.Contracts;
using HotelDotNet.Respositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HotelDotNet.Models;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using IronBarCode;
using QRCoder;
using static Amazon.S3.Util.S3EventNotification;


namespace HotelDotNet.Controllers
{
    public class ClientBookingController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IBookingRespository bookingRespository;
        private readonly UserManager<User> userManager;

        public ClientBookingController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment, IBookingRespository bookingRespository, UserManager<User> userManager)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
            this.bookingRespository = bookingRespository;
            this.userManager = userManager;
        }
        // GET: ClientBooking
        public ActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> CheckOutComplete(int billId)
        {
            var BookingBill = await context.Booking.Where(q => q.Id == billId).FirstOrDefaultAsync();
            var Hotel = await context.Hotels.Where(q => q.Id == BookingBill.HotelId).FirstOrDefaultAsync();
            var Room = await context.RoomAllocations.Where(q => q.Id == BookingBill.RoomAllocationId).FirstOrDefaultAsync();

            // use this when you want to show your logo in middle of QR Code and change color of qr code
            //Bitmap logoImage = new Bitmap(@"wwwroot/img/Virat-Kohli.jpg");
            //var qrCodeAsBitmap = qrCode.GetGraphic(20, Color.Black, Color.Red, logoImage);
            QRCodeData qrCodeData;
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                qrCodeData = qrGenerator.CreateQrCode(BookingBill.BookingId, QRCodeGenerator.ECCLevel.Q);
            }

            // Image Format
            var imgType = Base64QRCode.ImageType.Png;

            var qrCode = new Base64QRCode(qrCodeData);
            //Base64 Format
            string qrCodeImageAsBase64 = qrCode.GetGraphic(20, SixLabors.ImageSharp.Color.DeepPink, SixLabors.ImageSharp.Color.White, true, imgType);
            //Base64 Format
          
            ViewBag.QrCodeUri = qrCodeImageAsBase64;
            ViewBag.HotelName = Hotel.Name;
            ViewBag.RoomName = Room.RoomName;
            ViewBag.DateCheckin = BookingBill.DateCheckIn;
            return View(BookingBill);
        }
        private byte[] BitmapToByteArray(Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        // GET: ClientBooking/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientBooking/Create
        public async Task<IActionResult> Booking(int HotelId, int roomId, int people, string datetime, int numberofday, int totalprice)
        {
            var user = await userManager.GetUserAsync(User);
            var Hotel = await context.Hotels.Where(q => q.Id == HotelId).FirstOrDefaultAsync();
            var Room = await context.RoomAllocations.Where(q => q.Id == roomId).FirstOrDefaultAsync();
            ViewBag.LastName = user.Lastname??"";
            ViewBag.ClientId = user.Id??"";
            ViewBag.FirstName = user.Firstname??"";
            ViewBag.Email = user.Email??"";
            ViewBag.TotalPrice = totalprice;
            ViewBag.People = people;
            ViewBag.NumberOfDay = numberofday;
            ViewBag.DateTime = datetime;
            ViewBag.Hotel = Hotel.Name;
            ViewBag.HotelId = HotelId;
            ViewBag.Location = Hotel.Location;
            ViewBag.Room = Room.RoomName;
            ViewBag.RoomId = roomId;
            return View();
        }

        // POST: ClientBooking/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Booking(BookingVM BookingVM)
        {
            if (ModelState.IsValid)
            {
                int length = 10;

                // creating a StringBuilder object()
                StringBuilder str_build = new StringBuilder();
                Random random = new Random();

                char letter;

                for (int i = 0; i < length; i++)
                {
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    str_build.Append(letter);
                }
                var Booking = new Booking {
                    ClientEmail = BookingVM.ClientEmail,
                    ClientId = BookingVM.ClientId,
                    ClientName = BookingVM.FirstName + " " +BookingVM.LastName,
                    ClientPhoneNumber = BookingVM.ClientPhoneNumber,
                    RoomAllocationId = BookingVM.RoomAllocationId,
                    HotelId = BookingVM.HotelId,
                    TotalPrice = BookingVM.TotalPrice,
                    TotalPeople = BookingVM.TotalPeople,
                    DateCheckIn= BookingVM.DateCheckIn,
                    DoneBooking = false,
                    BookingId= str_build.ToString(),
                };
                context.Add(Booking);
                await context.SaveChangesAsync();
                return RedirectToAction("VerifyPurcharsed", "ClientBooking", new
                {
                    billId = Booking.Id,
                });
           }
           return View(BookingVM);
        }
        public async Task<IActionResult> VerifyPurcharsed(int billId)
        {
          
            var BookingBill = await context.Booking.Where(q => q.Id == billId).FirstOrDefaultAsync();
            ViewBag.BillId = billId;
            ViewBag.TotalPrice = BookingBill.TotalPrice;
            return View();
        }

        // POST: ClientBooking/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VerifyPurcharsed(VerifyPurchasedVM model)
        {
            var BookingBill = await context.Booking.Where(q => q.Id == model.Id).FirstOrDefaultAsync();
            ViewBag.BillId = model.Id;
            ViewBag.TotalPrice = BookingBill.TotalPrice;
            if (ModelState.IsValid)
            {
                BookingBill.DoneBooking = true;
                context.Update(BookingBill);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(CheckOutComplete), new
                {
                    billId = BookingBill.Id,
                });
            }
           
            return View(model);
        }
        // GET: ClientBooking/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientBooking/Edit/5
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

        // GET: ClientBooking/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientBooking/Delete/5
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
    public static class BitmapExtension
    {
        public static byte[] BitmapToByteArray(this Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}