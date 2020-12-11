using Microsoft.EntityFrameworkCore.Migrations;

namespace TrabalhoFinalMVCCRUD.Migrations
{
    public partial class PrimeiraCriacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCompleto = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    NomeLogin = table.Column<string>(type: "varchar(10)", nullable: true),
                    Cargo = table.Column<string>(type: "varchar(100)", nullable: true),
                    Localizacao = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.IdFuncionario);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}
