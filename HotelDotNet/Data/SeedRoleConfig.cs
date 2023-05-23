using Microsoft.AspNetCore.Identity;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelDotNet.Data
{
    public class SeedRoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
                {
                Id = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
            new IdentityRole
                {
                    Id = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                    Name = "User",
                    NormalizedName = "USER"
                }
            );
        }
    }
   
}