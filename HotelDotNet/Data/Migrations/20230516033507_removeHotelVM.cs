using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class removeHotelVM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Rooms_RoomId",
                table: "Hotels");

            migrationBuilder.DropTable(
                name: "HotelVM");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_RoomId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Hotels");

            migrationBuilder.AlterColumn<string>(
                name: "HotelPicture",
                table: "Hotels",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HotelPicture",
                table: "Hotels",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Hotels",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "HotelVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HotelPicture = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelVM", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_RoomId",
                table: "Hotels",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Rooms_RoomId",
                table: "Hotels",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
