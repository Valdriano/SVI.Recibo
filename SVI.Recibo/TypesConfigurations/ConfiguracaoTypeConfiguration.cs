using SVI.Recibo.Model;
using System.Data.Entity.ModelConfiguration;

namespace SVI.Recibo.TypesConfigurations
{
    public class ConfiguracaoTypeConfiguration : EntityTypeConfiguration<Configuracao>
    {
        public ConfiguracaoTypeConfiguration()
        {
            ToTable("Configuracoes");
            HasKey(pk => pk.IDConfiguracao);
            Property(p => p.Email).IsOptional().HasMaxLength(100);
            Property(p => p.IDConfiguracao).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(p => p.Licenca).HasMaxLength(255);
            Property(p => p.Local).IsRequired().HasMaxLength(40);
            Property(p => p.Proprietario).IsRequired().HasMaxLength(40);
        }
    }
}
