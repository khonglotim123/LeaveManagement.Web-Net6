using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eeaf39c4-09ad-4f6b-b362-116ea241dfb8",
                column: "ConcurrencyStamp",
                value: "953ea500-e39e-4cb6-b66a-a48e1ab07d13");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eeag39b4-09dd-4f6b-b362-116ea241hgb8",
                column: "ConcurrencyStamp",
                value: "0ba8267a-0849-430e-a975-d4cc91c913ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeaf39b4-02xa-4f6b-b586-116ea241dfb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "896bc48b-d276-447c-b6cf-d1632924ebf0", "AQAAAAEAACcQAAAAEK8lsfZerFPrOzTqoBT14WIF1kvjsQDpEF14aTO1Fn0OEoisOHpuMoZpR1L4/DpGsg==", "7c1bf117-b439-4553-8004-a0e8929350d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeaf39b4-09ad-4f6b-b586-116ea241dfb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fe8523c-8349-4997-9592-9bcfada060fc", "AQAAAAEAACcQAAAAEDcogzR1mmOGAsAKqMAn8H8QEOE3oCpl7LKO5bIyluVquj9jfAgBqRSXUT6Hre689g==", "337e1c2d-4e3b-48f6-a8cc-2086b599eb61" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eeaf39c4-09ad-4f6b-b362-116ea241dfb8",
                column: "ConcurrencyStamp",
                value: "73ef5308-1af7-40f9-89b2-1c8064590203");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eeag39b4-09dd-4f6b-b362-116ea241hgb8",
                column: "ConcurrencyStamp",
                value: "5dfb16ae-783a-4705-932a-68ee8757b1bd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeaf39b4-02xa-4f6b-b586-116ea241dfb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1124fcf-7d38-4ada-8079-57b1f1f86f4a", "AQAAAAEAACcQAAAAEHGgmZnWDyJbH0IgpjZ1Be6h2awmCY3r2uB7UTRYRIo7/Q6BcfcYqSJilck3cdPIyA==", "e11d2d5b-3716-4e7a-8a91-7baaea4c2b4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeaf39b4-09ad-4f6b-b586-116ea241dfb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfb36407-7f96-4592-8e13-cf949cad0724", "AQAAAAEAACcQAAAAEN7ipDpw2wNYJTpnKjyBbxpgJm5IZzIW9vHfP6JQ3AVGRzfHwFKL4clEEgu/wUB3zw==", "1d86d62c-476c-4798-84ae-c26e7022485e" });
        }
    }
}
