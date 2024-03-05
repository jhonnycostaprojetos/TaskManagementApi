using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class alterTaskProjectForNullabe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
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
                value: new DateTime(2024, 3, 5, 19, 20, 21, 227, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 19, 20, 21, 228, DateTimeKind.Utc).AddTicks(1552), new DateTime(2024, 3, 5, 16, 20, 21, 228, DateTimeKind.Local).AddTicks(1514), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 19, 20, 21, 228, DateTimeKind.Utc).AddTicks(3171));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
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
                value: new DateTime(2024, 3, 5, 19, 17, 16, 974, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 19, 17, 16, 974, DateTimeKind.Utc).AddTicks(7161), new DateTime(2024, 3, 5, 16, 17, 16, 974, DateTimeKind.Local).AddTicks(7118), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 19, 17, 16, 974, DateTimeKind.Utc).AddTicks(9212));
        }
    }
}
