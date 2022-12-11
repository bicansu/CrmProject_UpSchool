using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrmUpSchool.DataAccessLayer.Migrations
{
    public partial class mig_create_task_details_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeTaskDetails",
                columns: table => new
                {
                    EmployeeTaskDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeTaskID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTaskDetails", x => x.EmployeeTaskDetailID);
                    table.ForeignKey(
                        name: "FK_EmployeeTaskDetails_EmployeeTasks_EmployeeTaskID",
                        column: x => x.EmployeeTaskID,
                        principalTable: "EmployeeTasks",
                        principalColumn: "EmployeeTaskID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTaskDetails_EmployeeTaskID",
                table: "EmployeeTaskDetails",
                column: "EmployeeTaskID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTaskDetails");
        }
    }
}
