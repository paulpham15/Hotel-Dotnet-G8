using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class adbookingID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookingId",
                table: "Booking",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "2785ab49-d68c-4756-bf89-8e23eb87cc1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "6f820e46-0c27-4087-adb8-2744819cb57c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f7a4ae2-a35d-43bc-a3dc-6f8c74d3ea3e", "AQAAAAEAACcQAAAAED27s/BKM6RwGsxMIDv/Mkn0tfAaTfngl+vo6xUMgHvezPNoa4BCRlHHH/lKe+GfTw==", "5bdcd8fc-286c-4339-bc6f-1691605eeec3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d87f8bb6-ebbc-4045-934d-d0fb723dac22", "AQAAAAEAACcQAAAAEEypInQxkkN6eNxMxxRLYQo+uBujizDEepuM2Fd6z+/lIsq9YVJpMKDMiUJkkwiYsQ==", "5acde9d9-f343-48c5-8801-9fc227043879" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Booking");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "ebe028be-d7a1-4aef-9e65-8cb0d6e286a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "3ee617cd-1b78-4da8-8fdb-fde6cf0b1f2c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "351f675d-a099-4789-9b19-c53be50f2499", "AQAAAAEAACcQAAAAEAi/qrwmCVC9cZVN4YRgWgZN6Ve4ZkpXYrRXONBVsoVxU2/nsXh8nKhX5AmFUfwF6g==", "d246ccaa-b8c9-46fb-8c10-a4f8b45f7e4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "636aca72-50a8-4b07-9504-2f20c761a3bb", "AQAAAAEAACcQAAAAEAvVUl63NfTan11o8kK3IgJONBedNnZGoNZ7jLgiNxnXFSbUvtjulsF4x8kEU7fC8A==", "4e620248-22cd-433e-8cff-4917a7e7f255" });
        }
    }
}
