using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalManagementSystem.Web.Data.Migrations
{
    public partial class UpdateTheUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eae8547af - bd5d - 475a - b777 - a200bd49fe9a",
                column: "ConcurrencyStamp",
                value: "e7f291ed-4344-47e9-958a-1f7434892d07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed8547af - bd5d - 485c - b717 - a200dd49fa9a",
                column: "ConcurrencyStamp",
                value: "7812f5f5-7556-4e7b-9ac9-bc9fb051fbe6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02121aa8-c53e-461f-aa80-870381474d56",
                columns: new[] { "ConcurrencyStamp", "Firstname", "Lastname", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b59e9487-b324-41d0-8c14-43c934de9287", "User", "User", "AQAAAAEAACcQAAAAEKXsYyR/tVrSpzWtNRc+0yKUKJnhmVR+lrMzvsXmng0DYlbbnutGJkIterm8cPQ6Pw==", "5ca6df3d-18bf-4b27-8967-8db77f355c7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb8547af-bd4d-485c-b761-a200dd49fa9a",
                columns: new[] { "ConcurrencyStamp", "Firstname", "Lastname", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be644554-7096-48d0-983d-f4ea02f1331b", "Admin", "Admin", "AQAAAAEAACcQAAAAEIpjECy7ptqiltwKIc1Udiz0RZn68Zp7tQvJKfVxPo4aOJyskE0XUtiyLCxbaOhiDg==", "79560318-3ad2-44ec-9947-914b4442b278" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eae8547af - bd5d - 475a - b777 - a200bd49fe9a",
                column: "ConcurrencyStamp",
                value: "bd19316c-64da-4333-be3f-0bc818a62dcf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed8547af - bd5d - 485c - b717 - a200dd49fa9a",
                column: "ConcurrencyStamp",
                value: "763653fa-1939-4064-96d5-487f2f1babe9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02121aa8-c53e-461f-aa80-870381474d56",
                columns: new[] { "ConcurrencyStamp", "Firstname", "Lastname", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d769d12-1154-4414-829c-b8077967e0c9", "user", "user", "AQAAAAEAACcQAAAAEPuLyKhV2SK1azPkptYdmBOg47ncl92HCZoS5x4Slbb/6guMphwZ+ju39p25jbdrWg==", "04b09e46-10e8-4163-9031-16b7e4067976" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb8547af-bd4d-485c-b761-a200dd49fa9a",
                columns: new[] { "ConcurrencyStamp", "Firstname", "Lastname", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dadd5548-9746-4c9b-bdc8-bce2783a5e6e", "admin", "admin", "AQAAAAEAACcQAAAAEJmW3UnonRh+XHoyF+TVnSDqowPaKEAUhTgotDJBH/7E15rydNCROTUL2X73wqOXVA==", "f6edb972-5da4-4e34-8f14-2c40fbe38b43" });
        }
    }
}
