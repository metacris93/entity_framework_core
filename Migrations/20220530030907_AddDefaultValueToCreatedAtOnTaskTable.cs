using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entity_framework.Migrations
{
    public partial class AddDefaultValueToCreatedAtOnTaskTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Task",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 29, 22, 9, 7, 515, DateTimeKind.Local).AddTicks(3350),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "Id",
                keyValue: new Guid("879fde45-be65-46b0-8822-5f367041b709"),
                column: "CreatedAt",
                value: new DateTime(2022, 5, 29, 22, 9, 7, 515, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "Id",
                keyValue: new Guid("879fde45-be65-46b0-8822-5f367041b711"),
                column: "CreatedAt",
                value: new DateTime(2022, 5, 29, 22, 9, 7, 515, DateTimeKind.Local).AddTicks(1960));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Task",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 5, 29, 22, 9, 7, 515, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "Id",
                keyValue: new Guid("879fde45-be65-46b0-8822-5f367041b709"),
                column: "CreatedAt",
                value: new DateTime(2022, 5, 29, 20, 1, 57, 545, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "Id",
                keyValue: new Guid("879fde45-be65-46b0-8822-5f367041b711"),
                column: "CreatedAt",
                value: new DateTime(2022, 5, 29, 20, 1, 57, 545, DateTimeKind.Local).AddTicks(4340));
        }
    }
}
