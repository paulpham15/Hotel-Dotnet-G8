using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class newufctions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomAllocations_Facilities_FacilitiesId",
                table: "RoomAllocations");

            migrationBuilder.DropIndex(
                name: "IX_RoomAllocations_FacilitiesId",
                table: "RoomAllocations");

            migrationBuilder.DropColumn(
                name: "FacilitiesId",
                table: "RoomAllocations");

            migrationBuilder.AddColumn<int>(
                name: "FacilitiesId",
                table: "RoomFacilities",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomAllocationId",
                table: "Facilities",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomFacilities_FacilitiesId",
                table: "RoomFacilities",
                column: "FacilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Facilities_RoomAllocationId",
                table: "Facilities",
                column: "RoomAllocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facilities_RoomAllocations_RoomAllocationId",
                table: "Facilities",
                column: "RoomAllocationId",
                principalTable: "RoomAllocations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomFacilities_Facilities_FacilitiesId",
                table: "RoomFacilities",
                column: "FacilitiesId",
                principalTable: "Facilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facilities_RoomAllocations_RoomAllocationId",
                table: "Facilities");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomFacilities_Facilities_FacilitiesId",
                table: "RoomFacilities");

            migrationBuilder.DropIndex(
                name: "IX_RoomFacilities_FacilitiesId",
                table: "RoomFacilities");

            migrationBuilder.DropIndex(
                name: "IX_Facilities_RoomAllocationId",
                table: "Facilities");

            migrationBuilder.DropColumn(
                name: "FacilitiesId",
                table: "RoomFacilities");

            migrationBuilder.DropColumn(
                name: "RoomAllocationId",
                table: "Facilities");

            migrationBuilder.AddColumn<int>(
                name: "FacilitiesId",
                table: "RoomAllocations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RoomAllocations_FacilitiesId",
                table: "RoomAllocations",
                column: "FacilitiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomAllocations_Facilities_FacilitiesId",
                table: "RoomAllocations",
                column: "FacilitiesId",
                principalTable: "Facilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
