using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddDefaultUserAndUpdateRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eeaf39c4-09ad-4f6b-b362-116ea241dfb8", "eeaf39b4-02xa-4f6b-b586-116ea241dfb8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eeag39b4-09dd-4f6b-b362-116ea241hgb8", "eeaf39b4-09ad-4f6b-b586-116ea241dfb8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeaf39b4-02xa-4f6b-b586-116ea241dfb8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeaf39b4-09ad-4f6b-b586-116ea241dfb8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eeaf39c4-09ad-4f6b-b362-116ea241dfb8",
                column: "ConcurrencyStamp",
                value: "c282b3a4-fd42-4515-9609-e5a731dd8ac7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eeag39b4-09dd-4f6b-b362-116ea241hgb8",
                column: "ConcurrencyStamp",
                value: "817a446c-2d03-4635-a288-732b5bea5590");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "eeaf39b4-02xa-4f6b-b586-116ea241dfb4", 0, "910efbc1-9f9f-49d8-893c-b55cd35492b2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFvIABmpmeyNxGCX9yHLUGeJXK8kE+oWjru/M287LDmCjM0RjeWGYpmZUANCYfwdLQ==", null, false, "06858486-4b67-443f-b1ba-619532ad5bc7", null, false, "admin@localhost.com" },
                    { "eeaf39b4-09ad-4f6b-b586-116ea241dfb4", 0, "56724261-e4f1-46ff-81f7-03b9cf20d103", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHlHoZEU0Bvb4Rkt1AS8Utu5We7GyXsdKfnLo9HiAbWzLIRf1M/5jKM80tZ4lpcGjQ==", null, false, "f97ee81e-e023-42f6-8940-d21bd6c0b772", null, false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eeaf39c4-09ad-4f6b-b362-116ea241dfb8", "eeaf39b4-02xa-4f6b-b586-116ea241dfb4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eeag39b4-09dd-4f6b-b362-116ea241hgb8", "eeaf39b4-09ad-4f6b-b586-116ea241dfb4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eeaf39c4-09ad-4f6b-b362-116ea241dfb8", "eeaf39b4-02xa-4f6b-b586-116ea241dfb4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eeag39b4-09dd-4f6b-b362-116ea241hgb8", "eeaf39b4-09ad-4f6b-b586-116ea241dfb4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeaf39b4-02xa-4f6b-b586-116ea241dfb4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeaf39b4-09ad-4f6b-b586-116ea241dfb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eeaf39c4-09ad-4f6b-b362-116ea241dfb8",
                column: "ConcurrencyStamp",
                value: "67ade78f-a6af-44f4-b20a-a3d6c18b0800");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eeag39b4-09dd-4f6b-b362-116ea241hgb8",
                column: "ConcurrencyStamp",
                value: "4623916c-7f83-4a1e-a5c7-ad5c05750b36");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "eeaf39b4-02xa-4f6b-b586-116ea241dfb8", 0, "42e35ac4-9890-4965-abeb-ed0631a69539", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEEe6/j2y7vYM/sqNxKXmAKk/p6BMdPlzLk196T/AUXLL3yAS60aF6yUTC6p2F53ieg==", null, false, "2c6eea45-9edc-4f9e-8f13-79cea98a55bd", null, false, "admin@localhost.com" },
                    { "eeaf39b4-09ad-4f6b-b586-116ea241dfb8", 0, "b28f85a9-a561-419f-929a-753d2f4f7cfb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGycFePKORts6wKOExfx7/76i0q/UZmk3LX7XFaUerBMYJiUhdcV3on4HOpWilhgLA==", null, false, "c7df7d8f-c4dc-4ff8-99f5-9a9c3680f1b7", null, false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eeaf39c4-09ad-4f6b-b362-116ea241dfb8", "eeaf39b4-02xa-4f6b-b586-116ea241dfb8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eeag39b4-09dd-4f6b-b362-116ea241hgb8", "eeaf39b4-09ad-4f6b-b586-116ea241dfb8" });
        }
    }
}
