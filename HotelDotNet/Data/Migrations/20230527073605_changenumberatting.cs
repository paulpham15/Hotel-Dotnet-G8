using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class changenumberatting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a1ffb3bd-c69a-4f00-9e1f-847bc915e026");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "e1162337-e0d8-4871-a1c7-4490019c00db");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "940f6f4d-8c72-4574-9c72-694b0774f39d", "AQAAAAEAACcQAAAAEGx6AzNP+QQOzGm00M+9j7dpj4Mg+VPusDgjZIgLJmgfw7KQG/ocexQPZN0Nvfv1IA==", "3e2e6987-18d3-4658-9c5a-df1b4716e7cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "615aee11-b509-4f65-830b-aeaa6fe0d091", "AQAAAAEAACcQAAAAEHXjnuLcAwTyErNv0Y+EKvq1VFrDN8hMpmIDQRPeJYI0PpeMAL+MP7Oa3yVFvNLlkg==", "33d38c65-5d23-4476-afd9-9ee5bd491ccf" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "HCM" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "HN" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "DN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a0c9e3f9-56e1-4150-a7b9-479b5a891ea2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "b4d6af1b-1978-46d8-a4ed-fd341820e965");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "516ca9ee-e181-4dbd-a788-05dbd446fb2c", "AQAAAAEAACcQAAAAEFiM1lP7du/TPCj5dSAwYDCVTSE2jMIu2dTbuZb0W9eMPoNRel+i3R61hkLIWwK6Gw==", "59719a0e-7898-4df3-bca3-8c1ceedc2c16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8c63d57-aff2-4680-bca5-2ad6ed04c367", "AQAAAAEAACcQAAAAEPUYKhqeFx+c0kSu+Dt3qAiHiiPE4wwWSJXbCiYdVuBdEZu4YH6y2T6q4hiZXlQhig==", "08914c02-8701-42ae-8b7c-2bdf4f5a0fb2" });
        }
    }
}
