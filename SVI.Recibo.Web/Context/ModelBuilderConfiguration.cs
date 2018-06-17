using SVI.Recibo.Web.TypesConfigurations;
using System.Data.Entity;

namespace SVI.Recibo.Web.Context
{
    public class ModelBuilderConfiguration
    {
        public static void Configure( DbModelBuilder modelBuilder )
        {
            ConfiguracaoModel( modelBuilder );
            EstadoModel( modelBuilder );
            FornecedorModel( modelBuilder );
            MunicipioModel( modelBuilder );
            ReciboModel( modelBuilder );
        }

        private static void ConfiguracaoModel( DbModelBuilder modelBuilder ) => modelBuilder.Configurations.Add( new ConfiguracaoTypeConfiguration() );
        private static void EstadoModel( DbModelBuilder modelBuilder ) => modelBuilder.Configurations.Add( new EstadoTypeConfiguration() );
        private static void FornecedorModel( DbModelBuilder modelBuilder ) => modelBuilder.Configurations.Add( new FornecedorTypeConfiguration() );
        private static void MunicipioModel( DbModelBuilder modelBuilder ) => modelBuilder.Configurations.Add( new MunicipioTypeConfiguration() );
        private static void ReciboModel( DbModelBuilder modelBuilder ) => modelBuilder.Configurations.Add( new ReciboTypeConfiguration() );
    }
}