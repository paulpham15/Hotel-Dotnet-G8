using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class addreporting3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");

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
    }
}
