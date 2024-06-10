using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanchonete.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Name, Preco) " +
     "VALUES(" +
     "1," +
     "'pão, hamburguer, ovo, presunto, queijo e batata palha'," +
     "'delicioso pão de hamburguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha'," +
     " 1, " +
     "'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTrYcl1MSUX3mqG1lQ2ctQLagnM2Zx2AguBmw&s'," +
     "'https://media-cdn.tripadvisor.com/media/photo-s/0f/19/46/ed/x-bacon_rotated_90.jpg', " +
     "0," +
     "'Cheese Salada'," +
     "12.50)");

            migrationBuilder.Sql("INSERT INTO lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Name, Preco) " +
                "VALUES(" +
                "1," +
                "'pão, hamburguer, bacon, queijo, alface e tomate'," +
                "'pão de hamburguer com bacon crocante, queijo derretido, alface fresca e tomate suculento'," +
                " 1, " +
                "'https://www.sabornamesa.com.br/media/k2/items/cache/5098e75e57e36807c173cb7490b1b0d2_XL.jpg'," +
                "'https://www.querouai.com.br/gestao/img/produtos/12_867_20220929193412.jpeg', " +
                "0," +
                "'X-Bacon Deluxe'," +
                "15.00)");

            migrationBuilder.Sql("INSERT INTO lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Name, Preco) " +
                "VALUES(" +
                "1," +
                "'pão, hamburguer, queijo, cebola caramelizada e molho especial'," +
                "'pão macio com hamburguer suculento, queijo derretido, cebola caramelizada e molho especial secreto'," +
                " 1, " +
                "'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFGoQqPW-x691fFHp5xl1kgCSrFOUxuOUZDw&s'," +
                "'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQgTctgS9HG_ikpqy8vFWYxF-GOqUuxZyQyqw&s', " +
                "1," +
                "'Onion Burger'," +
                "18.00)");

            migrationBuilder.Sql("INSERT INTO lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Name, Preco) " +
                "VALUES(" +
                "2," +
                "'pão, hamburguer, queijo, tomate, alface e molho barbecue'," +
                "'hamburguer grelhado com queijo derretido, tomate fresco, alface crocante e molho barbecue especial'," +
                " 1," +
                "'https://www.diejungskochenundbacken.de/wp-354a7-content/uploads/2021/05/Cola-BBQ-Burger_Cheddar-20.jpg'," +
                "'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTKpO2LNGYlA_RNz8fx03jzSy805BJL1uLiCA&s', " +
                "0," +
                "'Barbecue Burger'," +
                "20.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
