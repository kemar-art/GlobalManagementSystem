using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalManagementSystem.Web.Data.Migrations
{
    public partial class AddDefaultUsersanAndRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eae8547af - bd5d - 475a - b777 - a200bd49fe9a",
                column: "ConcurrencyStamp",
                value: "e813ec2c-7e1f-4a94-8eaf-066f1f419b94");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed8547af - bd5d - 485c - b717 - a200dd49fa9a",
                column: "ConcurrencyStamp",
                value: "edf89182-e703-4388-b806-f8bc644b9995");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02121aa8-c53e-461f-aa80-870381474d56",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "56dc1f6e-9223-4159-9fc4-689262342efa", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEPvLbM8UH3H1nClse5H3wxVp61GptyD28eEcz+AfRTZGMLFVpMlglO7pamGcBTZhFA==", "e392426b-15e9-450f-a37d-51d14fee14ef", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb8547af-bd4d-485c-b761-a200dd49fa9a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8d6f43ec-8a45-447a-a691-ad43a8c00c35", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAENx2ffSa3nybkXubnFCbbKzPez/ECGFVUTC1wp0KAnnnPQJYIkkZAL3cN8qbvNsWNg==", "e66e4d0d-0507-4d50-b634-34f511ddc8e0", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eae8547af - bd5d - 475a - b777 - a200bd49fe9a",
                column: "ConcurrencyStamp",
                value: "aed6bbbf-db91-4ac2-8dbb-965bd402eef5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed8547af - bd5d - 485c - b717 - a200dd49fa9a",
                column: "ConcurrencyStamp",
                value: "78acf4f4-140d-4565-a451-21d40bd7be05");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02121aa8-c53e-461f-aa80-870381474d56",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c19dc59c-b26e-48cb-bb2e-f74015f9e1f5", false, null, "AQAAAAEAACcQAAAAEJFDOSBxVDCu7SH25bD7Y5xhdO3CaIo3YTNbVVbLOJGawJqiqgHEQN8jj77M1LJcNQ==", "c362d6b2-7b06-4928-b94f-2040c22fdb8e", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb8547af-bd4d-485c-b761-a200dd49fa9a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "28c18c9e-8b7c-4309-a5d5-2eac8483cc5c", false, null, "AQAAAAEAACcQAAAAEBLd9KxCe4UsOqGaU/D6GCwIKMDQDLT7bQPIVXSqVCa5dOfPjri2C43zVVCr3+j7tg==", "23678b68-58c0-4ac8-b675-a60fff6f2e74", null });
        }
    }
}
