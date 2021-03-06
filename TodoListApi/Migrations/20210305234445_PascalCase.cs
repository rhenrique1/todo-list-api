using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoListApi.Migrations
{
    public partial class PascalCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "limite",
                table: "Tarefas",
                newName: "Limite");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Tarefas",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "dataCriacao",
                table: "Tarefas",
                newName: "DataCriacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Limite",
                table: "Tarefas",
                newName: "limite");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Tarefas",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Tarefas",
                newName: "dataCriacao");
        }
    }
}
