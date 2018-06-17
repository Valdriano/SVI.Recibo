using SVI.Recibo.Infra.TypesConfigurations;
using System.Data.Entity;

namespace SVI.Recibo.Infra
{
    public class ModelConfiguration
    {
        public static void Configure( DbModelBuilder modelBuilder )
        {
            Configuracao( modelBuilder );
            Estados( modelBuilder );
            Municipio( modelBuilder );
        }

        private static void Configuracao( DbModelBuilder modelBuilder ) => modelBuilder.Configurations.Add( new ConfiguracaoTypeConfiguration() );
        private static void Estados( DbModelBuilder modelBuilder ) => modelBuilder.Configurations.Add( new EstadosTypeConfiguration() );
        private static void Municipio( DbModelBuilder modelBuilder ) => modelBuilder.Configurations.Add( new MunicipioTypeConfiguration() );
    }
}
