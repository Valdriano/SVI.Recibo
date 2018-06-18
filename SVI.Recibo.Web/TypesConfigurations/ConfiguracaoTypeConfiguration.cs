using SVI.Recibo.Web.Models;

namespace SVI.Recibo.Web.TypesConfigurations
{
    public class ConfiguracaoTypeConfiguration : AbstractTypeConfguration<Configuracao>
    {
        protected override void Campos()
        {
            Property( x => x.CNPJ ).HasMaxLength( 14 ).IsOptional();
            Property( x => x.CPF ).HasMaxLength( 11 ).IsOptional();
            Property( x => x.Email ).HasMaxLength( 100 ).IsOptional();
            Property( x => x.Id ).HasDatabaseGeneratedOption( System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity ).IsRequired();
            Property( x => x.IdEstado ).IsRequired();
            Property( x => x.IdMunicipio ).IsRequired();
            Property( x => x.Licenca ).HasMaxLength( 255 ).IsRequired();
            Property( x => x.Proprietario ).HasMaxLength( 60 ).IsRequired();
        }

        protected override void ChaveEstrangeira()
        {
            HasRequired( x => x.Estado ).WithMany( x => x.Configuracoes ).HasForeignKey( x => x.IdEstado ).WillCascadeOnDelete( false );
            HasRequired( x => x.Municipio ).WithMany( x => x.Configuracoes ).HasForeignKey( x => x.IdMunicipio ).WillCascadeOnDelete( false );
        }

        protected override void ChavePrimaria()
        {
            HasKey( x => x.Id );
        }

        protected override void Tabela()
        {
            ToTable( "Configuracoes" );
        }
    }
}