using LanchesMac.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Globalization;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            List<Lanche> lanches = new List<Lanche>();

            lanches.Add(new Lanche()
            {
                CategoriaId = 1,
                Nome = "Xis Salada",
                Preco = 14.50m,
                DescricaoCurta = "Pão, bife, ovo, presunto, queijo e batata palha",
                DescricaoDetalhada = "Delicioso pão de hambúrguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha",
                EmEstoque = true,
                IsLanchePreferido = false,
                ImagemThumbnailUrl = "xis-salada1.jpg",
                ImagemUrl = "xis-salada1.jpg",

            });

            lanches.Add(new Lanche()
            {
                CategoriaId = 1,
                Nome = "Xis Bacon",
                Preco = 18,
                DescricaoCurta = "Pão, bife, bacon, ovo, presunto e queijo",
                DescricaoDetalhada = "Delicioso pão de hambúrguer com ovo frito; Pedacinhos de bacon de primeira, crocantes, feito com muito amor e carinho",
                EmEstoque = true,
                IsLanchePreferido = true,
                ImagemThumbnailUrl = "xis-bacon1.jpeg",
                ImagemUrl = "xis-bacon1.jpeg",

            });

            lanches.Add(new Lanche()
            {
                CategoriaId = 1,
                Nome = "Xis Cinco Queijos",
                Preco = 20,
                DescricaoCurta = "Pão, bife, bacon, ovo, presunto e cinco tipos diferentes de queijo",
                DescricaoDetalhada = "Perfeito para aqueles que amam queijo mais do que qualquer outra coisa! Por apenas R$20,00, você come um xis e cinco tipos diferentes de queijo.",
                EmEstoque = true,
                IsLanchePreferido = false,
                ImagemThumbnailUrl = "xis-queijo1.jpeg",
                ImagemUrl = "xis-queijo1.jpeg",

            });

            lanches.Add(new Lanche()
            {
                CategoriaId = 2,
                Nome = "Xis Vegetariano",
                Preco = 12.50m,
                DescricaoCurta = "Pão, hambúrguer vegetariano, ovo e queijo",
                DescricaoDetalhada = "Um delicioso xis vegetariano, com carne de soja feita para nossos queridos vegetarianos",
                EmEstoque = true,
                IsLanchePreferido = false,
                ImagemThumbnailUrl = "xis-vegetariano1.jpg",
                ImagemUrl = "xis-vegetariano1.jpg",
            });

            foreach (var l in lanches)
            {
                int bitEmEstoque = (l.EmEstoque) ? 1 : 0;
                int bitIsLanchePreferido = (l.IsLanchePreferido) ? 1 : 0;
                string numberPreco = l.Preco.ToString().Replace(",", ".");

                migrationBuilder.Sql($@"INSERT INTO Lanches (CategoriaId, Nome, Preco, DescricaoCurta, DescricaoDetalhada, EmEstoque, IsLanchePreferido, ImagemThumbnailUrl, ImagemUrl)
                                                    VALUES  ({l.CategoriaId}, '{l.Nome}', {numberPreco}, '{l.DescricaoCurta}', '{l.DescricaoDetalhada}', {bitEmEstoque}, {bitIsLanchePreferido}, '{l.ImagemThumbnailUrl}', '{l.ImagemUrl}')");
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
