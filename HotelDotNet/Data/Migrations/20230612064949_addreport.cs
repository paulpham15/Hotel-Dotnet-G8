using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class addreport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "f1661a0c-74ef-41c9-a6a4-30bf0b3e2525");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "7484ee8e-6a49-4209-970e-b532a70b49d4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97bc5da2-5389-44e3-8c15-cb82b5e30db7", "AQAAAAEAACcQAAAAEKeNZEsWtLo1zufg5EcgUEs1oaHYgzmlkEPFRaKTPNma5uFBY7d6yZ+pJBvmR0P7WA==", "9d83e8a2-0e90-45f6-829d-8b025984e123" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4782a4d8-429e-4036-8ae5-6003e1b66430", "AQAAAAEAACcQAAAAEFB3T0FdQuwCQIBmykgZIzVR498kctoW+2UIH0aEC1UzvOFZFCvP85FXT/JKfHh8CA==", "dd6ba1cb-12db-4cc5-8f7d-a9dd1cde5761" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
