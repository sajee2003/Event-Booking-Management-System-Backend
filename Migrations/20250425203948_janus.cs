using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventBookingManagementSystem_Backend.Migrations
{
    /// <inheritdoc />
    public partial class janus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Item_Asset_AssetId",
                table: "Asset_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Asset_Asset_AssetId",
                table: "Booking_Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Price_Asset_assetId",
                table: "Item_Price");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Price_Item_ItemId",
                table: "Item_Price");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_Items_Asset_AssetId",
                table: "Package_Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item_Price",
                table: "Item_Price");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Asset",
                table: "Asset");

            migrationBuilder.RenameTable(
                name: "Item_Price",
                newName: "ItemPrices");

            migrationBuilder.RenameTable(
                name: "Asset",
                newName: "Assets");

            migrationBuilder.RenameIndex(
                name: "IX_Item_Price_ItemId",
                table: "ItemPrices",
                newName: "IX_ItemPrices_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_Price_assetId",
                table: "ItemPrices",
                newName: "IX_ItemPrices_assetId");

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidFrom",
                table: "ItemPrices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidTo",
                table: "ItemPrices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "ItemPrices",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemPrices",
                table: "ItemPrices",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets",
                table: "Assets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Item_Assets_AssetId",
                table: "Asset_Item",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Asset_Assets_AssetId",
                table: "Booking_Asset",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPrices_Assets_assetId",
                table: "ItemPrices",
                column: "assetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPrices_Item_ItemId",
                table: "ItemPrices",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Package_Items_Assets_AssetId",
                table: "Package_Items",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Item_Assets_AssetId",
                table: "Asset_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Asset_Assets_AssetId",
                table: "Booking_Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPrices_Assets_assetId",
                table: "ItemPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPrices_Item_ItemId",
                table: "ItemPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_Items_Assets_AssetId",
                table: "Package_Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemPrices",
                table: "ItemPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "ValidFrom",
                table: "ItemPrices");

            migrationBuilder.DropColumn(
                name: "ValidTo",
                table: "ItemPrices");

            migrationBuilder.DropColumn(
                name: "price",
                table: "ItemPrices");

            migrationBuilder.RenameTable(
                name: "ItemPrices",
                newName: "Item_Price");

            migrationBuilder.RenameTable(
                name: "Assets",
                newName: "Asset");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPrices_ItemId",
                table: "Item_Price",
                newName: "IX_Item_Price_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPrices_assetId",
                table: "Item_Price",
                newName: "IX_Item_Price_assetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item_Price",
                table: "Item_Price",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Asset",
                table: "Asset",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Item_Asset_AssetId",
                table: "Asset_Item",
                column: "AssetId",
                principalTable: "Asset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Asset_Asset_AssetId",
                table: "Booking_Asset",
                column: "AssetId",
                principalTable: "Asset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Price_Asset_assetId",
                table: "Item_Price",
                column: "assetId",
                principalTable: "Asset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Price_Item_ItemId",
                table: "Item_Price",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Package_Items_Asset_AssetId",
                table: "Package_Items",
                column: "AssetId",
                principalTable: "Asset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
