using ControleFinanceiro.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ControleFinanceiro.Infrastrucure.Data.Mappings
{
    public class DespesaMapConfiguration : EntityTypeConfiguration<Despesa>
    {
        public DespesaMapConfiguration()
        {
            ToTable("tbDespesa");

            HasKey(_ => _.DespesaId);

            Property(_ => _.Descricao)
                .IsRequired()
                .HasMaxLength(150);

            HasRequired(_ => _.Usuario)
                .WithMany()
                .HasForeignKey(_ => _.UsuarioId);
        }
    }
}
