using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFeature_Products_ProductId",
                table: "ProductFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductFeature",
                table: "ProductFeature");

            migrationBuilder.RenameTable(
                name: "ProductFeature",
                newName: "ProductFeatures");

            migrationBuilder.RenameIndex(
                name: "IX_ProductFeature_ProductId",
                table: "ProductFeatures",
                newName: "IX_ProductFeatures_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductFeatures",
                table: "ProductFeatures",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 15, 32, 44, 185, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 15, 32, 44, 185, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 15, 32, 44, 185, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFeatures_Products_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFeatures_Products_ProductId",
                table: "ProductFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductFeatures",
                table: "ProductFeatures");

            migrationBuilder.RenameTable(
                name: "ProductFeatures",
                newName: "ProductFeature");

            migrationBuilder.RenameIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeature",
                newName: "IX_ProductFeature_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductFeature",
                table: "ProductFeature",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 23, 15, 30, 46, 473, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 23, 15, 30, 46, 473, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 23, 15, 30, 46, 473, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFeature_Products_ProductId",
                table: "ProductFeature",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
