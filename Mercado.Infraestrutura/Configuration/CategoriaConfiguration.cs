using Mercado.Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mercado.Infraestrutura.Mapping
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            builder.HasKey(x => x.CategoriaId);
            builder.Property(x => x.CategoriaId)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.NomeCategoria)
                .HasColumnType("varchar(200)");

            //Relacionamento
            //builder.HasMany(x => x.EnderecoClientePessoaFisicas)
            //    .WithOne(x => x.ClientePessoaFisica).HasForeignKey(c => c.EnderecoClientePessoaFisicaId)
            //    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
