using SVI.Recibo.Model;
using System.Data.Entity;

namespace SVI.Recibo.Infra
{
    public class SVIReciboDbContext : DbContext
    {
        public SVIReciboDbContext()
            : base( "DBSVIRecibo" )
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        protected override void OnModelCreating( DbModelBuilder modelBuilder )
        {
            ModelConfiguration.Configure( modelBuilder );
            SVIReciboDbInitializer initializer = new SVIReciboDbInitializer( modelBuilder );
            Database.SetInitializer( initializer );
        }

        public virtual DbSet<Configuracao> Configuracoes { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
    }
}
