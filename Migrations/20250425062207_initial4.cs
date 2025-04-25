using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventBookingManagementSystem_Backend.Migrations
{
    /// <inheritdoc />
    public partial class initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssetStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    start_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    end_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item_Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Booking_Asset",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    bookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssetId = table.Column<int>(type: "int", nullable: false),
                    assetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    start_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    end_time = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Asset_Asset_assetId",
                        column: x => x.assetId,
                        principalTable: "Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Asset_Booking_bookingId",
                        column: x => x.bookingId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    item_CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Item_Category_item_CategoryId",
                        column: x => x.item_CategoryId,
                        principalTable: "Item_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking_Package",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    BookingId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    packageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking_Package", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Package_Booking_BookingId1",
                        column: x => x.BookingId1,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Package_Packages_packageId",
                        column: x => x.packageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asset_Item",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asset_Item_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asset_Item_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item_Price",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    base_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    asset_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    assetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    price_type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item_Price", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Item_Price_Asset_assetId",
                        column: x => x.assetId,
                        principalTable: "Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_Price_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Package_Item",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    item = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Package_Item_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Package_Item_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Package_Item_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking_Package_Item",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingPackageId = table.Column<int>(type: "int", nullable: false),
                    booking_packageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    itemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking_Package_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Package_Item_Booking_Package_booking_packageId",
                        column: x => x.booking_packageId,
                        principalTable: "Booking_Package",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Package_Item_Item_itemId",
                        column: x => x.itemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Item_AssetId",
                table: "Asset_Item",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Item_ItemId",
                table: "Asset_Item",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Asset_assetId",
                table: "Booking_Asset",
                column: "assetId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Asset_bookingId",
                table: "Booking_Asset",
                column: "bookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Package_BookingId1",
                table: "Booking_Package",
                column: "BookingId1");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Package_packageId",
                table: "Booking_Package",
                column: "packageId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Package_Item_booking_packageId",
                table: "Booking_Package_Item",
                column: "booking_packageId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Package_Item_itemId",
                table: "Booking_Package_Item",
                column: "itemId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_item_CategoryId",
                table: "Item",
                column: "item_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_Price_assetId",
                table: "Item_Price",
                column: "assetId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_Price_ItemId",
                table: "Item_Price",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Package_Item_AssetId",
                table: "Package_Item",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Package_Item_ItemId",
                table: "Package_Item",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Package_Item_PackageId",
                table: "Package_Item",
                column: "PackageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asset_Item");

            migrationBuilder.DropTable(
                name: "Booking_Asset");

            migrationBuilder.DropTable(
                name: "Booking_Package_Item");

            migrationBuilder.DropTable(
                name: "Item_Price");

            migrationBuilder.DropTable(
                name: "Package_Item");

            migrationBuilder.DropTable(
                name: "Booking_Package");

            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Item_Category");
        }
    }
}
