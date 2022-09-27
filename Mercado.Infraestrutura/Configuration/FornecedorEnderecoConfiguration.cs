using Mercado.Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mercado.Infraestrutura.Mapping
{
    public class FornecedorEnderecoConfiguration : IEntityTypeConfiguration<FornecedorEndereco>
    {

        public void Configure(EntityTypeBuilder<FornecedorEndereco> builder)
        {
            builder.ToTable("FornecedorEndereco");

            builder.HasKey(x => x.FornecedorEnderecoId);
            builder.Property(x => x.FornecedorEnderecoId)
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