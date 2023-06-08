using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HotelDotNet.Data;
using HotelDotNet.Configurations;
using HotelDotNet.Contracts;
using HotelDotNet.Respositories;
using HotelDotNet.Settings;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var mailSetting = builder.Configuration.GetSection("MailSettings");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.AddAutoMapper(typeof(MapperConfig));
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllersWithViews();
builder.Services.Configure<MailSettings>(mailSetting);
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IRoomAllocationRespository, RoomAllocationResposiory>();
builder.Services.AddScoped<IRoomTypeRespository, RoomTypeRepository>();
builder.Services.AddScoped<IRoomRespository, RoomRepository>();
builder.Services.AddScoped<IHotelRespository, HotelResposiory>();
builder.Services.AddScoped<IBookingRespository, BookingRepository>();
builder.Services.AddScoped<IRoomFacilitiesRespository, RoomFacilitiesRepository>();
var app = builder.Build();
app.UseStatusCodePagesWithReExecute("/Error/Index", "?statusCode={0}");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "admin/{controller=Dashboard}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=HomePage}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

