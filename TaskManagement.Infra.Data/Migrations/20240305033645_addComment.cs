using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class addComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskComment = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    IdTaskProject = table.Column<int>(type: "int", nullable: false),
                    TaskProjectId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_TaskProjects_TaskProjectId",
                        column: x => x.TaskProjectId,
                        principalTable: "TaskProjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 3, 36, 45, 233, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 3, 36, 45, 234, DateTimeKind.Utc).AddTicks(6682), new DateTime(2024, 3, 5, 0, 36, 45, 234, DateTimeKind.Local).AddTicks(6594), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 3, 36, 45, 235, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.CreateIndex(
                name: "IX_Comment_TaskProjectId",
                table: "Comment",
                column: "TaskProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 4, 18, 27, 49, 961, DateTimeKind.Utc).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 4, 18, 27, 49, 961, DateTimeKind.Utc).AddTicks(6958), new DateTime(2024, 3, 4, 15, 27, 49, 961, DateTimeKind.Local).AddTicks(6920), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 4, 18, 27, 49, 961, DateTimeKind.Utc).AddTicks(8999));
        }
    }
}
