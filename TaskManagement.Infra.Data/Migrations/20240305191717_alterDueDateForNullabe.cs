using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class alterDueDateForNullabe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "TaskProjects",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
                columns: new[] { "CreateAt", "DueDate" },
                values: new object[] { new DateTime(2024, 3, 5, 19, 17, 16, 974, DateTimeKind.Utc).AddTicks(7161), new DateTime(2024, 3, 5, 16, 17, 16, 974, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 19, 17, 16, 974, DateTimeKind.Utc).AddTicks(9212));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "TaskProjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 17, 29, 15, 507, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate" },
                values: new object[] { new DateTime(2024, 3, 5, 17, 29, 15, 507, DateTimeKind.Utc).AddTicks(6182), new DateTime(2024, 3, 5, 14, 29, 15, 507, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 17, 29, 15, 507, DateTimeKind.Utc).AddTicks(7812));
        }
    }
}
