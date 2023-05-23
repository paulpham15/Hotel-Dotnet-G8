using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class newupdateda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomFacilities_Rooms_RoomId",
                table: "RoomFacilities");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "RoomFacilities",
                newName: "RoomAllocationId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomFacilities_RoomId",
                table: "RoomFacilities",
                newName: "IX_RoomFacilities_RoomAllocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomFacilities_RoomAllocations_RoomAllocationId",
                table: "RoomFacilities",
                column: "RoomAllocationId",
                principalTable: "RoomAllocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomFacilities_RoomAllocations_RoomAllocationId",
                table: "RoomFacilities");

            migrationBuilder.RenameColumn(
                name: "RoomAllocationId",
                table: "RoomFacilities",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomFacilities_RoomAllocationId",
                table: "RoomFacilities",
                newName: "IX_RoomFacilities_RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomFacilities_Rooms_RoomId",
                table: "RoomFacilities",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
