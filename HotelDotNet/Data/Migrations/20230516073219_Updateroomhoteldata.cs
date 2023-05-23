using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class Updateroomhoteldata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureofRoom",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "RoomTypes",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Available",
                table: "RoomAllocatios",
                newName: "Price");

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Rooms",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRoom",
                table: "RoomAllocatios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "RoomAllocatios",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoomName",
                table: "RoomAllocatios",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Hotels",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "Suite" });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Title" },
                values: new object[] { 2, "Standard" });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Title" },
                values: new object[] { 3, "Deluxe" });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Title" },
                values: new object[] { 4, "Junior Suite" });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Title" },
                values: new object[] { 5, "Suite" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "NumberOfRoom",
                table: "RoomAllocatios");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "RoomAllocatios");

            migrationBuilder.DropColumn(
                name: "RoomName",
                table: "RoomAllocatios");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "RoomTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "RoomAllocatios",
                newName: "Available");

            migrationBuilder.AddColumn<string>(
                name: "PictureofRoom",
                table: "Rooms",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Rooms",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Rooms",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Hotels",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
