using SVI.Recibo.Model;

namespace SVI.Recibo.Infra.TypesConfigurations
{
    public class ConfiguracaoTypeConfiguration : AbstractTypeConfguration<Configuracao>
    {

        protected override void Campos()
        {
            this.Property( x => x.Email ).HasMaxLength( 100 ).IsRequired();
            this.Property( x => x.Id ).HasDatabaseGeneratedOption( System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity ).IsRequired();
            this.Property( x => x.IdEstado ).IsRequired();
            this.Property( x => x.IdMunicipio ).IsRequired();
            this.Property( x => x.Licenca ).HasMaxLength( 255 ).IsOptional();
            this.Property( x => x.Proprietario ).HasMaxLength( 60 ).IsRequired();
        }

        protected override void ChaveEstrangeira()
        {
            this.HasRequired( x => x.Estado ).WithMany( x => x.Configuracoes ).HasForeignKey( x => x.IdEstado );
            this.HasRequired( x => x.Municipio ).WithMany( x => x.Configuracoes ).HasForeignKey( x => x.IdMunicipio );
        }

        protected override void ChavePrimaria()
        {
            this.HasKey( x => x.Id );
        }

        protected override void Tabela()
        {
            this.ToTable( "Configuracoes" );
        }
    }
}
