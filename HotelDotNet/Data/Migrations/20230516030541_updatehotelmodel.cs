using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class updatehotelmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfRoom",
                table: "HotelVM");

            migrationBuilder.AddColumn<string>(
                name: "HotelPicture",
                table: "HotelVM",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HotelPicture",
                table: "HotelVM");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRoom",
                table: "HotelVM",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
