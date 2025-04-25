using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventBookingManagementSystem_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Check1M : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Asset_Asset_AssetId",
                table: "Booking_Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Asset_Bookings_BookingId",
                table: "Booking_Asset");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booking_Asset",
                table: "Booking_Asset");

            migrationBuilder.RenameTable(
                name: "Booking_Asset",
                newName: "Booking_Assets");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_Asset_BookingId",
                table: "Booking_Assets",
                newName: "IX_Booking_Assets_BookingId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_Asset_AssetId",
                table: "Booking_Assets",
                newName: "IX_Booking_Assets_AssetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booking_Assets",
                table: "Booking_Assets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Assets_Asset_AssetId",
                table: "Booking_Assets",
                column: "AssetId",
                principalTable: "Asset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Assets_Bookings_BookingId",
                table: "Booking_Assets",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Assets_Asset_AssetId",
                table: "Booking_Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Assets_Bookings_BookingId",
                table: "Booking_Assets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booking_Assets",
                table: "Booking_Assets");

            migrationBuilder.RenameTable(
                name: "Booking_Assets",
                newName: "Booking_Asset");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_Assets_BookingId",
                table: "Booking_Asset",
                newName: "IX_Booking_Asset_BookingId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_Assets_AssetId",
                table: "Booking_Asset",
                newName: "IX_Booking_Asset_AssetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booking_Asset",
                table: "Booking_Asset",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Asset_Asset_AssetId",
                table: "Booking_Asset",
                column: "AssetId",
                principalTable: "Asset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Asset_Bookings_BookingId",
                table: "Booking_Asset",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
