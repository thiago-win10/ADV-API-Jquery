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

            builder.Property(x => x.Telefone)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.Email)
                .HasColumnType("varchar(100)");

            //Relacionamento
            builder.HasOne<ClienteEndereco>(x => x.ClienteEndereco)
                .WithOne(c => c.Cliente)
                .HasForeignKey<ClienteEndereco>(c => c.EnderecoClienteId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}