using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class fixxingtablebooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalClient",
                table: "Booking",
                newName: "TotalPeople");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalPeople",
                table: "Booking",
                newName: "TotalClient");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "8a2d59c7-0651-4f80-a84f-7a15c80ac487");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "005ac0fd-11c5-4fdc-847d-fd666b141de7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74697f20-d3c8-41c7-b429-be6bc01c47da", "AQAAAAEAACcQAAAAEPcG1Q2wP2xn7OaeGbfqiqp2Xt7XkMdAlkf9xnEo9oKB2QXA3Rdl16FAVmXOd4anmg==", "7b5e4703-d699-4760-ac2c-ed2232e0e375" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dedf4176-bdf9-43b5-8672-2e8ce4d0e426", "AQAAAAEAACcQAAAAEAgKyu11mKuoX5kOuUZAMcfapgsG8oDsI5AXNLYOlAaSrGujO6mshEwEFuA4x6M3Mw==", "d92f93bf-c602-4b93-b2f2-a4afb8143611" });
        }
    }
}
