using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalManagementSystem.Web.Data.Migrations
{
    public partial class AddedAuditingDateCeatedAndDateModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEnded",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Datestarted",
                table: "Brands");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "aa00291b-3bc6-4d8c-93e5-ddcb4b25c41e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eba7548ff-da7d-475a-b17c-a200ad79f77a",
                column: "ConcurrencyStamp",
                value: "518f47a9-d8ff-484e-ad90-a5e33383dbca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f127aa8-a53b-471f-ab80-877381474d56",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0543be4-c8a0-4789-9e40-2a3c75d226c2", "AQAAAAEAACcQAAAAEPJXMSh6g/uCERBmcREnbCjY5mTUQLZXK0CuN8u1qGMWYLRL/FD7dh5LNgb8uNKgxw==", "d2d89258-d1fc-4115-8da7-560ba739dd25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef7547bf-bd4d-485c-b761-a211dd47fa9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69cd1373-fec0-4845-bb42-352637353e77", "AQAAAAEAACcQAAAAEH8oT531wuIdGY+VGd/q1hC+ufqo9mwnMi3JiMh3OQ1GZUybf8aB0Nf0tIoc348N7Q==", "ac17ad0b-7c1a-40e6-b9fd-b2927d5547cc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnded",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Datestarted",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b97dff5a-c6ef-4858-aa7d-35ec0d6586b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eba7548ff-da7d-475a-b17c-a200ad79f77a",
                column: "ConcurrencyStamp",
                value: "3cf57165-5843-411b-9fef-80adbf08f258");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f127aa8-a53b-471f-ab80-877381474d56",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "196e14fd-da91-454e-a38f-0cee7e1d3b4a", "AQAAAAEAACcQAAAAENizBYDd79PocbJ8/uztaIoofWh3EuTLcRam4OPFjAVhx0t8p8YLupzQxeFIs3yF8g==", "d080b57f-5943-444f-936e-b456aa5ca95e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef7547bf-bd4d-485c-b761-a211dd47fa9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae85b31f-9c8f-407f-9204-b2e725e6e7e5", "AQAAAAEAACcQAAAAED1Y0sD5lgEfD9owyqFGG74yO4Kp2QO20PTQ+13zPg5ZuQxutHpEtvio2h96fAvndg==", "f80df353-ff32-47d1-9f4c-d112b9e513ea" });
        }
    }
}
