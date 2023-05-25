using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelDotNet.Data
{
    internal class SeedLocationConfig : IEntityTypeConfiguration<HotelLocation>
    {
        public void Configure(EntityTypeBuilder<HotelLocation> builder)
        {
            builder.HasData(
           new HotelLocation
           {
               Id = 1,
               Name = "HCM",

           },
            new HotelLocation
            {
                Id = 2,
                Name ="HN"

            },
            new HotelLocation
            {
                Id = 3,
                Name = "DN"

            }
            );
        }
    }
}