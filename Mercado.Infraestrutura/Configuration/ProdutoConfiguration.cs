using Mercado.Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mercado.Infraestrutura.Mapping
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {

        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(x => x.ProdutoId);
            builder.Property(x => x.ProdutoId)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.NomeProduto)
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Preco)
                .HasPrecision(12, 2);

            builder.Property(x => x.Imagem)
                .HasColumnType("image");

            builder.Property(x => x.Estoque)
                .HasColumnType("int");

            //Relacionamento
            //builder.HasMany(x => x.EnderecoClientePessoaFisicas)
            //    .WithOne(x => x.ClientePessoaFisica).HasForeignKey(c => c.EnderecoClientePessoaFisicaId)
            //    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
