using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelDotNet.Data
{
    public class RoomTypeConfig : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.HasData(
                new RoomType
                {
                    Id=2,
                    Title="Standard",
                },
                 new RoomType
                 {
                    Id = 1,
                    Title = "Suite",
                },
                  new RoomType
                {
                     Id = 3,
                     Title = "Deluxe",
                },
                  new RoomType
                {
                      Id = 4,
                      Title = "Junior Suite",
                },
                    new RoomType
                    {
                        Id = 5,
                        Title = "Suite",
                    }
                );
        }
    }
}