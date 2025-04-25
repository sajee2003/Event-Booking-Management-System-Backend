using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventBookingManagementSystem_Backend.Migrations
{
    /// <inheritdoc />
    public partial class sv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Item_Item_ItemId",
                table: "Asset_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Package_Item_Item_ItemId",
                table: "Booking_Package_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_Category_ItemCategoryId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Price_Item_ItemId",
                table: "Item_Price");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_Items_Item_ItemId",
                table: "Package_Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item_Category",
                table: "Item_Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Item_Category",
                newName: "Item_Categories");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ItemCategoryId",
                table: "Items",
                newName: "IX_Items_ItemCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item_Categories",
                table: "Item_Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Item_Items_ItemId",
                table: "Asset_Item",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Package_Item_Items_ItemId",
                table: "Booking_Package_Item",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Price_Items_ItemId",
                table: "Item_Price",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Item_Categories_ItemCategoryId",
                table: "Items",
                column: "ItemCategoryId",
                principalTable: "Item_Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Package_Items_Items_ItemId",
                table: "Package_Items",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Item_Items_ItemId",
                table: "Asset_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Package_Item_Items_ItemId",
                table: "Booking_Package_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Price_Items_ItemId",
                table: "Item_Price");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Item_Categories_ItemCategoryId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_Items_Items_ItemId",
                table: "Package_Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item_Categories",
                table: "Item_Categories");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameTable(
                name: "Item_Categories",
                newName: "Item_Category");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ItemCategoryId",
                table: "Item",
                newName: "IX_Item_ItemCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item_Category",
                table: "Item_Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Item_Item_ItemId",
                table: "Asset_Item",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Package_Item_Item_ItemId",
                table: "Booking_Package_Item",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_Category_ItemCategoryId",
                table: "Item",
                column: "ItemCategoryId",
                principalTable: "Item_Category",
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
                name: "FK_Package_Items_Item_ItemId",
                table: "Package_Items",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
