using eCommerceModels;
using Microsoft.EntityFrameworkCore;

namespace eCommerceApi.Database
{
    public class eCommerceContext : DbContext
    {
        #region Conexão sem distinção de ambientes de execução
        /*
         * Conexão sem distinção de ambientes de execução
         */
        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<EnderecoEntrega> EnderecoEntrega { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerce;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamentos>().HasData(


                new Departamentos { Id = 1, Name = "Informatica" },
                new Departamentos { Id = 2, Name = "Moda" },
                new Departamentos { Id = 3, Name = "Eletros" },
                new Departamentos { Id = 4, Name = "Beleza" },
            new Departamentos { Id = 5, Name = "Moveis" }
            );

        }

    }
    #endregion
}

