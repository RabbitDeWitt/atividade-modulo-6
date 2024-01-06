using daviagens_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace daviagens_api.Data
{

    public class SeedDataPacote : IEntityTypeConfiguration<Pacote>
    {
        public void Configure(EntityTypeBuilder<Pacote> builder) 
        {
            builder.HasData(
                new Pacote { Id=1, nome="Economica", valor=0},
                new Pacote { Id=2, nome="Economica Premium", valor=400},
                new Pacote { Id=3, nome="Executiva", valor=1500},
                new Pacote { Id=4, nome="Primeira Classe", valor=5000}
                );
        }
    }
}
