using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalManagementSystem.Web.Data.Migrations
{
    public partial class AddedUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eae8547af - bd5d - 475a - b777 - a200bd49fe9a", "02121aa8-c53e-461f-aa80-870381474d56" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed8547af - bd5d - 485c - b717 - a200dd49fa9a", "eb8547af-bd4d-485c-b761-a200dd49fa9a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eae8547af - bd5d - 475a - b777 - a200bd49fe9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed8547af - bd5d - 485c - b717 - a200dd49fa9a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02121aa8-c53e-461f-aa80-870381474d56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb8547af-bd4d-485c-b761-a200dd49fa9a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "8751664d-0401-4d20-98e4-59e3561665b6", "Administrator", "ADMINISTRATOR" },
                    { "eba7548ff-da7d-475a-b17c-a200ad79f77a", "c1cf7c92-9bb5-446e-aaf6-f2291d9297d2", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DateEnded", "DateOfBirth", "Datestarted", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NIS", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TRN", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0f127aa8-a53b-471f-ab80-877381474d56", 0, null, "4476d062-e57a-4589-be84-a035ab5536f2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "User", "User", false, null, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEP3QG3BAzYVGjb9QN3oeXSL2ElPLBm3Hoya7l0JK9lpMB8UtY332VjGNzi+dnjmbtQ==", null, null, false, "1f384c26-4396-4b32-908f-b227af79c451", null, false, "user@localhost.com" },
                    { "ef7547bf-bd4d-485c-b761-a211dd47fa9a", 0, null, "d25793fe-0c78-4cc9-9af0-8839caa72231", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "Admin", "Admin", false, null, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAENh1syqo4crE97mqnh9GQdv5QNTJFPUdfN3vGpbg3FA1PU5U/3axivglLLarrIKphg==", null, null, false, "58a6d1d2-f7df-40fc-af12-185734cd18ce", null, false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eba7548ff-da7d-475a-b17c-a200ad79f77a", "0f127aa8-a53b-471f-ab80-877381474d56" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "ef7547bf-bd4d-485c-b761-a211dd47fa9a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eba7548ff-da7d-475a-b17c-a200ad79f77a", "0f127aa8-a53b-471f-ab80-877381474d56" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "ef7547bf-bd4d-485c-b761-a211dd47fa9a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eba7548ff-da7d-475a-b17c-a200ad79f77a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f127aa8-a53b-471f-ab80-877381474d56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef7547bf-bd4d-485c-b761-a211dd47fa9a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "eae8547af - bd5d - 475a - b777 - a200bd49fe9a", "e7f291ed-4344-47e9-958a-1f7434892d07", "User", "USER" },
                    { "ed8547af - bd5d - 485c - b717 - a200dd49fa9a", "7812f5f5-7556-4e7b-9ac9-bc9fb051fbe6", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DateEnded", "DateOfBirth", "Datestarted", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NIS", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TRN", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02121aa8-c53e-461f-aa80-870381474d56", 0, null, "b59e9487-b324-41d0-8c14-43c934de9287", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "User", "User", false, null, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKXsYyR/tVrSpzWtNRc+0yKUKJnhmVR+lrMzvsXmng0DYlbbnutGJkIterm8cPQ6Pw==", null, null, false, "5ca6df3d-18bf-4b27-8967-8db77f355c7e", null, false, "user@localhost.com" },
                    { "eb8547af-bd4d-485c-b761-a200dd49fa9a", 0, null, "be644554-7096-48d0-983d-f4ea02f1331b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "Admin", "Admin", false, null, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEIpjECy7ptqiltwKIc1Udiz0RZn68Zp7tQvJKfVxPo4aOJyskE0XUtiyLCxbaOhiDg==", null, null, false, "79560318-3ad2-44ec-9947-914b4442b278", null, false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eae8547af - bd5d - 475a - b777 - a200bd49fe9a", "02121aa8-c53e-461f-aa80-870381474d56" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ed8547af - bd5d - 485c - b717 - a200dd49fa9a", "eb8547af-bd4d-485c-b761-a200dd49fa9a" });
        }
    }
}
