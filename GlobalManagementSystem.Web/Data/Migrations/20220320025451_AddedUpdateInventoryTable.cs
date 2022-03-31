using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalManagementSystem.Web.Data.Migrations
{
    public partial class AddedUpdateInventoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UpdateInventorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateInventorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpdateInventorys_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateInventorys_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateInventorys_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateInventorys_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UpdateInventorys");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56dc1f6e-9223-4159-9fc4-689262342efa", "AQAAAAEAACcQAAAAEPvLbM8UH3H1nClse5H3wxVp61GptyD28eEcz+AfRTZGMLFVpMlglO7pamGcBTZhFA==", "e392426b-15e9-450f-a37d-51d14fee14ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb8547af-bd4d-485c-b761-a200dd49fa9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d6f43ec-8a45-447a-a691-ad43a8c00c35", "AQAAAAEAACcQAAAAENx2ffSa3nybkXubnFCbbKzPez/ECGFVUTC1wp0KAnnnPQJYIkkZAL3cN8qbvNsWNg==", "e66e4d0d-0507-4d50-b634-34f511ddc8e0" });
        }
    }
}
