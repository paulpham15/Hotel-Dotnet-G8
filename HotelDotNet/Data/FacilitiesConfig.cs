using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelDotNet.Data
{
    internal class FacilitiesConfig : IEntityTypeConfiguration<Facilities>
    {
        public void Configure(EntityTypeBuilder<Facilities> builder)
        {
            builder.HasData(
                 new Facilities
                 {
                     Id = 6,
                     Title = "Safe in all rooms"
                 },
                new Facilities
                {
                    Id= 1,
                    Title= "Air conditioned"
                },
                new Facilities
                {
                    Id = 2,
                    Title = "Sea View"
                },
                new Facilities
                {
                    Id = 3,
                    Title = "King Size Bed"
                },
                new Facilities
                {
                    Id = 4,
                    Title = "Microwave"
                },
                new Facilities
                {
                    Id = 5,
                    Title = "Mini Bar"
                }

                );
        }
    }
}