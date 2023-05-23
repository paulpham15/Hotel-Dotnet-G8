using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class dsxa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacilitiesId",
                table: "RoomAllocations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "Air conditioned" });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "Title" },
                values: new object[] { 2, "Sea View" });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "Title" },
                values: new object[] { 3, "King Size Bed" });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "Title" },
                values: new object[] { 4, "Microwave" });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "Title" },
                values: new object[] { 5, "Mini Bar" });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "Title" },
                values: new object[] { 6, "Safe in all rooms" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "FacilitiesId",
                table: "RoomAllocations");
        }
    }
}
