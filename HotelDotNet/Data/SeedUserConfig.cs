using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelDotNet.Data
{
    public class SeedUserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();
            builder.HasData(
                 new User
                 {
                     Id = "408aa945-3d84-4421-8342-7269ec64d949",
                     Email = "admin@localhost.com",
                     NormalizedEmail = "ADMIN@LOCALHOST.COM",
                     NormalizedUserName = "ADMIN@LOCALHOST.COM",
                     UserName = "admin@localhost.com",
                     Firstname = "System",
                     Lastname = "Admin",
                     PasswordHash = hasher.HashPassword(null, "admin"),
                     EmailConfirmed = true
                 },
                 new User
                 {
                     Id = "3f4631bd-f907-4409-b416-ba356312e659",
                     Email = "user@localhost.com",
                     NormalizedEmail = "USER@LOCALHOST.COM",
                     NormalizedUserName = "USER@LOCALHOST.COM",
                     UserName = "user@localhost.com",
                     Firstname = "System",
                     Lastname = "User",
                     PasswordHash = hasher.HashPassword(null, "admin"),
                     EmailConfirmed = true
                 }
            );
        }
    }
}