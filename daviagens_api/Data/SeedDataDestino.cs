using daviagens_api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace daviagens_api.Data
{
    public class SeedDataDestino : IEntityTypeConfiguration<Destino>
    {
        public void Configure(EntityTypeBuilder<Destino> builder)
        {
            builder.HasData(
                new Destino { 
                    Id = 1,
                    nome = "Rio de Janeiro",
                    valor=705,
                    descricao="Rio de Janeiro, beleza que inspira.",
                    descricaoCompleta="O Rio de Janeiro, cidade maravilhosa do Brasil, encanta com suas praias deslumbrantes, montanhas majestosas, e um carnaval contagiante, proporcionando uma experiência única e apaixonante aos visitantes.", 
                    desconto= 7, 
                    img="https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/urca.jpg", 
                    tipo="NACIONAL" },
                 new Destino
                 {
                     Id = 2,
                     nome = "Seoul",
                     valor = 10675,
                     descricao = "Seoul, a cidade das mil faces e infinitas possibilidades.",
                     descricaoCompleta = "Seoul, uma metrópole eletrizante que combina tradição e modernidade, oferecendo uma rica tapeçaria cultural, tecnológica e gastronômica, que hipnotiza e encanta seus visitantes.",
                     desconto = 20,
                     img = "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/seoul.jpg",
                     tipo = "INTERNACIONAL"
                 },
                 new Destino
                 {
                     Id = 3,
                     nome = "Salvador",
                     valor = 866,
                     descricao = "Salvador, onde história e encanto se encontram.",
                     descricaoCompleta = "Salvador, a cidade do axé e da cultura afro-brasileira, encanta com suas praias deslumbrantes, arquitetura colonial colorida e festas animadas, emanando uma energia contagiante em cada esquina.",
                     desconto = 7,
                     img = "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/salvador.jpg",
                     tipo = "NACIONAL"
                 },
                 new Destino
                 {
                     Id=4,
                     nome="São Francisco",
                     valor=4180,
                     descricao="São Francisco, cidade da Califórnia encantadora.",
                     descricaoCompleta="São Francisco, cidade vibrante na costa oeste dos EUA, é famosa pela icônica Golden Gate Bridge, cenário tecnológico e cultura diversificada, proporcionando uma experiência cativante e inesquecível aos seus visitantes.",
                     desconto=15,
                     img="https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/sanfrancisco.jpg",
                     tipo="INTERNACIONAL"
                 },
                 new Destino
                 {
                     Id=5,
                     nome="Sidney",
                     valor=9275,
                     descricao="Sydney, a deslumbrante cidade australiana.",
                     descricaoCompleta="Sydney, a espetacular metrópole australiana, que combina praias de tirar o fôlego, uma arquitetura moderna e icônica, além de uma vida cultural vibrante, tornando-se uma das cidades mais fascinantes e desejadas do mundo.",
                     desconto=20,
                     img="https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/sidney.jpg",
                     tipo="INTERNACIONAL"
                 },
                 new Destino
                 {
                     Id=6,
                     nome="Mariana",
                     valor = 874,
                     descricao = "Mariana, uma encantadora cidade mineira.",
                     descricaoCompleta = "Mariana, cidade histórica de Minas Gerais, fascina com suas igrejas barrocas preservadas, casarões coloniais e paisagens pitorescas, transportando os visitantes para um passado encantador do Brasil colonial.",
                     desconto = 5,
                     img = "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/mariana.jpg",
                     tipo = "NACIONAL"
                 },
                 new Destino
                 {
                     Id = 7,
                     nome = "Curitiba",
                     valor = 483,
                     descricao="Curitiba, verdejante metrópole com rica cultura brasileira.",
                     descricaoCompleta="Curitiba, a capital ecológica do Brasil, encanta com seus parques bem-cuidados, sistema de transporte eficiente e uma rica cena cultural, oferecendo uma qualidade de vida invejável aos seus moradores.",
                     desconto = 5,
                     img="https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/curitiba.jpg",
                     tipo="NACIONAL"
                 },
                 new Destino
                 {
                     Id=8,
                     nome = "Recife",
                     valor = 1596,
                     descricao="Recife, cidade encantadora do Nordeste brasileiro.",
                     descricaoCompleta="Recife, a joia do Nordeste brasileiro, encanta com suas praias de águas mornas e coqueirais, sua rica história que mescla tradição e modernidade, e a alegria contagiante de seu povo, sempre acolhedor e vibrante.",
                     desconto = 10,
                     img="https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/recife.jpg",
                     tipo="NACIONAL"
                 },
                 new Destino
                 {
                     Id=9,
                     nome="Paris",
                     valor = 4716,
                     descricao = "Paris, a cidade luz do romantismo e da cultura.",
                     descricaoCompleta = "Paris, a romântica Cidade Luz, cativa com seus ícones icônicos como a Torre Eiffel e o Louvre, além de uma cultura sofisticada e gastronomia refinada, tornando-se um Destinos inesquecível para os apaixonados por arte, história e charme.",
                     desconto = 13,
                     img = "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/paris.jpg",
                     tipo = "INTERNACIONAL"
                 },
                 new Destino
                 {
                     Id = 10,
                     nome="Londres",
                     valor=5347,
                     descricao="Londres, a metrópole multicultural e cheia de história.",
                     descricaoCompleta="Londres, a capital britânica, brilha com uma rica tapeçaria de história e modernidade, destacando-se com seus marcos emblemáticos, cultura diversificada e dinâmica cena artística, tornando-se uma cidade perfeita para explorar.",
                     desconto=10,
                     img="https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/london.jpg",
                     tipo="INTERNACIONAL"
                 },
                 new Destino
                 {
                     Id = 11,
                     nome="Tóquio",
                     valor=7547,
                     descricao="Tóquio, metrópole futurista e vibrante do Japão.",
                     descricaoCompleta="Tóquio, combina modernidade e tradição em uma harmoniosa fusão. Seus arranha-céus reluzentes, templos ancestrais e cultura pop enérgica encantam os visitantes do mundo todo, oferecendo uma experiência única e inesquecível.",
                     desconto = 15,
                     img = "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/tokyo.jpg",
                     tipo = "INTERNACIONAL"
                 },
                 new Destino
                 {
                     Id=12,
                     nome = "Maranhão",
                     valor = 1856,
                     descricao="São Luís, cidade histórica e culturalmente rica.",
                     descricaoCompleta="São Luís, capital do Maranhão, é um tesouro histórico com sua arquitetura colonial preservada e rica herança cultural. Suas praias exuberantes e gastronomia típica completam a experiência encantadora.",
                     desconto = 10,
                     img = "https://raw.githubusercontent.com/RabbitDeWitt/Atividade-Modulo-2/master/site/assets/imgs/maranhao.jpg",
                     tipo="NACIONAL"
                 }
                );
        }
    }
}