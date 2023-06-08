using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class adddatebooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateCheckIn",
                table: "Booking",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "bffb8942-5ece-4d6d-bd97-43ea24f7bf0d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "db0d84ab-3cf7-4df5-8847-65b6f08f3f13");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b6cce01-d9a9-4749-a70f-313291210142", "AQAAAAEAACcQAAAAELbXp6ulrDaUZvf9nyIR1T/FpNogfFynP+phx0uBrpHkyCj1iIs2DBJy/qjavqY17A==", "9c87bcd9-15ed-4713-a3a6-cf606aecd83a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58ada3d3-dd75-452d-bac3-921c5dc6180a", "AQAAAAEAACcQAAAAEIuXo6mGWHS1nf33sEA4wTH0gsxW22DHUoIkIr01YKr9VmhXnFHbyOxD23fYNMBZUA==", "10a363c0-aaf4-4f0d-a02d-1dfb2e2ce421" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCheckIn",
                table: "Booking");

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
    }
}
