using daviagens_api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace daviagens_api.Data
{
    public class SeedDataCliente : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasData(
                new Cliente { Id = 1, nome = "Monkey D. Luffy", dataNasc = "1996-12-25", telefone = "(11)1234-5678", numPassaporte = "BR000001" },
                new Cliente { Id = 2, nome = "Naruto Uzumaki", dataNasc = "1990-04-01", telefone = "(11)1234-5678", numPassaporte = "BR000002" },
                new Cliente { Id = 3, nome = "Tajiro Kamada", dataNasc = "1998-10-21", telefone = "(11)1234-5678", numPassaporte = "BR000003" },
                new Cliente { Id = 4, nome = "Yusuke Urameshi", dataNasc = "1987-01-31", telefone = "(11)1234-5678", numPassaporte = "BR000004" },
                new Cliente { Id = 5, nome = "Kagome Higurashi", dataNasc = "1996-11-24", telefone = "(11)1234-5678", numPassaporte = "BR000005" }
                );
        }
    }
}
