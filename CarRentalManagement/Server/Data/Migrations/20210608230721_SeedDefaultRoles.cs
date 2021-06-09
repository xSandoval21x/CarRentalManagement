using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a4c957fa-cead-4047-be7b-fd8371023853", "c927f665-e50e-4bd3-bf37-ff63a382ed8f", "User", "USER" },
                    { "898ced3e-6a9e-4825-99e0-7590da957c9e", "c504fd95-8397-4242-b356-00db11ec8f47", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 16, 7, 19, 423, DateTimeKind.Local).AddTicks(5349), new DateTime(2021, 6, 8, 16, 7, 19, 437, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 16, 7, 19, 437, DateTimeKind.Local).AddTicks(7016), new DateTime(2021, 6, 8, 16, 7, 19, 437, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 16, 7, 19, 442, DateTimeKind.Local).AddTicks(8483), new DateTime(2021, 6, 8, 16, 7, 19, 442, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 16, 7, 19, 443, DateTimeKind.Local).AddTicks(452), new DateTime(2021, 6, 8, 16, 7, 19, 443, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 16, 7, 19, 444, DateTimeKind.Local).AddTicks(5683), new DateTime(2021, 6, 8, 16, 7, 19, 444, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 16, 7, 19, 444, DateTimeKind.Local).AddTicks(7123), new DateTime(2021, 6, 8, 16, 7, 19, 444, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 16, 7, 19, 444, DateTimeKind.Local).AddTicks(7156), new DateTime(2021, 6, 8, 16, 7, 19, 444, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 16, 7, 19, 444, DateTimeKind.Local).AddTicks(7172), new DateTime(2021, 6, 8, 16, 7, 19, 444, DateTimeKind.Local).AddTicks(7179) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "898ced3e-6a9e-4825-99e0-7590da957c9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4c957fa-cead-4047-be7b-fd8371023853");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 15, 1, 52, 698, DateTimeKind.Local).AddTicks(5082), new DateTime(2021, 6, 8, 15, 1, 52, 709, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 15, 1, 52, 709, DateTimeKind.Local).AddTicks(9612), new DateTime(2021, 6, 8, 15, 1, 52, 709, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 15, 1, 52, 713, DateTimeKind.Local).AddTicks(2006), new DateTime(2021, 6, 8, 15, 1, 52, 713, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 15, 1, 52, 713, DateTimeKind.Local).AddTicks(3051), new DateTime(2021, 6, 8, 15, 1, 52, 713, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(763), new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(2016), new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(2042), new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(2051), new DateTime(2021, 6, 8, 15, 1, 52, 714, DateTimeKind.Local).AddTicks(2055) });
        }
    }
}
