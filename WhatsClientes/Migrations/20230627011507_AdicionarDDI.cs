using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhatsClientes.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDDI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DDI",
                table: "Contatos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DDI",
                table: "Contatos");
        }
    }
}
