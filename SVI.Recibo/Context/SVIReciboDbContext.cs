using SVI.Recibo.Model;
using SVI.Recibo.TypesConfigurations;
using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;

namespace SVI.Recibo.Context
{
    public class SVIReciboDbContext : DbContext
    {
        public virtual DbSet<Configuracao> Configuracoes { get; set; }
        public virtual DbSet<Fornecedor> Fornecedores { get; set; }
        public virtual DbSet<Model.Recibo> Recibos { get; set; }

        public SVIReciboDbContext() : base( "name=SVIRecibo" )
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relative = @"..\..\App_Data\";
            string absolute = Path.GetFullPath( Path.Combine( baseDirectory, relative ) );
            AppDomain.CurrentDomain.SetData( "DataDirectory", absolute );

            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            CreateDatabaseIfNotExists<SVIReciboDbContext> createDatabaseIf = new CreateDatabaseIfNotExists<SVIReciboDbContext>();

            Database.SetInitializer( createDatabaseIf );
        }

        protected override void OnModelCreating( DbModelBuilder modelBuilder )
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add( new ConfiguracaoTypeConfiguration() );
            modelBuilder.Configurations.Add( new FornecedorTypeConfiguration() );
            modelBuilder.Configurations.Add( new ReciboTypeConfiguration() );
        }
    }
}
