using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "898ced3e-6a9e-4825-99e0-7590da957c9e",
                column: "ConcurrencyStamp",
                value: "4381c778-4473-40f8-9737-b3c503441e63");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4c957fa-cead-4047-be7b-fd8371023853",
                column: "ConcurrencyStamp",
                value: "eee89f02-935b-4503-8642-5d2650e92241");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "306f5548-ee15-4d1c-b58d-381a1584c8c6", 0, "4d125f55-4ee9-4eb6-b572-ccf8b0748596", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAELb1PHsdOXnwrQymOGSbgx5ISyArjL0hbAn7xNUbqXBHM/nCYq7pe5O3KzlIBp6wYA==", null, false, "351de69d-94e4-413c-a7d7-dbf12017c881", false, "admin@localhost.com" },
                    { "359gh148-ee15-4d1c-b58d-381a1584f2f9", 0, "2c60fdad-8601-47c4-9d73-e4101158f99c", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKZCkY6SQ4gl0EuV4YMhWN7rqrwHI0pCorBDBGG1umIDsuW5ZqGbjpjV8NUvbZQarw==", null, false, "996b591c-4985-42ac-9e95-17ab98809b3b", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 17, 3, 48, 295, DateTimeKind.Local).AddTicks(5187), new DateTime(2021, 6, 8, 17, 3, 48, 305, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 17, 3, 48, 305, DateTimeKind.Local).AddTicks(7028), new DateTime(2021, 6, 8, 17, 3, 48, 305, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 17, 3, 48, 308, DateTimeKind.Local).AddTicks(8072), new DateTime(2021, 6, 8, 17, 3, 48, 308, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 17, 3, 48, 308, DateTimeKind.Local).AddTicks(9236), new DateTime(2021, 6, 8, 17, 3, 48, 308, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 17, 3, 48, 310, DateTimeKind.Local).AddTicks(69), new DateTime(2021, 6, 8, 17, 3, 48, 310, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 17, 3, 48, 310, DateTimeKind.Local).AddTicks(1126), new DateTime(2021, 6, 8, 17, 3, 48, 310, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 17, 3, 48, 310, DateTimeKind.Local).AddTicks(1150), new DateTime(2021, 6, 8, 17, 3, 48, 310, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 8, 17, 3, 48, 310, DateTimeKind.Local).AddTicks(1160), new DateTime(2021, 6, 8, 17, 3, 48, 310, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "898ced3e-6a9e-4825-99e0-7590da957c9e", "306f5548-ee15-4d1c-b58d-381a1584c8c6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a4c957fa-cead-4047-be7b-fd8371023853", "359gh148-ee15-4d1c-b58d-381a1584f2f9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "898ced3e-6a9e-4825-99e0-7590da957c9e", "306f5548-ee15-4d1c-b58d-381a1584c8c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a4c957fa-cead-4047-be7b-fd8371023853", "359gh148-ee15-4d1c-b58d-381a1584f2f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "306f5548-ee15-4d1c-b58d-381a1584c8c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "359gh148-ee15-4d1c-b58d-381a1584f2f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "898ced3e-6a9e-4825-99e0-7590da957c9e",
                column: "ConcurrencyStamp",
                value: "c504fd95-8397-4242-b356-00db11ec8f47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4c957fa-cead-4047-be7b-fd8371023853",
                column: "ConcurrencyStamp",
                value: "c927f665-e50e-4bd3-bf37-ff63a382ed8f");

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
    }
}
