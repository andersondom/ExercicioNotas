using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDB.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Turma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nota1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Nota2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Nota3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Faltas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alunos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alunos");
        }
    }
}
