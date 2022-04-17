using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalManagementSystem.Web.Data.Migrations
{
    public partial class AddedNameToProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "0c39c0d4-6379-4df0-adb5-1333809caa9c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eba7548ff-da7d-475a-b17c-a200ad79f77a",
                column: "ConcurrencyStamp",
                value: "cce55787-c459-4d90-b348-4a298077f1dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f127aa8-a53b-471f-ab80-877381474d56",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc2d6abc-1223-4fe4-98f1-81942b1162b6", "AQAAAAEAACcQAAAAEAxUBfNmisU3Zu6x7C2URtNKbIM2VtHVLNLko7kmAoLfyoHup5gts15ktRe8oqd3CA==", "615f993c-789e-4666-bca5-96fad4a6b9ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef7547bf-bd4d-485c-b761-a211dd47fa9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0743b45-e90f-40c1-b046-3250bcbba614", "AQAAAAEAACcQAAAAEPmmJlI3lm0q17HWiWNi7+zBknPmq+qPUukrSIfn9//9KX/aQVnPDNY7AdKmOp8apQ==", "0716be9b-5561-4d83-92ae-515c82254db7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

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
    }
}
