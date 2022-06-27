using Mercado.Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mercado.Infraestrutura.Mapping
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");

            builder.HasKey(x => x.FuncionarioId);
            builder.Property(x => x.FuncionarioId)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.NomeCompleto)
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Salario)
            .HasPrecision(12, 2);

            builder.Property(x => x.Setor)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Cargo)
            .HasColumnType("varchar(200)");

            builder.Property(x => x.Email)
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Senha)
                .HasColumnType("varchar(200)");


            //Relacionamento
            //builder.HasMany(x => x.EnderecoClientePessoaFisicas)
            //    .WithOne(x => x.ClientePessoaFisica).HasForeignKey(c => c.EnderecoClientePessoaFisicaId)
            //    .OnDelete(DeleteBehavior.Cascade);

        }

    }
}
