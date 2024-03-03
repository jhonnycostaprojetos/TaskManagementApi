using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskProjectCreateAndUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 3, 23, 15, 5, 374, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 3, 23, 15, 5, 374, DateTimeKind.Utc).AddTicks(8890), new DateTime(2024, 3, 3, 20, 15, 5, 374, DateTimeKind.Local).AddTicks(8838), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 3, 23, 15, 5, 375, DateTimeKind.Utc).AddTicks(445));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 3, 23, 10, 11, 700, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate", "Status" },
                values: new object[] { null, new DateTime(2024, 3, 3, 20, 10, 11, 700, DateTimeKind.Local).AddTicks(9031), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 3, 23, 10, 11, 701, DateTimeKind.Utc).AddTicks(967));
        }
    }
}
