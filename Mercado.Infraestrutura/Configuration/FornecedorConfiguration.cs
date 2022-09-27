using Mercado.Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mercado.Infraestrutura.Mapping
{
    public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");

            builder.HasKey(x => x.FornecedorId);
            builder.Property(x => x.FornecedorId)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.NomeFornecedor)
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Cnpj)
                .HasColumnType("varchar(20)");

            builder.HasIndex(x => x.Cnpj)
                .IsUnique(true);

            builder.Property(x => x.Telefone)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.Email)
                .HasColumnType("varchar(100)");

            builder.HasIndex(x => x.Email)
                .IsUnique(true);

            //Relacionamento
            builder.HasOne<FornecedorEndereco>(x => x.FornecedorEndereco)
                .WithOne(c => c.Fornecedor)
                .HasForeignKey<FornecedorEndereco>(c => c.EnderecoFornecedorId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
