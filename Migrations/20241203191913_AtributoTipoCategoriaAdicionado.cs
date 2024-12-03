using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurguerMania.Migrations
{
    /// <inheritdoc />
    public partial class AtributoTipoCategoriaAdicionado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "tipo",
                table: "Categorias",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tipo",
                table: "Categorias");
        }
    }
}
