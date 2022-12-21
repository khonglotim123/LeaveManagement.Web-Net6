using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddperiodToLeaveAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eeaf39c4-09ad-4f6b-b362-116ea241dfb8",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "73ef5308-1af7-40f9-89b2-1c8064590203", "ADMINISTRATOR" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eeaf39c4-09ad-4f6b-b362-116ea241dfb8",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "c282b3a4-fd42-4515-9609-e5a731dd8ac7", "Administrator" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eeag39b4-09dd-4f6b-b362-116ea241hgb8",
                column: "ConcurrencyStamp",
                value: "817a446c-2d03-4635-a288-732b5bea5590");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeaf39b4-02xa-4f6b-b586-116ea241dfb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "910efbc1-9f9f-49d8-893c-b55cd35492b2", "AQAAAAEAACcQAAAAEFvIABmpmeyNxGCX9yHLUGeJXK8kE+oWjru/M287LDmCjM0RjeWGYpmZUANCYfwdLQ==", "06858486-4b67-443f-b1ba-619532ad5bc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeaf39b4-09ad-4f6b-b586-116ea241dfb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56724261-e4f1-46ff-81f7-03b9cf20d103", "AQAAAAEAACcQAAAAEHlHoZEU0Bvb4Rkt1AS8Utu5We7GyXsdKfnLo9HiAbWzLIRf1M/5jKM80tZ4lpcGjQ==", "f97ee81e-e023-42f6-8940-d21bd6c0b772" });
        }
    }
}
