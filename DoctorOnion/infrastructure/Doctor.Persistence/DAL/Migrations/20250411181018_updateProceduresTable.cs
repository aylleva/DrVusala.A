using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doctor.Persistence.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateProceduresTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Procedures");

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Procedures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "Procedures");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Procedures",
                type: "decimal(6,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
