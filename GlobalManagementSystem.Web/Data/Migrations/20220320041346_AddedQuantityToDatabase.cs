using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalManagementSystem.Web.Data.Migrations
{
    public partial class AddedQuantityToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QTY",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eae8547af - bd5d - 475a - b777 - a200bd49fe9a",
                column: "ConcurrencyStamp",
                value: "5d63a7f3-e5f9-4446-9f1f-5a1d18fd9d91");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed8547af - bd5d - 485c - b717 - a200dd49fa9a",
                column: "ConcurrencyStamp",
                value: "0b621d17-0bb2-4f2c-b3d0-f69af7cf9f09");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02121aa8-c53e-461f-aa80-870381474d56",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0813418-472c-4ebf-9276-2b2f7c085108", "AQAAAAEAACcQAAAAEGfr4r8t6e1KGIEGu5HP9Ddr+OyASmvL0nmS5C1Q2RTQ0CkXfnt2Y7as6oqpIw21zw==", "a32f9ac4-ce9b-4423-89f0-1465a409cd72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb8547af-bd4d-485c-b761-a200dd49fa9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2380fc36-33a7-471b-b8b3-34f3d25b3d9c", "AQAAAAEAACcQAAAAEL8a6m4f/+gHrNc0+3lwn7Ib6vy1JDSLl4kGA6jEh8Chf9JVR93qS0TDzJFZfZ0pTw==", "6d1d681c-9131-4ec8-bb91-59cef5afc72d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QTY",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eae8547af - bd5d - 475a - b777 - a200bd49fe9a",
                column: "ConcurrencyStamp",
                value: "cf50c004-8854-4074-8d11-eea334be13d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed8547af - bd5d - 485c - b717 - a200dd49fa9a",
                column: "ConcurrencyStamp",
                value: "c88f9709-11bb-4a68-9178-0203f01af7c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02121aa8-c53e-461f-aa80-870381474d56",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d760ffa8-9d72-4a4f-8e30-a7f6737d3c0d", "AQAAAAEAACcQAAAAELlhXKzSZbXN20VRYY79CvWXCiaw6/P3M1sxXwUq+x0/Fpgw3eOfPFxWIelYMlOxCg==", "8a47e094-26a9-4e79-808e-5a569de7284b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb8547af-bd4d-485c-b761-a200dd49fa9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66997a6e-a85b-4968-a7ab-74c4925f0201", "AQAAAAEAACcQAAAAEGZRHWN2cH1z6aegVf/H9YS59n0+E7pIhTKk1j8u0Qq0Ez8kG88HSe17Wz1ltf7Ckw==", "9becbf5b-b747-4a0a-ab6a-1c802e71931b" });
        }
    }
}
