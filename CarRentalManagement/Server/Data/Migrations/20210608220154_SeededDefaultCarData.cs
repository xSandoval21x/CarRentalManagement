using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 8, 15, 1, 52, 698, DateTimeKind.Local).AddTicks(5082), new DateTime(2021, 6, 8, 15, 1, 52, 709, DateTimeKind.Local).AddTicks(5945), "Black", "System" },
                    { 2, "System", new DateTime(2021, 6, 8, 15, 1, 52, 709, DateTimeKind.Local).AddTicks(9612), new DateTime(2021, 6, 8, 15, 1, 52, 709, DateTimeKind.Local).AddTicks(9649), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 8, 15, 1, 52, 713, DateTimeKind.Local).AddTicks(2006), new DateTime(2021, 6, 8, 15, 1, 52, 713, DateTimeKind.Local).AddTicks(2073), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 6, 8, 15, 1, 52, 713, DateTimeKind.Local).AddTicks(3051), new DateTime(2021, 6, 8, 15, 1, 52, 713, DateTimeKind.Local).AddTicks(3070), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(763), new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(794), "Corolla", "System" },
                    { 2, "System", new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(2016), new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(2036), "Matrix", "System" },
                    { 3, "System", new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(2042), new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(2046), "3 Series", "System" },
                    { 4, "System", new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(2051), new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(2055), "X1", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
