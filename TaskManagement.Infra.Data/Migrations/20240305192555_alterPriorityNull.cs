using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class alterPriorityNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Priority",
                table: "TaskProjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 19, 25, 54, 837, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate", "Priority" },
                values: new object[] { new DateTime(2024, 3, 5, 19, 25, 54, 837, DateTimeKind.Utc).AddTicks(7830), new DateTime(2024, 3, 5, 16, 25, 54, 837, DateTimeKind.Local).AddTicks(7787), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 19, 25, 54, 837, DateTimeKind.Utc).AddTicks(9584));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Priority",
                table: "TaskProjects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 19, 23, 16, 789, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate", "Priority" },
                values: new object[] { new DateTime(2024, 3, 5, 19, 23, 16, 790, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 3, 5, 16, 23, 16, 790, DateTimeKind.Local).AddTicks(932), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 19, 23, 16, 790, DateTimeKind.Utc).AddTicks(2631));
        }
    }
}
