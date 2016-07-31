using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Infrastrucure.Data.Mappings;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ControleFinanceiro.Infrastrucure.Data
{
    public class ControleFinanceiroContexto : DbContext
    {
        public ControleFinanceiroContexto()
                : base("ControleFinanceiroStrConn")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Despesa> Despesas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == $"{p.ReflectedType.Name}Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new UsuarioMapConfiguration());
            modelBuilder.Configurations.Add(new DespesaMapConfiguration());
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries()
                .Where(_ => !Equals(_.Entity.GetType().GetProperty("DataCadastro"), null));

            if (!entries.Any())
                return base.SaveChanges();

            foreach (var entry in entries)
            {
                if (Equals(entry.State, EntityState.Added))
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;

                if (Equals(entry.State, EntityState.Modified))
                    entry.Property("DataCadastro").IsModified = false;
            }

            return base.SaveChanges();
        }
    }
}
