using LanchesMac.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            List<Categoria> categorias = new List<Categoria>();

            categorias.Add(new Categoria()
            {
                Nome = "Normal",
                Descricao = "Lanche feito com ingredientes normais"
            });

            categorias.Add(new Categoria()
            {
                Nome = "Natural",
                Descricao = "Lanche feito com ingredientes integrais e naturais"
            });

            foreach (var cat in categorias)
            {
                migrationBuilder.Sql(@$"INSERT INTO Categorias( Nome        , Descricao)
                                        VALUES                ( '{cat.Nome}', '{cat.Descricao}')");
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
