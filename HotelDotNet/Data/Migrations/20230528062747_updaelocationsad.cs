using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelDotNet.Data.Migrations
{
    public partial class updaelocationsad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Hotels",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Hotels",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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
        }
    }
}
