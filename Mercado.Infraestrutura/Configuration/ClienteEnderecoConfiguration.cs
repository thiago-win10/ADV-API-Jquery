using Mercado.Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mercado.Infraestrutura.Mapping
{
    public class ClienteEnderecoConfiguration : IEntityTypeConfiguration<ClienteEndereco>
    {

        public void Configure(EntityTypeBuilder<ClienteEndereco> builder)
        {
            builder.ToTable("ClienteEndereco");

            builder.HasKey(x => x.ClienteEnderecoId);
            builder.Property(x => x.ClienteEnderecoId)
                .ValueGeneratedOnAdd();

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

        }

    }
}

