using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class fixlocateon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "3ec92063-93a7-4c73-8446-64d69ed7915e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "f107c917-249e-4dfd-b7e2-de9527a8f165");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acc1d205-90bc-4435-b9e6-82f38f968020", "AQAAAAEAACcQAAAAELnOfw/300Fvf6lKcx6VreY01ISPLhw01ANZhYYdvB5gVAi3/4Y8IeJLAPJBgewfwQ==", "d04e5256-45c3-4d11-8279-59c0f681dc3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dcda1f6-cf7b-4190-b214-3db08ad68e18", "AQAAAAEAACcQAAAAEAyhw+eTwLOIr8+z350/f4+sFvpkwITA3vvgW/2PgpsmGqlSnuRC3Ch3xrhfdoqpvg==", "54e9b982-1a09-4997-aeeb-4832e97c6605" });
        }
    }
}
