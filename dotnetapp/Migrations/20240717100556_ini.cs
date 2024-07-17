using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetapp.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    BatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.BatchID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BatchID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_Batches_BatchID",
                        column: x => x.BatchID,
                        principalTable: "Batches",
                        principalColumn: "BatchID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "BatchID", "Capacity", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, 30, new DateTime(2024, 7, 17, 11, 5, 56, 419, DateTimeKind.Local).AddTicks(8536), new DateTime(2024, 7, 17, 10, 5, 56, 419, DateTimeKind.Local).AddTicks(8522) },
                    { 2, 25, new DateTime(2024, 7, 18, 11, 5, 56, 419, DateTimeKind.Local).AddTicks(8543), new DateTime(2024, 7, 18, 10, 5, 56, 419, DateTimeKind.Local).AddTicks(8542) },
                    { 3, 20, new DateTime(2024, 7, 19, 11, 5, 56, 419, DateTimeKind.Local).AddTicks(8545), new DateTime(2024, 7, 19, 10, 5, 56, 419, DateTimeKind.Local).AddTicks(8544) },
                    { 4, 15, new DateTime(2024, 7, 20, 11, 5, 56, 419, DateTimeKind.Local).AddTicks(8547), new DateTime(2024, 7, 20, 10, 5, 56, 419, DateTimeKind.Local).AddTicks(8546) },
                    { 5, 10, new DateTime(2024, 7, 21, 11, 5, 56, 419, DateTimeKind.Local).AddTicks(8548), new DateTime(2024, 7, 21, 10, 5, 56, 419, DateTimeKind.Local).AddTicks(8548) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_BatchID",
                table: "Students",
                column: "BatchID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Batches");
        }
    }
}
