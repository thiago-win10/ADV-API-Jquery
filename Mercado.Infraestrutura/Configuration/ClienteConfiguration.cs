using Mercado.Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mercado.Infraestrutura.Mapping
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(x => x.ClienteId);
            builder.Property(x => x.ClienteId)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.NomeCompleto)
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Cpf)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.CartaoFidelidade)
                .HasColumnType("boolean");

            builder.HasIndex(x => x.Cpf)
                .IsUnique(true);

            builder.Property(x => x.Cep)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.Rua)
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Numero)
                .HasColumnType("varchar(50)");

            builder.Property(x => x.Bairro)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Cidade)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Estado)
                .HasColumnType("varchar(2)");

            builder.Property(x => x.Telefone)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.Email)
                .HasColumnType("varchar(100)");

            //Relacionamento
            //builder.HasMany(x => x.EnderecoClientePessoaFisicas)
            //    .WithOne(x => x.ClientePessoaFisica).HasForeignKey(c => c.EnderecoClientePessoaFisicaId)
            //    .OnDelete(DeleteBehavior.Cascade);


        }
    }
}