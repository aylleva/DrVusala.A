using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doctor.Persistence.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateslides : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "Slides",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "Slides");
        }
    }
}
