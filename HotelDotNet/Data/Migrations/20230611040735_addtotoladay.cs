using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class addtotoladay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalDay",
                table: "Booking",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "86b0665d-e020-4a41-b16f-fcddb20f24f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "fa68f21f-fc67-4b27-9860-b3d1fa8ae7f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88cfc40a-a0e3-49d0-8ee5-a4d541152773", "AQAAAAEAACcQAAAAEMZteIyyP0FMHJvbjEFyJuTvZb/vPan/Rps8T4EFVbUEQiy37Fi8vjLP6ZHZdPTZBA==", "4a872af8-44c4-47b7-937e-21e7c761c9a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2b68162-6969-471b-a98b-bdf0bac2da3f", "AQAAAAEAACcQAAAAEHtcBr8CVtXQo+8PoYXZKiA1WGyDtaLz5ntmv8jRHKWqKXA3I92vgM0SzEothUxh4A==", "eeb8162d-aa74-4b33-8ca6-d4bd09ab6b90" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalDay",
                table: "Booking");

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
    }
}
