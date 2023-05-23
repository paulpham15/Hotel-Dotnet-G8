using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class newkeyasdz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacilitiesId",
                table: "RoomFacilities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacilitiesId",
                table: "RoomFacilities",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
