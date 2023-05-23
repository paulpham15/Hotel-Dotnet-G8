using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HotelDotNet.Models;

namespace HotelDotNet.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoomTypeConfig());
            builder.ApplyConfiguration(new FacilitiesConfig());
            builder.ApplyConfiguration(new SeedRoleConfig());
            builder.ApplyConfiguration(new SeedUserConfig());
            builder.ApplyConfiguration(new SeedUserRoleConfig());
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomFacilities> RoomFacilities { get; set; }
        public DbSet<RoomAllocation> RoomAllocations { get; set; }
        public DbSet<Facilities> Facilities { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<Booking> Booking { get; set; }
    }
    }