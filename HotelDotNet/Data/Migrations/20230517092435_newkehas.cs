using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class newkehas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomAllocations_Facilities_FacilityId",
                table: "RoomAllocations");

            migrationBuilder.DropIndex(
                name: "IX_RoomAllocations_FacilityId",
                table: "RoomAllocations");

            migrationBuilder.DropColumn(
                name: "FacilityId",
                table: "RoomAllocations");

            migrationBuilder.AlterColumn<int>(
                name: "FacilitiesId",
                table: "RoomAllocations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomAllocations_Facilities_FacilitiesId",
                table: "RoomAllocations");

            migrationBuilder.DropIndex(
                name: "IX_RoomAllocations_FacilitiesId",
                table: "RoomAllocations");

            migrationBuilder.AlterColumn<int>(
                name: "FacilitiesId",
                table: "RoomAllocations",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "FacilityId",
                table: "RoomAllocations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RoomAllocations_FacilityId",
                table: "RoomAllocations",
                column: "FacilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomAllocations_Facilities_FacilityId",
                table: "RoomAllocations",
                column: "FacilityId",
                principalTable: "Facilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
