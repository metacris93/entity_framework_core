using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entity_framework.Migrations
{
    public partial class NotRequiredFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Task",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Level", "Name" },
                values: new object[,]
                {
                    { new Guid("879fde45-be65-46b0-8822-5f367041b710"), null, 10, "Actividades personales" },
                    { new Guid("879fde45-be65-46b0-8822-5f367041b717"), null, 20, "Actividades pendientes" }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "TaskPriority", "Title" },
                values: new object[,]
                {
                    { new Guid("879fde45-be65-46b0-8822-5f367041b709"), new Guid("879fde45-be65-46b0-8822-5f367041b710"), new DateTime(2022, 5, 29, 20, 1, 57, 545, DateTimeKind.Local).AddTicks(4370), null, 0, "Ver pelicula en Netflix" },
                    { new Guid("879fde45-be65-46b0-8822-5f367041b711"), new Guid("879fde45-be65-46b0-8822-5f367041b717"), new DateTime(2022, 5, 29, 20, 1, 57, 545, DateTimeKind.Local).AddTicks(4340), null, 1, "Pago de servicios publicos" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: new Guid("879fde45-be65-46b0-8822-5f367041b709"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: new Guid("879fde45-be65-46b0-8822-5f367041b711"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("879fde45-be65-46b0-8822-5f367041b710"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("879fde45-be65-46b0-8822-5f367041b717"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Task",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
