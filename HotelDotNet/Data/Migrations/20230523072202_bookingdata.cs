using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class bookingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomAllocations_RoomTypes_RoomTypeId",
                table: "RoomAllocations");

            migrationBuilder.AlterColumn<int>(
                name: "RoomTypeId",
                table: "RoomAllocations",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HotelId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomAllocationId = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalPrice = table.Column<int>(type: "INTEGER", nullable: false),
                    ClientId = table.Column<string>(type: "TEXT", nullable: false),
                    ClientName = table.Column<string>(type: "TEXT", nullable: false),
                    ClientEmail = table.Column<string>(type: "TEXT", nullable: false),
                    ClientPhoneNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalClient = table.Column<int>(type: "INTEGER", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    DoneBooking = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_RoomAllocations_RoomAllocationId",
                        column: x => x.RoomAllocationId,
                        principalTable: "RoomAllocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a0c9e3f9-56e1-4150-a7b9-479b5a891ea2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "b4d6af1b-1978-46d8-a4ed-fd341820e965");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "516ca9ee-e181-4dbd-a788-05dbd446fb2c", "AQAAAAEAACcQAAAAEFiM1lP7du/TPCj5dSAwYDCVTSE2jMIu2dTbuZb0W9eMPoNRel+i3R61hkLIWwK6Gw==", "59719a0e-7898-4df3-bca3-8c1ceedc2c16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8c63d57-aff2-4680-bca5-2ad6ed04c367", "AQAAAAEAACcQAAAAEPUYKhqeFx+c0kSu+Dt3qAiHiiPE4wwWSJXbCiYdVuBdEZu4YH6y2T6q4hiZXlQhig==", "08914c02-8701-42ae-8b7c-2bdf4f5a0fb2" });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_HotelId",
                table: "Booking",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RoomAllocationId",
                table: "Booking",
                column: "RoomAllocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomAllocations_RoomTypes_RoomTypeId",
                table: "RoomAllocations",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomAllocations_RoomTypes_RoomTypeId",
                table: "RoomAllocations");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.AlterColumn<int>(
                name: "RoomTypeId",
                table: "RoomAllocations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "174c2f37-cc76-458e-9a3e-2f57d883a0ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "5b060fae-50e5-465d-a0ce-ea906adf03be");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c256cafc-83f2-4fbc-ba0e-d17fa608d0e2", "AQAAAAEAACcQAAAAEJmyPFEaHQG0CcxPd+LAfw1fpaZX6x3+eyeCD1582EnBzW5OMqLFDsLEsydivPNcCA==", "0c1dfe96-8774-4daa-90df-8a5b7e1cdedf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74f90082-afa6-429b-9bb6-f2dda3a5aee1", "AQAAAAEAACcQAAAAEKvL80A5kR4ni5f2TibXiF+gaMBDcg7RgajjuQVqSFTjPUpf/wrKTbondgEAxer7bA==", "af88761c-a4b5-4cef-a6e4-a62337490db7" });

            migrationBuilder.AddForeignKey(
                name: "FK_RoomAllocations_RoomTypes_RoomTypeId",
                table: "RoomAllocations",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
