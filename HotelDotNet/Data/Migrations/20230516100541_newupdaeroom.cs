using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class newupdaeroom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomAllocatios_RoomTypes_RoomTypeId",
                table: "RoomAllocatios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomAllocatios",
                table: "RoomAllocatios");

            migrationBuilder.RenameTable(
                name: "RoomAllocatios",
                newName: "RoomAllocations");

            migrationBuilder.RenameIndex(
                name: "IX_RoomAllocatios_RoomTypeId",
                table: "RoomAllocations",
                newName: "IX_RoomAllocations_RoomTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomAllocations",
                table: "RoomAllocations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomAllocations_RoomTypes_RoomTypeId",
                table: "RoomAllocations",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomAllocations_RoomTypes_RoomTypeId",
                table: "RoomAllocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomAllocations",
                table: "RoomAllocations");

            migrationBuilder.RenameTable(
                name: "RoomAllocations",
                newName: "RoomAllocatios");

            migrationBuilder.RenameIndex(
                name: "IX_RoomAllocations_RoomTypeId",
                table: "RoomAllocatios",
                newName: "IX_RoomAllocatios_RoomTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomAllocatios",
                table: "RoomAllocatios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomAllocatios_RoomTypes_RoomTypeId",
                table: "RoomAllocatios",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
