using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddnewFieldsForLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TaskComment",
                table: "LogTaskProjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "LogTaskProjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 22, 12, 14, 292, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate" },
                values: new object[] { new DateTime(2024, 3, 5, 22, 12, 14, 292, DateTimeKind.Utc).AddTicks(2381), new DateTime(2024, 3, 5, 19, 12, 14, 292, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 22, 12, 14, 292, DateTimeKind.Utc).AddTicks(3981));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaskComment",
                table: "LogTaskProjects");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LogTaskProjects");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 19, 39, 43, 353, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate" },
                values: new object[] { new DateTime(2024, 3, 5, 19, 39, 43, 354, DateTimeKind.Utc).AddTicks(704), new DateTime(2024, 3, 5, 16, 39, 43, 354, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 19, 39, 43, 354, DateTimeKind.Utc).AddTicks(2307));
        }
    }
}
