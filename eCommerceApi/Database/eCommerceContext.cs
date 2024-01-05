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
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerce;Integrated Security=True");
        }
        #endregion
    }
}
