using ControleFinanceiro.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ControleFinanceiro.Infrastrucure.Data.Mappings
{
    public class UsuarioMapConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapConfiguration()
        {
            ToTable("tbUsuario");

            HasKey(c => c.UsuarioId);

            Property(c => c.NomeCompleto)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Login)
                .IsRequired()
                .HasMaxLength(40);

            Property(c => c.Senha)
                .IsRequired()
                .HasMaxLength(40);

            Property(c => c.Email)
                .IsRequired();
        }
    }
}
