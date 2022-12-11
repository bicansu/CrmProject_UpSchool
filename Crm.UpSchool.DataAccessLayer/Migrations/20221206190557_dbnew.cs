using Microsoft.EntityFrameworkCore.Migrations;

namespace CrmUpSchool.DataAccessLayer.Migrations
{
    public partial class dbnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "REceiverEmail",
                table: "Messages",
                newName: "ReceiverEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReceiverEmail",
                table: "Messages",
                newName: "REceiverEmail");
        }
    }
}
