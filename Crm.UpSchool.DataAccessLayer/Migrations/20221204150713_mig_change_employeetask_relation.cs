using Microsoft.EntityFrameworkCore.Migrations;

namespace CrmUpSchool.DataAccessLayer.Migrations
{
    public partial class mig_change_employeetask_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "EmployeeTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTasks_AppUserID",
                table: "EmployeeTasks",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AppUserID",
                table: "EmployeeTasks",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AppUserID",
                table: "EmployeeTasks");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTasks_AppUserID",
                table: "EmployeeTasks");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "EmployeeTasks");
        }
    }
}
