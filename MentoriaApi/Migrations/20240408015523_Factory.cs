using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentoriaApi.Migrations
{
    /// <inheritdoc />
    public partial class Factory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cartao",
                table: "ContasReceber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cartao",
                table: "ContasPagar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cartao",
                table: "ContasReceber");

            migrationBuilder.DropColumn(
                name: "Cartao",
                table: "ContasPagar");
        }
    }
}
