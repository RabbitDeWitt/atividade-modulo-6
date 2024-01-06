using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daviagens_api.Migrations
{
    public partial class daviagensDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dataNasc = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numPassaporte = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mensagem = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricaoCompleta = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    img = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor = table.Column<float>(type: "float", nullable: false),
                    desconto = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pacotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacotes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dataPartida = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dataRetorno = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor = table.Column<float>(type: "float", nullable: false),
                    clienteId = table.Column<int>(type: "int", nullable: false),
                    destinoId = table.Column<int>(type: "int", nullable: false),
                    pacoteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservas_Clientes_clienteId",
                        column: x => x.clienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Destinos_destinoId",
                        column: x => x.destinoId,
                        principalTable: "Destinos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Pacotes_pacoteId",
                        column: x => x.pacoteId,
                        principalTable: "Pacotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "dataNasc", "nome", "numPassaporte", "telefone" },
                values: new object[,]
                {
                    { 1, "1996-12-25", "Monkey D. Luffy", "BR000001", "(11)1234-5678" },
                    { 2, "1990-04-01", "Naruto Uzumaki", "BR000002", "(11)1234-5678" },
                    { 3, "1998-10-21", "Tajiro Kamada", "BR000003", "(11)1234-5678" },
                    { 4, "1987-01-31", "Yusuke Urameshi", "BR000004", "(11)1234-5678" },
                    { 5, "1996-11-24", "Kagome Higurashi", "BR000005", "(11)1234-5678" }
                });

            migrationBuilder.InsertData(
                table: "Destinos",
                columns: new[] { "Id", "desconto", "descricao", "descricaoCompleta", "img", "nome", "tipo", "valor" },
                values: new object[,]
                {
                    { 1, 7f, "Rio de Janeiro, beleza que inspira.", "O Rio de Janeiro, cidade maravilhosa do Brasil, encanta com suas praias deslumbrantes, montanhas majestosas, e um carnaval contagiante, proporcionando uma experiência única e apaixonante aos visitantes.", "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/urca.jpg", "Rio de Janeiro", "NACIONAL", 705f },
                    { 2, 20f, "Seoul, a cidade das mil faces e infinitas possibilidades.", "Seoul, uma metrópole eletrizante que combina tradição e modernidade, oferecendo uma rica tapeçaria cultural, tecnológica e gastronômica, que hipnotiza e encanta seus visitantes.", "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/seoul.jpg", "Seoul", "INTERNACIONAL", 10675f },
                    { 3, 7f, "Salvador, onde história e encanto se encontram.", "Salvador, a cidade do axé e da cultura afro-brasileira, encanta com suas praias deslumbrantes, arquitetura colonial colorida e festas animadas, emanando uma energia contagiante em cada esquina.", "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/salvador.jpg", "Salvador", "NACIONAL", 866f },
                    { 4, 15f, "São Francisco, cidade da Califórnia encantadora.", "São Francisco, cidade vibrante na costa oeste dos EUA, é famosa pela icônica Golden Gate Bridge, cenário tecnológico e cultura diversificada, proporcionando uma experiência cativante e inesquecível aos seus visitantes.", "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/sanfrancisco.jpg", "São Francisco", "INTERNACIONAL", 4180f },
                    { 5, 20f, "Sydney, a deslumbrante cidade australiana.", "Sydney, a espetacular metrópole australiana, que combina praias de tirar o fôlego, uma arquitetura moderna e icônica, além de uma vida cultural vibrante, tornando-se uma das cidades mais fascinantes e desejadas do mundo.", "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/sidney.jpg", "Sidney", "INTERNACIONAL", 9275f },
                    { 6, 5f, "Mariana, uma encantadora cidade mineira.", "Mariana, cidade histórica de Minas Gerais, fascina com suas igrejas barrocas preservadas, casarões coloniais e paisagens pitorescas, transportando os visitantes para um passado encantador do Brasil colonial.", "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/mariana.jpg", "Mariana", "NACIONAL", 874f },
                    { 7, 5f, "Curitiba, verdejante metrópole com rica cultura brasileira.", "Curitiba, a capital ecológica do Brasil, encanta com seus parques bem-cuidados, sistema de transporte eficiente e uma rica cena cultural, oferecendo uma qualidade de vida invejável aos seus moradores.", "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/curitiba.jpg", "Curitiba", "NACIONAL", 483f },
                    { 8, 10f, "Recife, cidade encantadora do Nordeste brasileiro.", "Recife, a joia do Nordeste brasileiro, encanta com suas praias de águas mornas e coqueirais, sua rica história que mescla tradição e modernidade, e a alegria contagiante de seu povo, sempre acolhedor e vibrante.", "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/recife.jpg", "Recife", "NACIONAL", 1596f },
                    { 9, 13f, "Paris, a cidade luz do romantismo e da cultura.", "Paris, a romântica Cidade Luz, cativa com seus ícones icônicos como a Torre Eiffel e o Louvre, além de uma cultura sofisticada e gastronomia refinada, tornando-se um Destinos inesquecível para os apaixonados por arte, história e charme.", "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/paris.jpg", "Paris", "INTERNACIONAL", 4716f },
                    { 10, 10f, "Londres, a metrópole multicultural e cheia de história.", "Londres, a capital britânica, brilha com uma rica tapeçaria de história e modernidade, destacando-se com seus marcos emblemáticos, cultura diversificada e dinâmica cena artística, tornando-se uma cidade perfeita para explorar.", "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/london.jpg", "Londres", "INTERNACIONAL", 5347f },
                    { 11, 15f, "Tóquio, metrópole futurista e vibrante do Japão.", "Tóquio, combina modernidade e tradição em uma harmoniosa fusão. Seus arranha-céus reluzentes, templos ancestrais e cultura pop enérgica encantam os visitantes do mundo todo, oferecendo uma experiência única e inesquecível.", "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/tokyo.jpg", "Tóquio", "INTERNACIONAL", 7547f },
                    { 12, 10f, "São Luís, cidade histórica e culturalmente rica.", "São Luís, capital do Maranhão, é um tesouro histórico com sua arquitetura colonial preservada e rica herança cultural. Suas praias exuberantes e gastronomia típica completam a experiência encantadora.", "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/maranhao.jpg", "Maranhão", "NACIONAL", 1856f }
                });

            migrationBuilder.InsertData(
                table: "Pacotes",
                columns: new[] { "Id", "nome", "valor" },
                values: new object[,]
                {
                    { 1, "Economica", 0f },
                    { 2, "Economica Premium", 400f },
                    { 3, "Executiva", 1500f },
                    { 4, "Primeira Classe", 5000f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_clienteId",
                table: "Reservas",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_destinoId",
                table: "Reservas",
                column: "destinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_pacoteId",
                table: "Reservas",
                column: "pacoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Destinos");

            migrationBuilder.DropTable(
                name: "Pacotes");
        }
    }
}
