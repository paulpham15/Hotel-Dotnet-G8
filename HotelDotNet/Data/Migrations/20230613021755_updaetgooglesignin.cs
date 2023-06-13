using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class updaetgooglesignin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "4388fd44-9857-4d73-b489-b098f854cfca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "76c8f59d-b3bf-4eda-bef0-fa1d51196059");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24ea6239-fb8a-484b-9f5d-ef506e84379e", "AQAAAAEAACcQAAAAEEwkzbizoRjubfPNo54gw8CKXnOUaTcDvkCNJSTML7vp4xoDI2Kwdc0GVU5g63TL+Q==", "72b6b161-1a7c-4ba1-8699-377aed411fb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fcfc413-2ced-45d5-b199-a80b3481a9c7", "AQAAAAEAACcQAAAAEHQen1bwLFRqKUZmJ9QH+zxHgXPY2LxXEcBS4gMxCeXBNYtOCzswGKBIZFwPYBhjuA==", "a26c48be-fba5-45c1-88f0-5e11bcdd5a71" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9467be5d-0530-406e-9b35-e59bc4cdf28f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "aa5009d0-8d72-4198-a4f4-f8c36fb155f3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba43c373-1031-48ae-9c04-4ca051e526a7", "AQAAAAEAACcQAAAAEK92NGW2afXysEKJ8NBoAg7u/yXFn7R5lbFmu1vMH4UfUS6RsLZYmaywR3WengKiBw==", "d1d8744c-21cb-4f7d-8fbf-da7a729a1ad8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fc53fca-74a2-4d81-94c8-85d5852de600", "AQAAAAEAACcQAAAAEFeTy/c7fgX04QFp/sMYwookeY5ur71lPHP4xIdQRW5pDxuhY0ppcqFRSfc8du95iQ==", "247e4140-82cc-4573-9cbd-aeb3ae7e36b2" });
        }
    }
}
