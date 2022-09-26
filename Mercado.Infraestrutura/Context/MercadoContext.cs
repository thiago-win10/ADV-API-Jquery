using Mercado.Entidades.Models;
using Mercado.Infraestrutura.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Mercado.Infraestrutura.Context
{
    public class MercadoContext : DbContext
    {
        public MercadoContext(DbContextOptions<MercadoContext> options) : base(options)
        {
        }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<ClienteEndereco> ClienteEnderecos { get; set; }
        public DbSet<FornecedorEndereco> FornecedorEnderecos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }

        public string ObterStringConexao()
        {
            string conn = "Data Source=DESKTOP-H6JQJL4;Initial Catalog=MercadoBD;Integrated Security=True";
            return conn;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Entity Configuration
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new FornecedorConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteEnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new FornecedorEnderecoConfiguration());


        }

    }
}


