using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doctor.Persistence.DAL.Migrations
{
    /// <inheritdoc />
    public partial class createprocedurecolums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddImage",
                table: "Procedures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mainİmage",
                table: "Procedures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Permanence",
                table: "Procedures",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddImage",
                table: "Procedures");

            migrationBuilder.DropColumn(
                name: "Mainİmage",
                table: "Procedures");

            migrationBuilder.DropColumn(
                name: "Permanence",
                table: "Procedures");
        }
    }
}
