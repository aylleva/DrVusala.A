using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doctor.Persistence.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addIconcolumnintoProceduresTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "İcon",
                table: "Procedures",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "İcon",
                table: "Procedures");
        }
    }
}
