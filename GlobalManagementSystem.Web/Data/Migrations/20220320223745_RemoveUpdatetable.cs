using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalManagementSystem.Web.Data.Migrations
{
    public partial class RemoveUpdatetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UpdateInventorys");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d769d12-1154-4414-829c-b8077967e0c9", "AQAAAAEAACcQAAAAEPuLyKhV2SK1azPkptYdmBOg47ncl92HCZoS5x4Slbb/6guMphwZ+ju39p25jbdrWg==", "04b09e46-10e8-4163-9031-16b7e4067976" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb8547af-bd4d-485c-b761-a200dd49fa9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dadd5548-9746-4c9b-bdc8-bce2783a5e6e", "AQAAAAEAACcQAAAAEJmW3UnonRh+XHoyF+TVnSDqowPaKEAUhTgotDJBH/7E15rydNCROTUL2X73wqOXVA==", "f6edb972-5da4-4e34-8f14-2c40fbe38b43" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UpdateInventorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateInventorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpdateInventorys_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpdateInventorys_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpdateInventorys_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpdateInventorys_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UpdateInventorys_BrandId",
                table: "UpdateInventorys",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateInventorys_ModelId",
                table: "UpdateInventorys",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateInventorys_ProductId",
                table: "UpdateInventorys",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateInventorys_ProductTypeId",
                table: "UpdateInventorys",
                column: "ProductTypeId");
        }
    }
}
