using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ClassLibraries.Models;

namespace ClassLibraries.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
         : base(options) {}
        public DataContext()
        {}
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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Obtém as configuraçẽes especificadas em appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Define a base de dados a ser usada
            var cnn = config.GetConnectionString("StoreDB");
            optionsBuilder.UseSqlServer(cnn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relacionamento Many-to-Many (chaves compostas)
         // ID de Comprador e Corretor para Tabela NxN entre as classes
         // Para injeção de dependencias
            modelBuilder.Entity<TrabalhadorSetor>().HasKey(md => new { md.TrabalhadorId,  md.SetorId});

            modelBuilder.Entity<TrabalhadorSetor>()
                .HasOne(cr => cr.Trabalhador)
                .WithMany(cp => cp.TrabalhadorSetores)
                .OnDelete(DeleteBehavior.Restrict);

             // Chaves �nicas
            /*modelBuilder.Entity<Dono>().HasIndex(c => c.DonoId).IsUnique(true);
            modelBuilder.Entity<Endereco>().HasIndex(e => e.EnderecoId).IsUnique(true);
            modelBuilder.Entity<Fazenda>().HasIndex(m => m.FazendaId).IsUnique(true);
            modelBuilder.Entity<Trabalhador>().HasIndex(c => c.TrabalhadorId).IsUnique(true);
            modelBuilder.Entity<Setor>().HasIndex(e => e.SetorId).IsUnique(true);
            modelBuilder.Entity<Sensor>().HasIndex(m => m.SensorId).IsUnique(true); // Chaves �nicas
            modelBuilder.Entity<Cliente>().HasIndex(c => c.PessoaId).IsUnique(true);
            modelBuilder.Entity<Empregado>().HasIndex(e => e.PessoaId).IsUnique(true);
            modelBuilder.Entity<Gerente>().HasIndex(m => m.PessoaId).IsUnique(true); // Chaves �nicas
            modelBuilder.Entity<Cliente>().HasIndex(c => c.PessoaId).IsUnique(true);
            modelBuilder.Entity<Empregado>().HasIndex(e => e.PessoaId).IsUnique(true);
            modelBuilder.Entity<Gerente>().HasIndex(m => m.PessoaId).IsUnique(true); */

            // Solução OnDelete
            //modelBuilder.Entity<ProdutoEtiqueta>()
            //    .HasOne(p => p.Produto)
            //    .WithMany(m => m.ProdutosEtiquetas)
            //    .OnDelete(DeleteBehavior.Restrict);
            
        }

    }

}

