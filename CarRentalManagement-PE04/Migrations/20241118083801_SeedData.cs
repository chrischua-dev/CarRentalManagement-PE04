using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagementPE04.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(2987), new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3006), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3010), new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3011), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3505), new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3506), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3508), new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3508), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3362), new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3364), "i5", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3367), new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3368), "x5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3370), new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3370), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3372), new DateTime(2024, 11, 18, 16, 38, 0, 415, DateTimeKind.Local).AddTicks(3373), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
