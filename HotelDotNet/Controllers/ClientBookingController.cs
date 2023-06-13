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
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authorization;

namespace HotelDotNet.Controllers
{
    [Authorize]
    public class ClientBookingController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IEmailSender emailSender;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IBookingRespository bookingRespository;
        private readonly UserManager<User> userManager;

        public ClientBookingController(ApplicationDbContext context, IEmailSender emailSender, IWebHostEnvironment webHostEnvironment, IBookingRespository bookingRespository, UserManager<User> userManager)
        {
            this.context = context;
            this.emailSender = emailSender;
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
            var user = await userManager.GetUserAsync(User);
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
            if(user.Id == BookingBill.ClientId)
            {
                return View(BookingBill);
            }
            return new RedirectResult(url: "/Error");
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
                    TotalDay = BookingVM.TotalDay,
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
        public async Task<IActionResult> YourBooking()
        {
            var user = await userManager.GetUserAsync(User);
            var BookingBill = await context.Booking.Where(q => q.ClientId == user.Id).OrderByDescending(s => s.Id).ToListAsync();
            var Booking = new List<BookingListVM>();
            foreach (var bookingdata in BookingBill)
            {
                var Hotel = await context.Hotels.Where(q => q.Id == bookingdata.HotelId).FirstOrDefaultAsync();
                var Room = await context.RoomAllocations.Where(q => q.Id == bookingdata.RoomAllocationId).FirstOrDefaultAsync();

                Booking.Add(new BookingListVM
                {
                    BookingId = bookingdata.BookingId ?? "",
                    HotelName = Hotel.Name ?? "",
                    RoomName = Room.RoomName ?? "",
                    CheckinDate = bookingdata.DateCheckIn ?? "",
                    Day = bookingdata.TotalDay,
                    Price = bookingdata.TotalPrice,
                    People = bookingdata.TotalPeople,
                    Id = bookingdata.Id,
                    Status = bookingdata.DoneBooking ?? false,
                });
            };


            return View(Booking);
        }

        // POST: ClientBooking/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VerifyPurcharsed(VerifyPurchasedVM model)
        {
            var BookingBill = await context.Booking.Where(q => q.Id == model.Id).FirstOrDefaultAsync();
            ViewBag.BillId = model.Id;
            var Hotel = await context.Hotels.Where(q => q.Id == BookingBill.HotelId).FirstOrDefaultAsync();
            ViewBag.TotalPrice = BookingBill.TotalPrice;
            var url = Request.Scheme + "://" + Request.Host.Value;
            if (ModelState.IsValid)
            {
                var callbackUrl = Url.Page(
                       "/",
                       pageHandler: null,
                       values: new {billId = model.Id }
                   );
                await emailSender.SendEmailAsync(BookingBill.ClientEmail, "Booking Complete",
                      $"<table width=\"100%\" height=\"100%\" border=\"0\" cellpadding=\"20\" cellspacing=\"0\" style=\"margin:0;border-collapse:collapse;border-spacing:0;padding:20px;font-family: Arial;\">\n  <tr>\n    <td width=\"100%\" valign=\"top\" align=\"center\" bgcolor=\"#eceeed\">\n      <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"body\" style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;width:100%;background:#fff;max-width:550px;margin:0px;border-radius:5px;\">\n        <tr style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">\n          <td class=\"container\" style=\"padding:0;border-collapse:collapse;border-spacing:0;\">\n            <div class=\"content\" style=\"margin:0;padding:0;\">\n              <table class=\"main\" style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">\n                <tr style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">\n                  <td class=\"wrapper\" style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">\n                    <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">\n                      <tr style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">\n                        <td style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">\n                          \n                          <div class=\"in-content\" style=\"margin:0;padding:0;padding:30px;width: 100%\">\n                            <h3 style=\"margin:0;font-family:Helvetica, Arial;line-height:1.4;color:#3f526d;font-weight:600;font-size:20px;margin:20px 0px 15px;padding:0;text-align:center\">Booking Complete!</h3>\n                            <p style=\"margin:0;padding:0;font-family:Helvetica, Arial;margin-bottom:10px;font-weight:300;color:#96a6b0;font-size:15px;line-height:1.6;\">Thank for your booking {BookingBill.ClientName} hope to see you!<br>Your booking ID is: <b>{BookingBill.BookingId}</p>\n                            <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"btn btn-primary\" width=\"100%\" style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">\n                              <tbody style=\"margin:0;padding:0;\">\n                                <tr style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">\n                                  <td align=\"center\" style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">\n                                    <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">\n                                      <tbody style=\"margin:0;padding:0;\">\n                                        <tr style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">\n                                          <td style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">\n                                            <div style=\"margin:0;padding:0;text-align: center;width: 100%;\">\n                                              <a href='{url}/ClientBooking/CheckOutComplete?billId={model.Id}' target=\"_blank\" class=\"cta-button\" style=\"margin:0;padding:0;display:inline-block;background:#8799f6;color:#fff;text-decoration:none;padding:15px 25px;border-radius:5px;font-size:14px;letter-spacing:1px;font-weight:100;margin:20px auto;\">Bill Infomation</a>                                              </div>\n                                          </td>\n                                        </tr>\n                                      </tbody>\n                                    </table>\n                                  </td>\n                                </tr>\n                              </tbody>\n                            </table>\n                          </div>\n                        </td>\n                      </tr>\n                    </table>\n                  </td>\n                </tr>\n              </table>\n            </div>\n          </td>\n        </tr>\n      </table>\n    </td>\n  </tr>\n  <tr>\n    <td width=\"100%\" valign=\"top\" align=\"center\" bgcolor=\"#eceeed\">\n      <table style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;width: 100%;max-width: 550px;margin: 0px auto;text-align: center;color: #ccc;font-size: 14px;\" align=\"center\">\n        <tr style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">\n          <td style=\"margin:0;padding:0;border-collapse:collapse;border-spacing:0;\">&copy; </td>\n        </tr>\n      </table>\n    </td>\n  </tr>\n</table>");
                TempData["SuccessMesseage"] = "Booking complete please save bill infomation";
                BookingBill.DoneBooking = true;
                Hotel.NumberOfBooking = Hotel.NumberOfBooking + 1;
                context.Update(BookingBill);
                context.Update(Hotel);
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