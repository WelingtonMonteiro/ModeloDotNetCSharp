using Persistence.Entity.Configurations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Persistence.Entity.Context
{
    public class ProjetoBaseDbContext : DbContext
    {
        public ProjetoBaseDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(250));
            
            modelBuilder.Configurations.Add(new PessoaConfiguration());
            modelBuilder.Configurations.Add(new AnimalConfiguration());
            
        }
    }
}
