using System.IO;
using ClassLibraries.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ClassLibraries.Contextos
{
    public class DataContext : DbContext
    {
        public IConfigurationRoot Configuration { get; set; }

        public DbSet<Despesca> Despescas { get; set; }
        public DbSet<Dono> Donos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fazenda> Fazendas { get; set; }
        public DbSet<Maneijo> Maneijos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Sensor> Sensores { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Trabalhador> Trabalhadores { get; set; }
        public DbSet<TrabalhadorSetor> TrabalhadorSetores { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Obt�m as configura��es especificadas em appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Define a base de dados a ser usada
            var cnn = config.GetConnectionString("Aqua");
            optionsBuilder.UseSqlServer(cnn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relacionamento Many-to-Many (chaves compostas)
            modelBuilder.Entity<ProdutoEtiqueta>()
                .HasKey(pt => new { ProdutoId = pt.ProdutoId, EtiquetaId = pt.EtiquetaId });

            // Chaves �nicas
            modelBuilder.Entity<Cliente>().HasIndex(c => c.PessoaId).IsUnique(true);
            modelBuilder.Entity<Empregado>().HasIndex(e => e.PessoaId).IsUnique(true);
            modelBuilder.Entity<Gerente>().HasIndex(m => m.PessoaId).IsUnique(true);

            // Solução OnDelete
            //modelBuilder.Entity<ProdutoEtiqueta>()
            //    .HasOne(p => p.Produto)
            //    .WithMany(m => m.ProdutosEtiquetas)
            //    .OnDelete(DeleteBehavior.Restrict);
            
        }

    }

}

