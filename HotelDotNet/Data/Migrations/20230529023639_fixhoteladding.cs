using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class fixhoteladding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfBooking",
                table: "Hotels",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "hotelAvail",
                table: "Hotels",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfBooking",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "hotelAvail",
                table: "Hotels");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "c6e6c629-6d55-4aac-b478-6d011b85c35a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "b0f3d8e1-29fc-419c-a16c-225a53f60326");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0961f3af-cb89-466a-b59e-8a29ff324cb6", "AQAAAAEAACcQAAAAEA1gL+1aeXQEGS2w68ib4+lXVt3xA5rJ/pr9jLAhxAWfRVV28qvjVRu581/23Kc4LQ==", "7c9f2fa3-2b52-48a4-ba79-b97badc30dda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8352e79f-74d0-4aa3-b318-48a4f639cf4b", "AQAAAAEAACcQAAAAEOArP248mhmPC/PkOlZjKVam8M+xlbS9WGd33Fbkpy2wRvL8DH/m6o4AOHUIwiUOeA==", "31de5ef8-1c61-4639-aead-dd7eef1fe9ad" });
        }
    }
}
