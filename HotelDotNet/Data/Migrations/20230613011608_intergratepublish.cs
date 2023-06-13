using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class intergratepublish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b39992ed-9f28-4c29-8586-8f055784d9cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "51dea7c9-ac4b-428a-8084-49b1497e9946");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a83da9b-3131-430c-96b8-cfb1fc4abc33", "AQAAAAEAACcQAAAAEM+xWQr0zs9a5Y4rNVZBnCF2DLI8DWu5Hjp5SQEJRPOOowm42mPZ2YNRrn82LEWSkA==", "fd7b6aba-ace8-41ed-a2e7-5fe5b2c82897" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac7aa33e-a2ee-413b-9279-86f16f9aa63c", "AQAAAAEAACcQAAAAECc/ufCf31zFrIs3Im8Ilsmv0u/+ohq5uP0krI4iwIHUVz+rLDkpy86oEKIizZjMaA==", "7aa93ecb-06fa-476e-9dd9-152b564f9344" });
        }
    }
}
