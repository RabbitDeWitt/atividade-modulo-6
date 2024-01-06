using daviagens_api.Data;
using daviagens_api.Models;
using Microsoft.EntityFrameworkCore;

namespace daviagens_api.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)  :base(options){}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DefaultConnection")
                    .UseLazyLoadingProxies()
                    .EnableSensitiveDataLogging();

                // Verifica se o banco de dados existe e o cria se não existir
                this.Database.EnsureCreated();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SeedDataCliente());
            modelBuilder.ApplyConfiguration(new SeedDataDestino());
            modelBuilder.ApplyConfiguration(new SeedDataPacote());


            base.OnModelCreating(modelBuilder);
        }

    }

}
